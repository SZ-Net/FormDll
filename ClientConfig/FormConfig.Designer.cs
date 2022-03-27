
namespace ClientConfig
{
    partial class FormConfig
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbStation = new System.Windows.Forms.TextBox();
            this.tbSection = new System.Windows.Forms.TextBox();
            this.lbSection = new System.Windows.Forms.Label();
            this.tpDBSetting = new System.Windows.Forms.TabPage();
            this.lbDBList = new System.Windows.Forms.Label();
            this.lbxDB = new System.Windows.Forms.ListBox();
            this.btDDele = new System.Windows.Forms.Button();
            this.btDAdd = new System.Windows.Forms.Button();
            this.btDCancel = new System.Windows.Forms.Button();
            this.btDSave = new System.Windows.Forms.Button();
            this.btDMod = new System.Windows.Forms.Button();
            this.tbPWD = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbSID = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcMESClientConfig = new System.Windows.Forms.TabControl();
            this.tpBasic = new System.Windows.Forms.TabPage();
            this.gbAdvance = new System.Windows.Forms.GroupBox();
            this.cbLoadInMemory = new System.Windows.Forms.ComboBox();
            this.cbCheckDomain = new System.Windows.Forms.ComboBox();
            this.lbLoadInMemory = new System.Windows.Forms.Label();
            this.lbCheckDomain = new System.Windows.Forms.Label();
            this.gbClientEnv = new System.Windows.Forms.GroupBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.tbLoginType = new System.Windows.Forms.TextBox();
            this.tbConType = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cmbConType = new System.Windows.Forms.ComboBox();
            this.cmbLoginType = new System.Windows.Forms.ComboBox();
            this.lbDllPath = new System.Windows.Forms.Label();
            this.lbConnection = new System.Windows.Forms.Label();
            this.lbLoginType = new System.Windows.Forms.Label();
            this.btBCancel = new System.Windows.Forms.Button();
            this.btBSave = new System.Windows.Forms.Button();
            this.btBModify = new System.Windows.Forms.Button();
            this.gbMESInfomation = new System.Windows.Forms.GroupBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbStation = new System.Windows.Forms.Label();
            this.tpDBSetting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcMESClientConfig.SuspendLayout();
            this.tpBasic.SuspendLayout();
            this.gbAdvance.SuspendLayout();
            this.gbClientEnv.SuspendLayout();
            this.gbMESInfomation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStation
            // 
            this.tbStation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStation.ForeColor = System.Drawing.Color.Black;
            this.tbStation.Location = new System.Drawing.Point(89, 99);
            this.tbStation.Name = "tbStation";
            this.tbStation.ReadOnly = true;
            this.tbStation.Size = new System.Drawing.Size(145, 27);
            this.tbStation.TabIndex = 26;
            // 
            // tbSection
            // 
            this.tbSection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSection.ForeColor = System.Drawing.Color.Black;
            this.tbSection.Location = new System.Drawing.Point(89, 67);
            this.tbSection.Name = "tbSection";
            this.tbSection.ReadOnly = true;
            this.tbSection.Size = new System.Drawing.Size(145, 27);
            this.tbSection.TabIndex = 22;
            // 
            // lbSection
            // 
            this.lbSection.AutoSize = true;
            this.lbSection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSection.ForeColor = System.Drawing.Color.Black;
            this.lbSection.Location = new System.Drawing.Point(9, 70);
            this.lbSection.Name = "lbSection";
            this.lbSection.Size = new System.Drawing.Size(69, 19);
            this.lbSection.TabIndex = 21;
            this.lbSection.Text = "Section:";
            // 
            // tpDBSetting
            // 
            this.tpDBSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDBSetting.Controls.Add(this.lbDBList);
            this.tpDBSetting.Controls.Add(this.lbxDB);
            this.tpDBSetting.Controls.Add(this.btDDele);
            this.tpDBSetting.Controls.Add(this.btDAdd);
            this.tpDBSetting.Controls.Add(this.btDCancel);
            this.tpDBSetting.Controls.Add(this.btDSave);
            this.tpDBSetting.Controls.Add(this.btDMod);
            this.tpDBSetting.Controls.Add(this.tbPWD);
            this.tpDBSetting.Controls.Add(this.lbPassword);
            this.tpDBSetting.Controls.Add(this.tbUserName);
            this.tpDBSetting.Controls.Add(this.tbSID);
            this.tpDBSetting.Controls.Add(this.tbPort);
            this.tpDBSetting.Controls.Add(this.tbHost);
            this.tpDBSetting.Controls.Add(this.tbName);
            this.tpDBSetting.Controls.Add(this.lbUserName);
            this.tpDBSetting.Controls.Add(this.lbSID);
            this.tpDBSetting.Controls.Add(this.lbPort);
            this.tpDBSetting.Controls.Add(this.lbHost);
            this.tpDBSetting.Controls.Add(this.lbName);
            this.tpDBSetting.Location = new System.Drawing.Point(4, 29);
            this.tpDBSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDBSetting.Name = "tpDBSetting";
            this.tpDBSetting.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDBSetting.Size = new System.Drawing.Size(659, 439);
            this.tpDBSetting.TabIndex = 1;
            this.tpDBSetting.Text = "DB Setting";
            // 
            // lbDBList
            // 
            this.lbDBList.AutoSize = true;
            this.lbDBList.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Underline);
            this.lbDBList.Location = new System.Drawing.Point(31, 39);
            this.lbDBList.Name = "lbDBList";
            this.lbDBList.Size = new System.Drawing.Size(88, 23);
            this.lbDBList.TabIndex = 35;
            this.lbDBList.Text = "DB List:";
            // 
            // lbxDB
            // 
            this.lbxDB.FormattingEnabled = true;
            this.lbxDB.ItemHeight = 18;
            this.lbxDB.Location = new System.Drawing.Point(34, 71);
            this.lbxDB.Name = "lbxDB";
            this.lbxDB.Size = new System.Drawing.Size(237, 220);
            this.lbxDB.TabIndex = 34;
            this.lbxDB.SelectedIndexChanged += new System.EventHandler(this.lbDB_SelectedIndexChanged);
            // 
            // btDDele
            // 
            this.btDDele.Location = new System.Drawing.Point(117, 324);
            this.btDDele.Name = "btDDele";
            this.btDDele.Size = new System.Drawing.Size(77, 33);
            this.btDDele.TabIndex = 33;
            this.btDDele.Text = "Delete";
            this.btDDele.UseVisualStyleBackColor = true;
            this.btDDele.Click += new System.EventHandler(this.btDDele_Click);
            // 
            // btDAdd
            // 
            this.btDAdd.Location = new System.Drawing.Point(200, 324);
            this.btDAdd.Name = "btDAdd";
            this.btDAdd.Size = new System.Drawing.Size(62, 33);
            this.btDAdd.TabIndex = 32;
            this.btDAdd.Text = "Add";
            this.btDAdd.UseVisualStyleBackColor = true;
            this.btDAdd.Click += new System.EventHandler(this.btDAdd_Click);
            // 
            // btDCancel
            // 
            this.btDCancel.Location = new System.Drawing.Point(475, 324);
            this.btDCancel.Name = "btDCancel";
            this.btDCancel.Size = new System.Drawing.Size(86, 33);
            this.btDCancel.TabIndex = 31;
            this.btDCancel.Text = "Cancel";
            this.btDCancel.UseVisualStyleBackColor = true;
            this.btDCancel.Click += new System.EventHandler(this.btDCancel_Click);
            // 
            // btDSave
            // 
            this.btDSave.Location = new System.Drawing.Point(374, 324);
            this.btDSave.Name = "btDSave";
            this.btDSave.Size = new System.Drawing.Size(66, 33);
            this.btDSave.TabIndex = 30;
            this.btDSave.Text = "Save";
            this.btDSave.UseVisualStyleBackColor = true;
            this.btDSave.Click += new System.EventHandler(this.btDSave_Click);
            // 
            // btDMod
            // 
            this.btDMod.Location = new System.Drawing.Point(34, 324);
            this.btDMod.Name = "btDMod";
            this.btDMod.Size = new System.Drawing.Size(77, 33);
            this.btDMod.TabIndex = 29;
            this.btDMod.Text = "Modify";
            this.btDMod.UseVisualStyleBackColor = true;
            this.btDMod.Click += new System.EventHandler(this.btDMod_Click);
            // 
            // tbPWD
            // 
            this.tbPWD.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbPWD.Location = new System.Drawing.Point(389, 279);
            this.tbPWD.Name = "tbPWD";
            this.tbPWD.ReadOnly = true;
            this.tbPWD.Size = new System.Drawing.Size(172, 28);
            this.tbPWD.TabIndex = 11;
            this.tbPWD.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbPassword.Location = new System.Drawing.Point(287, 282);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(97, 20);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbUserName.Location = new System.Drawing.Point(389, 238);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(172, 28);
            this.tbUserName.TabIndex = 9;
            // 
            // tbSID
            // 
            this.tbSID.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbSID.Location = new System.Drawing.Point(389, 197);
            this.tbSID.Name = "tbSID";
            this.tbSID.ReadOnly = true;
            this.tbSID.Size = new System.Drawing.Size(172, 28);
            this.tbSID.TabIndex = 7;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbPort.Location = new System.Drawing.Point(389, 156);
            this.tbPort.Name = "tbPort";
            this.tbPort.ReadOnly = true;
            this.tbPort.Size = new System.Drawing.Size(172, 28);
            this.tbPort.TabIndex = 5;
            // 
            // tbHost
            // 
            this.tbHost.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbHost.Location = new System.Drawing.Point(389, 115);
            this.tbHost.Name = "tbHost";
            this.tbHost.ReadOnly = true;
            this.tbHost.Size = new System.Drawing.Size(172, 28);
            this.tbHost.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbName.Location = new System.Drawing.Point(389, 74);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(172, 28);
            this.tbName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbUserName.Location = new System.Drawing.Point(277, 241);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(111, 20);
            this.lbUserName.TabIndex = 8;
            this.lbUserName.Text = "User Name:";
            // 
            // lbSID
            // 
            this.lbSID.AutoSize = true;
            this.lbSID.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbSID.Location = new System.Drawing.Point(327, 200);
            this.lbSID.Name = "lbSID";
            this.lbSID.Size = new System.Drawing.Size(50, 20);
            this.lbSID.TabIndex = 6;
            this.lbSID.Text = "SID:";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbPort.Location = new System.Drawing.Point(325, 159);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(51, 20);
            this.lbPort.TabIndex = 4;
            this.lbPort.Text = "Port:";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbHost.Location = new System.Drawing.Point(322, 117);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(56, 20);
            this.lbHost.TabIndex = 2;
            this.lbHost.Text = "Host:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbName.Location = new System.Drawing.Point(315, 77);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // tbLine
            // 
            this.tbLine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLine.ForeColor = System.Drawing.Color.Black;
            this.tbLine.Location = new System.Drawing.Point(89, 35);
            this.tbLine.Name = "tbLine";
            this.tbLine.ReadOnly = true;
            this.tbLine.Size = new System.Drawing.Size(145, 27);
            this.tbLine.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tcMESClientConfig);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 472);
            this.panel2.TabIndex = 3;
            // 
            // tcMESClientConfig
            // 
            this.tcMESClientConfig.Controls.Add(this.tpBasic);
            this.tcMESClientConfig.Controls.Add(this.tpDBSetting);
            this.tcMESClientConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMESClientConfig.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMESClientConfig.ItemSize = new System.Drawing.Size(48, 25);
            this.tcMESClientConfig.Location = new System.Drawing.Point(0, 0);
            this.tcMESClientConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcMESClientConfig.Name = "tcMESClientConfig";
            this.tcMESClientConfig.SelectedIndex = 0;
            this.tcMESClientConfig.Size = new System.Drawing.Size(667, 472);
            this.tcMESClientConfig.TabIndex = 1;
            this.tcMESClientConfig.Click += new System.EventHandler(this.btBModify_Click);
            // 
            // tpBasic
            // 
            this.tpBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpBasic.Controls.Add(this.gbAdvance);
            this.tpBasic.Controls.Add(this.gbClientEnv);
            this.tpBasic.Controls.Add(this.btBCancel);
            this.tpBasic.Controls.Add(this.btBSave);
            this.tpBasic.Controls.Add(this.btBModify);
            this.tpBasic.Controls.Add(this.gbMESInfomation);
            this.tpBasic.Location = new System.Drawing.Point(4, 29);
            this.tpBasic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpBasic.Name = "tpBasic";
            this.tpBasic.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpBasic.Size = new System.Drawing.Size(659, 439);
            this.tpBasic.TabIndex = 0;
            this.tpBasic.Text = "Basic";
            // 
            // gbAdvance
            // 
            this.gbAdvance.Controls.Add(this.cbLoadInMemory);
            this.gbAdvance.Controls.Add(this.cbCheckDomain);
            this.gbAdvance.Controls.Add(this.lbLoadInMemory);
            this.gbAdvance.Controls.Add(this.lbCheckDomain);
            this.gbAdvance.Font = new System.Drawing.Font("Verdana", 11F);
            this.gbAdvance.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbAdvance.Location = new System.Drawing.Point(31, 199);
            this.gbAdvance.Name = "gbAdvance";
            this.gbAdvance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbAdvance.Size = new System.Drawing.Size(309, 170);
            this.gbAdvance.TabIndex = 30;
            this.gbAdvance.TabStop = false;
            this.gbAdvance.Text = "Client_Parameter";
            // 
            // cbLoadInMemory
            // 
            this.cbLoadInMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoadInMemory.FormattingEnabled = true;
            this.cbLoadInMemory.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbLoadInMemory.Location = new System.Drawing.Point(152, 84);
            this.cbLoadInMemory.Name = "cbLoadInMemory";
            this.cbLoadInMemory.Size = new System.Drawing.Size(121, 30);
            this.cbLoadInMemory.TabIndex = 28;
            // 
            // cbCheckDomain
            // 
            this.cbCheckDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheckDomain.FormattingEnabled = true;
            this.cbCheckDomain.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbCheckDomain.Location = new System.Drawing.Point(152, 41);
            this.cbCheckDomain.Name = "cbCheckDomain";
            this.cbCheckDomain.Size = new System.Drawing.Size(121, 30);
            this.cbCheckDomain.TabIndex = 27;
            // 
            // lbLoadInMemory
            // 
            this.lbLoadInMemory.AutoSize = true;
            this.lbLoadInMemory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadInMemory.ForeColor = System.Drawing.Color.Black;
            this.lbLoadInMemory.Location = new System.Drawing.Point(8, 86);
            this.lbLoadInMemory.Name = "lbLoadInMemory";
            this.lbLoadInMemory.Size = new System.Drawing.Size(133, 19);
            this.lbLoadInMemory.TabIndex = 25;
            this.lbLoadInMemory.Text = "Load In Memory:";
            // 
            // lbCheckDomain
            // 
            this.lbCheckDomain.AutoSize = true;
            this.lbCheckDomain.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckDomain.ForeColor = System.Drawing.Color.Black;
            this.lbCheckDomain.Location = new System.Drawing.Point(17, 45);
            this.lbCheckDomain.Name = "lbCheckDomain";
            this.lbCheckDomain.Size = new System.Drawing.Size(117, 19);
            this.lbCheckDomain.TabIndex = 23;
            this.lbCheckDomain.Text = "Check Update:";
            // 
            // gbClientEnv
            // 
            this.gbClientEnv.Controls.Add(this.tbLanguage);
            this.gbClientEnv.Controls.Add(this.lbLanguage);
            this.gbClientEnv.Controls.Add(this.tbLoginType);
            this.gbClientEnv.Controls.Add(this.tbConType);
            this.gbClientEnv.Controls.Add(this.tbPath);
            this.gbClientEnv.Controls.Add(this.cmbConType);
            this.gbClientEnv.Controls.Add(this.cmbLoginType);
            this.gbClientEnv.Controls.Add(this.lbDllPath);
            this.gbClientEnv.Controls.Add(this.lbConnection);
            this.gbClientEnv.Controls.Add(this.lbLoginType);
            this.gbClientEnv.Font = new System.Drawing.Font("Verdana", 11F);
            this.gbClientEnv.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbClientEnv.Location = new System.Drawing.Point(31, 20);
            this.gbClientEnv.Name = "gbClientEnv";
            this.gbClientEnv.Size = new System.Drawing.Size(309, 173);
            this.gbClientEnv.TabIndex = 29;
            this.gbClientEnv.TabStop = false;
            this.gbClientEnv.Text = "Client Environment";
            // 
            // tbLanguage
            // 
            this.tbLanguage.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLanguage.Location = new System.Drawing.Point(150, 126);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.ReadOnly = true;
            this.tbLanguage.Size = new System.Drawing.Size(138, 26);
            this.tbLanguage.TabIndex = 46;
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.Color.Black;
            this.lbLanguage.Location = new System.Drawing.Point(11, 129);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(126, 18);
            this.lbLanguage.TabIndex = 45;
            this.lbLanguage.Text = "Client Language:";
            // 
            // tbLoginType
            // 
            this.tbLoginType.Font = new System.Drawing.Font("Arial", 10F);
            this.tbLoginType.Location = new System.Drawing.Point(150, 27);
            this.tbLoginType.Name = "tbLoginType";
            this.tbLoginType.ReadOnly = true;
            this.tbLoginType.Size = new System.Drawing.Size(138, 27);
            this.tbLoginType.TabIndex = 44;
            // 
            // tbConType
            // 
            this.tbConType.Font = new System.Drawing.Font("Arial", 10F);
            this.tbConType.Location = new System.Drawing.Point(150, 62);
            this.tbConType.Name = "tbConType";
            this.tbConType.ReadOnly = true;
            this.tbConType.Size = new System.Drawing.Size(138, 27);
            this.tbConType.TabIndex = 43;
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(150, 96);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(138, 26);
            this.tbPath.TabIndex = 42;
            // 
            // cmbConType
            // 
            this.cmbConType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConType.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbConType.FormattingEnabled = true;
            this.cmbConType.Items.AddRange(new object[] {
            "APS",
            "File",
            "Auth"});
            this.cmbConType.Location = new System.Drawing.Point(150, 62);
            this.cmbConType.Name = "cmbConType";
            this.cmbConType.Size = new System.Drawing.Size(121, 25);
            this.cmbConType.TabIndex = 41;
            // 
            // cmbLoginType
            // 
            this.cmbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoginType.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbLoginType.FormattingEnabled = true;
            this.cmbLoginType.Items.AddRange(new object[] {
            "Nolog",
            "Login"});
            this.cmbLoginType.Location = new System.Drawing.Point(150, 27);
            this.cmbLoginType.Name = "cmbLoginType";
            this.cmbLoginType.Size = new System.Drawing.Size(121, 25);
            this.cmbLoginType.TabIndex = 40;
            // 
            // lbDllPath
            // 
            this.lbDllPath.AutoSize = true;
            this.lbDllPath.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDllPath.ForeColor = System.Drawing.Color.Black;
            this.lbDllPath.Location = new System.Drawing.Point(50, 99);
            this.lbDllPath.Name = "lbDllPath";
            this.lbDllPath.Size = new System.Drawing.Size(77, 18);
            this.lbDllPath.TabIndex = 39;
            this.lbDllPath.Text = "DLL Path:";
            // 
            // lbConnection
            // 
            this.lbConnection.AutoSize = true;
            this.lbConnection.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnection.ForeColor = System.Drawing.Color.Black;
            this.lbConnection.Location = new System.Drawing.Point(39, 63);
            this.lbConnection.Name = "lbConnection";
            this.lbConnection.Size = new System.Drawing.Size(91, 18);
            this.lbConnection.TabIndex = 38;
            this.lbConnection.Text = "Connection:";
            // 
            // lbLoginType
            // 
            this.lbLoginType.AutoSize = true;
            this.lbLoginType.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginType.ForeColor = System.Drawing.Color.Black;
            this.lbLoginType.Location = new System.Drawing.Point(41, 28);
            this.lbLoginType.Name = "lbLoginType";
            this.lbLoginType.Size = new System.Drawing.Size(88, 18);
            this.lbLoginType.TabIndex = 37;
            this.lbLoginType.Text = "Login Type:";
            // 
            // btBCancel
            // 
            this.btBCancel.Location = new System.Drawing.Point(364, 375);
            this.btBCancel.Name = "btBCancel";
            this.btBCancel.Size = new System.Drawing.Size(79, 29);
            this.btBCancel.TabIndex = 28;
            this.btBCancel.Text = "Cancel";
            this.btBCancel.UseVisualStyleBackColor = true;
            this.btBCancel.Click += new System.EventHandler(this.btBCancel_Click);
            // 
            // btBSave
            // 
            this.btBSave.Location = new System.Drawing.Point(263, 375);
            this.btBSave.Name = "btBSave";
            this.btBSave.Size = new System.Drawing.Size(75, 29);
            this.btBSave.TabIndex = 27;
            this.btBSave.Text = "Save";
            this.btBSave.UseVisualStyleBackColor = true;
            this.btBSave.Click += new System.EventHandler(this.btBSave_Click);
            // 
            // btBModify
            // 
            this.btBModify.Location = new System.Drawing.Point(160, 375);
            this.btBModify.Name = "btBModify";
            this.btBModify.Size = new System.Drawing.Size(80, 29);
            this.btBModify.TabIndex = 26;
            this.btBModify.Text = "Modify";
            this.btBModify.UseVisualStyleBackColor = true;
            this.btBModify.Click += new System.EventHandler(this.btBModify_Click);
            // 
            // gbMESInfomation
            // 
            this.gbMESInfomation.Controls.Add(this.tbStation);
            this.gbMESInfomation.Controls.Add(this.tbSection);
            this.gbMESInfomation.Controls.Add(this.lbSection);
            this.gbMESInfomation.Controls.Add(this.tbLine);
            this.gbMESInfomation.Controls.Add(this.lbLine);
            this.gbMESInfomation.Controls.Add(this.lbStation);
            this.gbMESInfomation.Font = new System.Drawing.Font("Verdana", 10.5F);
            this.gbMESInfomation.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbMESInfomation.Location = new System.Drawing.Point(364, 20);
            this.gbMESInfomation.Name = "gbMESInfomation";
            this.gbMESInfomation.Size = new System.Drawing.Size(255, 163);
            this.gbMESInfomation.TabIndex = 25;
            this.gbMESInfomation.TabStop = false;
            this.gbMESInfomation.Text = "Information";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLine.ForeColor = System.Drawing.Color.Black;
            this.lbLine.Location = new System.Drawing.Point(24, 35);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(45, 19);
            this.lbLine.TabIndex = 19;
            this.lbLine.Text = "Line:";
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStation.ForeColor = System.Drawing.Color.Black;
            this.lbStation.Location = new System.Drawing.Point(12, 102);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(64, 19);
            this.lbStation.TabIndex = 25;
            this.lbStation.Text = "Station:";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 472);
            this.Controls.Add(this.panel2);
            this.Name = "FormConfig";
            this.Text = "Client Configuration";
            this.Load += new System.EventHandler(this.fmConfig_Load);
            this.tpDBSetting.ResumeLayout(false);
            this.tpDBSetting.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tcMESClientConfig.ResumeLayout(false);
            this.tpBasic.ResumeLayout(false);
            this.gbAdvance.ResumeLayout(false);
            this.gbAdvance.PerformLayout();
            this.gbClientEnv.ResumeLayout(false);
            this.gbClientEnv.PerformLayout();
            this.gbMESInfomation.ResumeLayout(false);
            this.gbMESInfomation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbStation;
        private System.Windows.Forms.TextBox tbSection;
        private System.Windows.Forms.Label lbSection;
        private System.Windows.Forms.TabPage tpDBSetting;
        private System.Windows.Forms.Label lbDBList;
        private System.Windows.Forms.ListBox lbxDB;
        private System.Windows.Forms.Button btDDele;
        private System.Windows.Forms.Button btDAdd;
        private System.Windows.Forms.Button btDCancel;
        private System.Windows.Forms.Button btDSave;
        private System.Windows.Forms.Button btDMod;
        private System.Windows.Forms.TextBox tbPWD;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbSID;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcMESClientConfig;
        private System.Windows.Forms.TabPage tpBasic;
        private System.Windows.Forms.GroupBox gbAdvance;
        private System.Windows.Forms.ComboBox cbLoadInMemory;
        private System.Windows.Forms.ComboBox cbCheckDomain;
        private System.Windows.Forms.Label lbLoadInMemory;
        private System.Windows.Forms.Label lbCheckDomain;
        private System.Windows.Forms.GroupBox gbClientEnv;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.TextBox tbLoginType;
        private System.Windows.Forms.TextBox tbConType;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ComboBox cmbConType;
        private System.Windows.Forms.ComboBox cmbLoginType;
        private System.Windows.Forms.Label lbDllPath;
        private System.Windows.Forms.Label lbConnection;
        private System.Windows.Forms.Label lbLoginType;
        private System.Windows.Forms.Button btBCancel;
        private System.Windows.Forms.Button btBSave;
        private System.Windows.Forms.Button btBModify;
        private System.Windows.Forms.GroupBox gbMESInfomation;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbStation;
    }
}

