using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using System.Windows.Forms;

namespace WS_Fleck
{
    public partial class MainForm : Form
    {
        private BaseLib.Tools.IniFile setting;
        private Dictionary<string, IWebSocketConnection> _wsClients = null;
        private WebSocketServer _wsServer = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task t1 = new Task(LoadConfig);
            t1.Start();
            Task t2 = t1.ContinueWith(t => InitWebSocket());

        }
        private void LoadConfig()
        {
            setting = new BaseLib.Tools.IniFile(Environment.CurrentDirectory + "\\Config\\Setting.ini");

        }
        private void InitWebSocket()
        {
            if (setting.ReadContentValue("ProgramSetting", "WebSocket") == "1")
            {
                FleckLog.Level = LogLevel.Debug;

                string ip = setting.ReadContentValue("ProgramSetting", "WebSocketIP");
                string port = setting.ReadContentValue("ProgramSetting", "WebSocketPort");
                string location = string.Format("ws://{0}:{1}", ip, port); //0.0.0.0监听所有的的地址

                _wsClients = new Dictionary<string, IWebSocketConnection>();
                _wsServer = new WebSocketServer(location);

                _wsServer.Start(socket =>
                {
                    socket.OnOpen = () =>
                    {
                        string[] array = new string[4];
                        array[0] = socket.ConnectionInfo.Id.ToString();
                        array[1] = socket.ConnectionInfo.ClientIpAddress;
                        array[2] = socket.ConnectionInfo.ClientPort.ToString();
                        array[3] = DateTime.Now.ToString();

                        _wsClients.Add(socket.ConnectionInfo.Id.ToString(), socket);

                        ListViewItem clientView = new ListViewItem(array, 0);
                        lvUIClient.Invoke((MethodInvoker)delegate
                        {
                            this.lvUIClient.Items.Add(clientView);
                        });

                    };

                    socket.OnClose = () =>
                    {
                        if (_wsClients.ContainsKey(socket.ConnectionInfo.Id.ToString()))
                        {
                            _wsClients.Remove(socket.ConnectionInfo.Id.ToString());
                        }
                        lvUIClient.Invoke((MethodInvoker)delegate
                        {
                            foreach (ListViewItem item in lvUIClient.Items)
                            {
                                if (item.SubItems[0].Text == socket.ConnectionInfo.Id.ToString())
                                {
                                    lvUIClient.Items.Remove(item);
                                    break;
                                }
                            }
                        });
                    };

                    socket.OnBinary = bytes =>
                    {

                    };

                    socket.OnMessage = message =>
                    {
                        socket.Send("{\"code\":20000,\"data\":{\"roles\":[\"admin\"],\"introduction\":\"I am a super administrator\",\"avatar\":\"https://wpimg.wallstcn.com/f778738c-e4f8-4870-b634-56703b4acafe.gif\",\"name\":\"超级管理员\"},\"extra\":\"\",\"message\":\"\"}");

                    };
                }
                );

            }
            else
            {
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
