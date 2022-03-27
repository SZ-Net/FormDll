using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClientConfig
{
    public partial class FormConfig : Form
    {
		private XmlDocument xmlDoc ;
		private string clientEnvConfigFileName;
		private string executablePath = Application.ExecutablePath;
		public FormConfig()
        {
            InitializeComponent();
        }
		private void fmConfig_Load(object sender, EventArgs e)
		{
			executablePath = executablePath.Substring(0, executablePath.LastIndexOf("\\") + 1);
			clientEnvConfigFileName = executablePath + "ClientEnv.config";
			xmlDoc  = new XmlDocument();
			if (File.Exists(clientEnvConfigFileName))
			{
				xmlDoc .Load(clientEnvConfigFileName);
				DispBasic(flag: true);
				DispDB(update: true, 0);
				DispAdvance(flag: true);
			}
			else
			{
				MessageBox.Show("Env.Config or ClientEnv.config does not exist,PLS check it!!!");
			}
			btBSave.Enabled = false;
			btBCancel.Enabled = false;
			btDSave.Enabled = false;
			btDCancel.Enabled = false;
			Text = Text + " (Version: " + FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\ClientConfig.exe").Comments + ")";
		}

		private void DispBasic(bool flag)
		{
			if (flag)
			{
				xmlDoc .Load(clientEnvConfigFileName);
				XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/info/line");
				tbLine.Text = xmlNode.InnerText;
				xmlNode = xmlNode.NextSibling;
				tbSection.Text = xmlNode.InnerText;
				xmlNode = xmlNode.NextSibling;
				tbStation.Text = xmlNode.InnerText;
				xmlNode = xmlDoc .SelectSingleNode("environment/client_language");
				tbLanguage.Text = xmlNode.InnerText;
				xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/check_domain");
				cbCheckDomain.Text = xmlNode.InnerText;
				xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/load_in_memory");
				cbLoadInMemory.Text = xmlNode.InnerText;
			
				tbLine.ReadOnly = true;
				tbSection.ReadOnly = true;
			
				tbStation.ReadOnly = true;
				tbLanguage.ReadOnly = true;
				cbCheckDomain.Enabled = false;
				cbLoadInMemory.Enabled = false;
			}
			else
			{
				
				tbLine.ReadOnly = false;
				tbSection.ReadOnly = false;
			
				tbStation.ReadOnly = false;
				tbLanguage.ReadOnly = false;
				cbCheckDomain.Enabled = true;
				cbLoadInMemory.Enabled = true;
			}
		}

		private void btBModify_Click(object sender, EventArgs e)
		{
			DispBasic(flag: false);
			if (tbLoginType.Text == "")
			{
				cmbLoginType.SelectedIndex = 0;
			}
			else
			{
				cmbLoginType.Text = tbLoginType.Text;
			}
			if (tbConType.Text == "")
			{
				cmbConType.SelectedIndex = 0;
			}
			else
			{
				cmbConType.Text = tbConType.Text;
			}
			btBSave.Enabled = true;
			btBCancel.Enabled = true;
			btAMod_Click(null, null);
		}

		private void btBSave_Click(object sender, EventArgs e)
		{
			if (cmbLoginType.Text == "Nolog" && cmbConType.Text == "APS")
			{
				MessageBox.Show("The connection type <APS> is not available if the login type is <Nolog>");
				return;
			}
			if (tbPath.Text.Trim() == "")
			{
				MessageBox.Show("The <DLL path > is empty, PLS check it !!!");
				return;
			}
			XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/info/line");
			xmlNode.InnerText = tbLine.Text.Trim().ToUpper();
			xmlNode = xmlNode.NextSibling;
			xmlNode.InnerText = tbSection.Text.Trim().ToUpper();
			xmlNode = xmlNode.NextSibling;
			xmlNode.InnerText = tbStation.Text.Trim().ToUpper();
			xmlNode = xmlDoc .SelectSingleNode("environment/client_language");
			xmlNode.InnerText = tbLanguage.Text.Trim();
			xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/check_domain");
			xmlNode.InnerText = cbCheckDomain.Text;
			xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/load_in_memory");
			xmlNode.InnerText = cbLoadInMemory.Text;
			xmlDoc .Save(clientEnvConfigFileName);
			DispBasic(flag: true);
			btBSave.Enabled = false;
			btBCancel.Enabled = false;
			btASave_Click(null, null);
		}

		private void btBCancel_Click(object sender, EventArgs e)
		{
			DispBasic(flag: true);
			btBSave.Enabled = false;
			btBCancel.Enabled = false;
			btACancel_Click(null, null);
		}

		private void DispAdvance(bool flag)
		{
			if (flag)
			{
				xmlDoc .Load(clientEnvConfigFileName);
				XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/login_type");
				tbLoginType.Text = xmlNode.InnerText;
				xmlNode = xmlDoc .SelectSingleNode("environment/dll_path");
				tbPath.Text = xmlNode.InnerText;
				xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/connection_type");
				tbConType.Text = xmlNode.InnerText;
				tbLoginType.ReadOnly = true;
				tbLoginType.Visible = true;
				tbPath.ReadOnly = true;
				tbConType.ReadOnly = true;
				tbConType.Visible = true;
			}
			else
			{
				tbLoginType.Visible = false;
				tbConType.Visible = false;
				tbPath.ReadOnly = false;
			}
		}

		private void btAMod_Click(object sender, EventArgs e)
		{
			DispAdvance(flag: false);
		}

		private void btACancel_Click(object sender, EventArgs e)
		{
			DispAdvance(flag: true);
		}

		private void btASave_Click(object sender, EventArgs e)
		{
			XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/login_type");
			xmlNode.InnerText = cmbLoginType.Text.Trim();
			xmlNode = xmlDoc .SelectSingleNode("environment/dll_path");
			xmlNode.InnerText = tbPath.Text.Trim();
			xmlNode = xmlDoc .SelectSingleNode("environment/client_parameter/connection_type");
			xmlNode.InnerText = cmbConType.Text.Trim();
			xmlDoc .Save(clientEnvConfigFileName);
			DispAdvance(flag: true);
		}

		private void DispDB(bool update, int index)
		{
			xmlDoc .Load(clientEnvConfigFileName);
			XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/db_links");
			if (update)
			{
				if (xmlNode.HasChildNodes)
				{
					XmlNode xmlNode2 = xmlNode.ChildNodes[index];
					XmlNodeList childNodes = xmlNode2.ChildNodes;
					tbName.Text = childNodes[0].InnerText;
					tbHost.Text = childNodes[1].InnerText;
					tbPort.Text = childNodes[2].InnerText;
					tbSID.Text = childNodes[5].InnerText;
					tbUserName.Text = childNodes[3].InnerText;
					tbPWD.Text = childNodes[4].InnerText;
					XmlNodeList childNodes2 = xmlNode.ChildNodes;
					lbxDB.Items.Clear();
					lbxDB.BeginUpdate();
					foreach (XmlNode item in childNodes2)
					{
						lbxDB.Items.Add(item.ChildNodes[0].InnerText);
					}
					lbxDB.EndUpdate();
					lbxDB.SelectedIndex = index;
				}
				else
				{
					ClearTextBox();
					lbxDB.Items.Clear();
				}
				btDSave.Enabled = false;
				btDCancel.Enabled = false;
			}
			else
			{
				XmlNode xmlNode2 = xmlNode.ChildNodes[index];
				XmlNodeList childNodes = xmlNode2.ChildNodes;
				tbName.Text = childNodes[0].InnerText;
				tbHost.Text = childNodes[1].InnerText;
				tbPort.Text = childNodes[2].InnerText;
				tbSID.Text = childNodes[5].InnerText;
				tbUserName.Text = childNodes[3].InnerText;
				tbPWD.Text = childNodes[4].InnerText;
			}
		}

		private void lbDB_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbxDB.SelectedIndex != -1)
			{
				DispDB(update: false, lbxDB.SelectedIndex);
			}
		}

		private void btDAdd_Click(object sender, EventArgs e)
		{
			ClearTextBox();
			DenyEdit(flag: false);
			btDSave.Enabled = true;
			btDCancel.Enabled = true;
			btDDele.Enabled = false;
			btDMod.Enabled = false;
			btDAdd.Enabled = false;
			btDSave.Tag = "ADD";
		}

		private void ClearTextBox()
		{
			tbName.Clear();
			tbHost.Clear();
			tbPort.Clear();
			tbSID.Clear();
			tbUserName.Clear();
			tbPWD.Clear();
		}

		private void btDMod_Click(object sender, EventArgs e)
		{
			DenyEdit(flag: false);
			btDSave.Enabled = true;
			btDCancel.Enabled = true;
			btDDele.Enabled = false;
			btDAdd.Enabled = false;
			btDMod.Enabled = false;
			btDSave.Tag = "MOD";
		}

		private void DenyEdit(bool flag)
		{
			tbName.ReadOnly = flag;
			tbHost.ReadOnly = flag;
			tbPort.ReadOnly = flag;
			tbSID.ReadOnly = flag;
			tbUserName.ReadOnly = flag;
			tbPWD.ReadOnly = flag;
		}

		private void btDSave_Click(object sender, EventArgs e)
		{
			if (tbName.Text.Trim() == "")
			{
				MessageBox.Show("The <DB Name> is empty, PLS check it!!!");
				return;
			}
			if (tbHost.Text.Trim() == "")
			{
				MessageBox.Show("The <DB Host> is empty, PLS check it!!!");
				return;
			}
			if (tbPort.Text.Trim() == "")
			{
				MessageBox.Show("The <DB Port> is empty, PLS check it!!!");
				return;
			}
			if (tbSID.Text.Trim() == "")
			{
				MessageBox.Show("The <DB SID> is empty, PLS check it!!!");
				return;
			}
			if (tbUserName.Text.Trim() == "")
			{
				MessageBox.Show("The <DB UserName> is empty, PLS check it!!!");
				return;
			}
			if (tbPWD.Text.Trim() == "")
			{
				MessageBox.Show("The <DB PassWord> is empty, PLS check it!!!");
				return;
			}
			xmlDoc .Load(clientEnvConfigFileName);
			XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/db_links");
			string text = btDSave.Tag.ToString();
			if (!(text == "ADD"))
			{
				if (text == "MOD")
				{
					XmlNode xmlNode2 = xmlNode.ChildNodes[lbxDB.SelectedIndex];
					xmlNode2.ChildNodes[0].InnerText = tbName.Text.Trim();
					xmlNode2.ChildNodes[1].InnerText = tbHost.Text.Trim();
					xmlNode2.ChildNodes[2].InnerText = tbPort.Text.Trim();
					xmlNode2.ChildNodes[3].InnerText = tbUserName.Text.Trim();
					if (tbPWD.Text.IndexOf("{PWD}") != -1)
					{
						xmlNode2.ChildNodes[4].InnerText = tbPWD.Text.Trim();
					}
					else
					{
						xmlNode2.ChildNodes[4].InnerText = GetPwdString(tbPWD.Text.Trim()) + "{PWD}";
					}
					xmlNode2.ChildNodes[5].InnerText = tbSID.Text.Trim();
					xmlDoc .Save(clientEnvConfigFileName);
					DispDB(update: true, lbxDB.SelectedIndex);
				}
			}
			else
			{
				XmlNode xmlNode2 = xmlDoc .CreateElement("db");
				XmlNode xmlNode3 = xmlDoc .CreateElement("name");
				xmlNode3.InnerText = tbName.Text.Trim();
				xmlNode2.AppendChild(xmlNode3);
				xmlNode3 = xmlDoc .CreateElement("host");
				xmlNode3.InnerText = tbHost.Text.Trim();
				xmlNode2.AppendChild(xmlNode3);
				xmlNode3 = xmlDoc .CreateElement("port");
				xmlNode3.InnerText = tbPort.Text.Trim();
				xmlNode2.AppendChild(xmlNode3);
				xmlNode3 = xmlDoc .CreateElement("user");
				xmlNode3.InnerText = tbUserName.Text.Trim();
				xmlNode2.AppendChild(xmlNode3);
				xmlNode3 = xmlDoc .CreateElement("password");
				if (tbPWD.Text.IndexOf("{PWD}") != -1)
				{
					xmlNode3.InnerText = tbPWD.Text.Trim();
				}
				else
				{
					xmlNode3.InnerText = GetPwdString(tbPWD.Text.Trim()) + "{PWD}";
				}
				xmlNode2.AppendChild(xmlNode3);
				xmlNode3 = xmlDoc .CreateElement("sid");
				xmlNode3.InnerText = tbSID.Text.Trim();
				xmlNode2.AppendChild(xmlNode3);
				xmlNode.AppendChild(xmlNode2);
				xmlDoc .Save(clientEnvConfigFileName);
				DispDB(update: true, lbxDB.Items.Count);
			}
			DenyEdit(flag: true);
			btDSave.Enabled = false;
			btDCancel.Enabled = false;
			btDDele.Enabled = true;
			btDMod.Enabled = true;
			btDAdd.Enabled = true;
		}

		private string GetPwdString(string pwd)
		{
			string text = "";
			for (int i = 0; i < pwd.Length; i++)
			{
				text += (char)(pwd[pwd.Length - 1 - i] ^ pwd.Length);
			}
			return text;
		}

		private void btDCancel_Click(object sender, EventArgs e)
		{
			if (btDSave.Tag.ToString() == "MOD")
			{
				if (lbxDB.SelectedIndex != -1)
				{
					DispDB(update: false, lbxDB.SelectedIndex);
				}
			}
			else
			{
				DispDB(update: false, 0);
			}
			DenyEdit(flag: true);
			btDSave.Enabled = false;
			btDCancel.Enabled = false;
			btDDele.Enabled = true;
			btDMod.Enabled = true;
			btDAdd.Enabled = true;
		}

		private void btDDele_Click(object sender, EventArgs e)
		{
			if (lbxDB.SelectedIndex != -1 && MessageBox.Show("Are you sure to delete it ?", "Delete Confirm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
			{
				XmlNode xmlNode = xmlDoc .SelectSingleNode("environment/db_links");
				XmlNode oldChild = xmlNode.ChildNodes[lbxDB.SelectedIndex];
				xmlNode.RemoveChild(oldChild);
				xmlDoc .Save(clientEnvConfigFileName);
				DispDB(update: true, 0);
				btDSave.Enabled = false;
				btDCancel.Enabled = false;
			}
		}

		private void DispAP(bool update, string Loca, int index)
		{
		}

		private void tbLine_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			textBox.Text = textBox.Text.Trim().ToUpper();
		}

	}
}
