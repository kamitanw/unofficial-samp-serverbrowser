namespace yugecin.sampbrowser
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlControls = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnQuickconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tabPane = new yugecin.sampbrowser.TabPane();
			this.pnlInfo = new yugecin.sampbrowser.InfoPanel();
			this.pingPanel1 = new yugecin.sampbrowser.PingPanel();
			this.lblInfoLanguage = new System.Windows.Forms.Label();
			this.lblInfoMode = new System.Windows.Forms.Label();
			this.lblInfoPlayers = new System.Windows.Forms.Label();
			this.lblInfoPing = new System.Windows.Forms.Label();
			this.lblInfoAddress = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxBorder2 = new yugecin.sampbrowser.TextBoxBorder();
			this.txtFilterMode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxBorder1 = new yugecin.sampbrowser.TextBoxBorder();
			this.txtFilterHostname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkFilterNotEmpty = new System.Windows.Forms.CheckBox();
			this.chkFilterNotFull = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.chlFilterNoPW = new System.Windows.Forms.CheckBox();
			this.customListView2 = new yugecin.sampbrowser.CustomListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.customSplitter2 = new yugecin.sampbrowser.CustomSplitter();
			this.customListView1 = new yugecin.sampbrowser.CustomListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.customSplitter1 = new yugecin.sampbrowser.CustomSplitter();
			this.lstServers = new yugecin.sampbrowser.CustomListView();
			this.colPW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPlayers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pnlControls.SuspendLayout();
			this.pnlContent.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.textBoxBorder2.SuspendLayout();
			this.textBoxBorder1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlControls
			// 
			this.pnlControls.Controls.Add(this.label5);
			this.pnlControls.Controls.Add(this.txtName);
			this.pnlControls.Controls.Add(this.btnQuickconnect);
			this.pnlControls.Controls.Add(this.btnConnect);
			this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControls.Location = new System.Drawing.Point(0, 0);
			this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(832, 25);
			this.pnlControls.TabIndex = 0;
			this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControls_Paint);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(161, 2);
			this.label5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(238, 2);
			this.txtName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(150, 20);
			this.txtName.TabIndex = 11;
			// 
			// btnQuickconnect
			// 
			this.btnQuickconnect.Location = new System.Drawing.Point(66, 1);
			this.btnQuickconnect.Margin = new System.Windows.Forms.Padding(0);
			this.btnQuickconnect.Name = "btnQuickconnect";
			this.btnQuickconnect.Size = new System.Drawing.Size(95, 23);
			this.btnQuickconnect.TabIndex = 2;
			this.btnQuickconnect.Text = "Quick connect";
			this.btnQuickconnect.UseVisualStyleBackColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(0, 1);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(66, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblStatus.Location = new System.Drawing.Point(0, 553);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(832, 20);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlContent
			// 
			this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContent.Controls.Add(this.customListView2);
			this.pnlContent.Controls.Add(this.customSplitter2);
			this.pnlContent.Controls.Add(this.customListView1);
			this.pnlContent.Controls.Add(this.linkLabel1);
			this.pnlContent.Controls.Add(this.customSplitter1);
			this.pnlContent.Controls.Add(this.lstServers);
			this.pnlContent.Location = new System.Drawing.Point(0, 25);
			this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(832, 403);
			this.pnlContent.TabIndex = 4;
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
			this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(613, 389);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(219, 14);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPane
			// 
			this.tabPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPane.Location = new System.Drawing.Point(0, 530);
			this.tabPane.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.tabPane.Name = "tabPane";
			this.tabPane.Size = new System.Drawing.Size(832, 20);
			this.tabPane.TabIndex = 6;
			// 
			// pnlInfo
			// 
			this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlInfo.Controls.Add(this.pingPanel1);
			this.pnlInfo.Controls.Add(this.lblInfoLanguage);
			this.pnlInfo.Controls.Add(this.lblInfoMode);
			this.pnlInfo.Controls.Add(this.lblInfoPlayers);
			this.pnlInfo.Controls.Add(this.lblInfoPing);
			this.pnlInfo.Controls.Add(this.lblInfoAddress);
			this.pnlInfo.Controls.Add(this.label10);
			this.pnlInfo.Controls.Add(this.label9);
			this.pnlInfo.Controls.Add(this.label8);
			this.pnlInfo.Controls.Add(this.label7);
			this.pnlInfo.Controls.Add(this.label6);
			this.pnlInfo.Controls.Add(this.textBoxBorder2);
			this.pnlInfo.Controls.Add(this.label4);
			this.pnlInfo.Controls.Add(this.label1);
			this.pnlInfo.Controls.Add(this.textBoxBorder1);
			this.pnlInfo.Controls.Add(this.label2);
			this.pnlInfo.Controls.Add(this.chkFilterNotEmpty);
			this.pnlInfo.Controls.Add(this.chkFilterNotFull);
			this.pnlInfo.Controls.Add(this.label3);
			this.pnlInfo.Controls.Add(this.chlFilterNoPW);
			this.pnlInfo.Location = new System.Drawing.Point(0, 430);
			this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(832, 100);
			this.pnlInfo.TabIndex = 5;
			// 
			// pingPanel1
			// 
			this.pingPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pingPanel1.Font = new System.Drawing.Font("Arial", 8.25F);
			this.pingPanel1.Location = new System.Drawing.Point(500, 23);
			this.pingPanel1.Margin = new System.Windows.Forms.Padding(3, 23, 23, 3);
			this.pingPanel1.Name = "pingPanel1";
			this.pingPanel1.Size = new System.Drawing.Size(309, 76);
			this.pingPanel1.TabIndex = 26;
			// 
			// lblInfoLanguage
			// 
			this.lblInfoLanguage.AutoSize = true;
			this.lblInfoLanguage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoLanguage.Location = new System.Drawing.Point(316, 82);
			this.lblInfoLanguage.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.lblInfoLanguage.Name = "lblInfoLanguage";
			this.lblInfoLanguage.Size = new System.Drawing.Size(25, 14);
			this.lblInfoLanguage.TabIndex = 25;
			this.lblInfoLanguage.Text = "- - -";
			this.lblInfoLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInfoMode
			// 
			this.lblInfoMode.AutoSize = true;
			this.lblInfoMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoMode.Location = new System.Drawing.Point(316, 65);
			this.lblInfoMode.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.lblInfoMode.Name = "lblInfoMode";
			this.lblInfoMode.Size = new System.Drawing.Size(25, 14);
			this.lblInfoMode.TabIndex = 24;
			this.lblInfoMode.Text = "- - -";
			this.lblInfoMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInfoPlayers
			// 
			this.lblInfoPlayers.AutoSize = true;
			this.lblInfoPlayers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoPlayers.Location = new System.Drawing.Point(316, 31);
			this.lblInfoPlayers.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.lblInfoPlayers.Name = "lblInfoPlayers";
			this.lblInfoPlayers.Size = new System.Drawing.Size(25, 14);
			this.lblInfoPlayers.TabIndex = 24;
			this.lblInfoPlayers.Text = "- - -";
			this.lblInfoPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInfoPing
			// 
			this.lblInfoPing.AutoSize = true;
			this.lblInfoPing.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoPing.Location = new System.Drawing.Point(316, 48);
			this.lblInfoPing.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.lblInfoPing.Name = "lblInfoPing";
			this.lblInfoPing.Size = new System.Drawing.Size(25, 14);
			this.lblInfoPing.TabIndex = 23;
			this.lblInfoPing.Text = "- - -";
			this.lblInfoPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInfoAddress
			// 
			this.lblInfoAddress.AutoSize = true;
			this.lblInfoAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoAddress.Location = new System.Drawing.Point(316, 15);
			this.lblInfoAddress.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.lblInfoAddress.Name = "lblInfoAddress";
			this.lblInfoAddress.Size = new System.Drawing.Size(25, 14);
			this.lblInfoAddress.TabIndex = 21;
			this.lblInfoAddress.Text = "- - -";
			this.lblInfoAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(247, 82);
			this.label10.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 14);
			this.label10.TabIndex = 20;
			this.label10.Text = "Language:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(247, 65);
			this.label9.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 14);
			this.label9.TabIndex = 19;
			this.label9.Text = "Mode:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(247, 48);
			this.label8.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 14);
			this.label8.TabIndex = 18;
			this.label8.Text = "Ping:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(247, 31);
			this.label7.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 14);
			this.label7.TabIndex = 17;
			this.label7.Text = "Players:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(252, -2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 14);
			this.label6.TabIndex = 16;
			this.label6.Text = "Server Info:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxBorder2
			// 
			this.textBoxBorder2.Controls.Add(this.txtFilterMode);
			this.textBoxBorder2.Location = new System.Drawing.Point(13, 71);
			this.textBoxBorder2.Name = "textBoxBorder2";
			this.textBoxBorder2.Padding = new System.Windows.Forms.Padding(1);
			this.textBoxBorder2.Size = new System.Drawing.Size(138, 15);
			this.textBoxBorder2.TabIndex = 14;
			// 
			// txtFilterMode
			// 
			this.txtFilterMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFilterMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFilterMode.Location = new System.Drawing.Point(1, 1);
			this.txtFilterMode.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.txtFilterMode.Name = "txtFilterMode";
			this.txtFilterMode.Size = new System.Drawing.Size(136, 13);
			this.txtFilterMode.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 56);
			this.label4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 14);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mode";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, -2);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 14);
			this.label1.TabIndex = 14;
			this.label1.Text = "Filter";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxBorder1
			// 
			this.textBoxBorder1.Controls.Add(this.txtFilterHostname);
			this.textBoxBorder1.Location = new System.Drawing.Point(12, 31);
			this.textBoxBorder1.Name = "textBoxBorder1";
			this.textBoxBorder1.Padding = new System.Windows.Forms.Padding(1);
			this.textBoxBorder1.Size = new System.Drawing.Size(138, 15);
			this.textBoxBorder1.TabIndex = 13;
			// 
			// txtFilterHostname
			// 
			this.txtFilterHostname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFilterHostname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFilterHostname.Location = new System.Drawing.Point(1, 1);
			this.txtFilterHostname.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.txtFilterHostname.Name = "txtFilterHostname";
			this.txtFilterHostname.Size = new System.Drawing.Size(136, 13);
			this.txtFilterHostname.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "HostName";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkFilterNotEmpty
			// 
			this.chkFilterNotEmpty.AutoSize = true;
			this.chkFilterNotEmpty.Location = new System.Drawing.Point(164, 52);
			this.chkFilterNotEmpty.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.chkFilterNotEmpty.Name = "chkFilterNotEmpty";
			this.chkFilterNotEmpty.Size = new System.Drawing.Size(74, 18);
			this.chkFilterNotEmpty.TabIndex = 12;
			this.chkFilterNotEmpty.Text = "Not Empty";
			this.chkFilterNotEmpty.UseVisualStyleBackColor = true;
			// 
			// chkFilterNotFull
			// 
			this.chkFilterNotFull.AutoSize = true;
			this.chkFilterNotFull.Location = new System.Drawing.Point(164, 32);
			this.chkFilterNotFull.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.chkFilterNotFull.Name = "chkFilterNotFull";
			this.chkFilterNotFull.Size = new System.Drawing.Size(61, 18);
			this.chkFilterNotFull.TabIndex = 11;
			this.chkFilterNotFull.Text = "Not Full";
			this.chkFilterNotFull.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(247, 14);
			this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Address:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chlFilterNoPW
			// 
			this.chlFilterNoPW.AutoSize = true;
			this.chlFilterNoPW.Location = new System.Drawing.Point(164, 72);
			this.chlFilterNoPW.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.chlFilterNoPW.Name = "chlFilterNoPW";
			this.chlFilterNoPW.Size = new System.Drawing.Size(58, 18);
			this.chlFilterNoPW.TabIndex = 10;
			this.chlFilterNoPW.Text = "No PW";
			this.chlFilterNoPW.UseVisualStyleBackColor = true;
			// 
			// customListView2
			// 
			this.customListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.customListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.customListView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customListView2.FullRowSelect = true;
			this.customListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.customListView2.HideSelection = false;
			this.customListView2.Location = new System.Drawing.Point(613, 0);
			this.customListView2.MultiSelect = false;
			this.customListView2.Name = "customListView2";
			this.customListView2.Size = new System.Drawing.Size(219, 282);
			this.customListView2.TabIndex = 5;
			this.customListView2.UseCompatibleStateImageBehavior = false;
			this.customListView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Player";
			this.columnHeader1.Width = 140;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Score";
			this.columnHeader2.Width = 2000;
			// 
			// customSplitter2
			// 
			this.customSplitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.customSplitter2.Location = new System.Drawing.Point(613, 282);
			this.customSplitter2.Name = "customSplitter2";
			this.customSplitter2.Size = new System.Drawing.Size(219, 10);
			this.customSplitter2.TabIndex = 4;
			this.customSplitter2.TabStop = false;
			// 
			// customListView1
			// 
			this.customListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.customListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.customListView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.customListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.customListView1.Location = new System.Drawing.Point(613, 292);
			this.customListView1.Name = "customListView1";
			this.customListView1.Size = new System.Drawing.Size(219, 97);
			this.customListView1.TabIndex = 3;
			this.customListView1.UseCompatibleStateImageBehavior = false;
			this.customListView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Rule";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Value";
			this.columnHeader4.Width = 1000;
			// 
			// customSplitter1
			// 
			this.customSplitter1.Location = new System.Drawing.Point(603, 0);
			this.customSplitter1.Name = "customSplitter1";
			this.customSplitter1.Size = new System.Drawing.Size(10, 403);
			this.customSplitter1.TabIndex = 1;
			this.customSplitter1.TabStop = false;
			// 
			// lstServers
			// 
			this.lstServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPW,
            this.colHostName,
            this.colPlayers,
            this.colPing,
            this.colMode,
            this.colLanguage});
			this.lstServers.Dock = System.Windows.Forms.DockStyle.Left;
			this.lstServers.FullRowSelect = true;
			this.lstServers.HideSelection = false;
			this.lstServers.Location = new System.Drawing.Point(0, 0);
			this.lstServers.Margin = new System.Windows.Forms.Padding(0);
			this.lstServers.MultiSelect = false;
			this.lstServers.Name = "lstServers";
			this.lstServers.Size = new System.Drawing.Size(603, 403);
			this.lstServers.TabIndex = 0;
			this.lstServers.UseCompatibleStateImageBehavior = false;
			this.lstServers.View = System.Windows.Forms.View.Details;
			// 
			// colPW
			// 
			this.colPW.Text = "PW";
			this.colPW.Width = 30;
			// 
			// colHostName
			// 
			this.colHostName.Text = "HostName";
			this.colHostName.Width = 250;
			// 
			// colPlayers
			// 
			this.colPlayers.Text = "Players";
			// 
			// colPing
			// 
			this.colPing.Text = "Ping";
			this.colPing.Width = 40;
			// 
			// colMode
			// 
			this.colMode.Text = "Mode";
			this.colMode.Width = 120;
			// 
			// colLanguage
			// 
			this.colLanguage.Text = "Language";
			this.colLanguage.Width = 90;
			// 
			// FrmMain
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 573);
			this.Controls.Add(this.tabPane);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.pnlControls);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "FrmMain";
			this.Text = "SA-MP serverbrowser";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.pnlControls.ResumeLayout(false);
			this.pnlControls.PerformLayout();
			this.pnlContent.ResumeLayout(false);
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.textBoxBorder2.ResumeLayout(false);
			this.textBoxBorder2.PerformLayout();
			this.textBoxBorder1.ResumeLayout(false);
			this.textBoxBorder1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnQuickconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilterHostname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.CheckBox chkFilterNotEmpty;
		private System.Windows.Forms.CheckBox chkFilterNotFull;
		private System.Windows.Forms.CheckBox chlFilterNoPW;
		private System.Windows.Forms.Panel pnlContent;
		private CustomListView lstServers;
		private System.Windows.Forms.ColumnHeader colPW;
		private System.Windows.Forms.ColumnHeader colHostName;
		private System.Windows.Forms.ColumnHeader colPlayers;
		private System.Windows.Forms.ColumnHeader colPing;
		private System.Windows.Forms.ColumnHeader colMode;
		private System.Windows.Forms.ColumnHeader colLanguage;
		private CustomSplitter customSplitter1;
		private InfoPanel pnlInfo;
		private TextBoxBorder textBoxBorder1;
		private System.Windows.Forms.Label label1;
		private TextBoxBorder textBoxBorder2;
		private System.Windows.Forms.TextBox txtFilterMode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblInfoLanguage;
		private System.Windows.Forms.Label lblInfoMode;
		private System.Windows.Forms.Label lblInfoPlayers;
		private System.Windows.Forms.Label lblInfoPing;
		private System.Windows.Forms.Label lblInfoAddress;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private CustomListView customListView2;
		private CustomSplitter customSplitter2;
		private CustomListView customListView1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private PingPanel pingPanel1;
		private TabPane tabPane;
	}
}