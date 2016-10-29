namespace yugecin.sampbrowser
{
	partial class frmMain
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
			this.lstServers = new System.Windows.Forms.ListView();
			this.colPW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPlayers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pnlControls
			// 
			this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControls.Location = new System.Drawing.Point(0, 0);
			this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(797, 24);
			this.pnlControls.TabIndex = 0;
			// 
			// lstServers
			// 
			this.lstServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPW,
            this.colHostName,
            this.colPlayers,
            this.colPing,
            this.colMode,
            this.colLanguage});
			this.lstServers.FullRowSelect = true;
			this.lstServers.GridLines = true;
			this.lstServers.HideSelection = false;
			this.lstServers.Location = new System.Drawing.Point(0, 24);
			this.lstServers.Margin = new System.Windows.Forms.Padding(0);
			this.lstServers.MultiSelect = false;
			this.lstServers.Name = "lstServers";
			this.lstServers.Size = new System.Drawing.Size(603, 518);
			this.lstServers.TabIndex = 1;
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
			// 
			// colMode
			// 
			this.colMode.Text = "Mode";
			this.colMode.Width = 100;
			// 
			// colLanguage
			// 
			this.colLanguage.Text = "Language";
			this.colLanguage.Width = 90;
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblStatus.Location = new System.Drawing.Point(0, 543);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(797, 25);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 568);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lstServers);
			this.Controls.Add(this.pnlControls);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListView lstServers;
		private System.Windows.Forms.ColumnHeader colPW;
		private System.Windows.Forms.ColumnHeader colHostName;
		private System.Windows.Forms.ColumnHeader colPlayers;
		private System.Windows.Forms.ColumnHeader colPing;
		private System.Windows.Forms.ColumnHeader colMode;
		private System.Windows.Forms.ColumnHeader colLanguage;
	}
}