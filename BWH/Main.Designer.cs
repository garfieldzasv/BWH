namespace BandwagonHelper
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpbServerStatus = new System.Windows.Forms.GroupBox();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDataNextReset = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDataCounter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPlanRam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPlanDisk = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPlanMonthlyData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblServicePlan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNodeDataCenter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNodeLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNodeAlias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNodeIp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gpbServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenuItem,
            this.acionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshMenuItem.Text = "Refresh";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // acionsToolStripMenuItem
            // 
            this.acionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.acionsToolStripMenuItem.Name = "acionsToolStripMenuItem";
            this.acionsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.acionsToolStripMenuItem.Text = "Acions";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(39, 17);
            this.status.Text = "Ready";
            // 
            // gpbServerStatus
            // 
            this.gpbServerStatus.BackColor = System.Drawing.Color.Transparent;
            this.gpbServerStatus.Controls.Add(this.lblOperatingSystem);
            this.gpbServerStatus.Controls.Add(this.label14);
            this.gpbServerStatus.Controls.Add(this.lblDataNextReset);
            this.gpbServerStatus.Controls.Add(this.label13);
            this.gpbServerStatus.Controls.Add(this.lblDataCounter);
            this.gpbServerStatus.Controls.Add(this.label11);
            this.gpbServerStatus.Controls.Add(this.lblPlanRam);
            this.gpbServerStatus.Controls.Add(this.label9);
            this.gpbServerStatus.Controls.Add(this.lblPlanDisk);
            this.gpbServerStatus.Controls.Add(this.label8);
            this.gpbServerStatus.Controls.Add(this.lblPlanMonthlyData);
            this.gpbServerStatus.Controls.Add(this.label7);
            this.gpbServerStatus.Controls.Add(this.lblServicePlan);
            this.gpbServerStatus.Controls.Add(this.label6);
            this.gpbServerStatus.Controls.Add(this.lblNodeDataCenter);
            this.gpbServerStatus.Controls.Add(this.label5);
            this.gpbServerStatus.Controls.Add(this.lblNodeLocation);
            this.gpbServerStatus.Controls.Add(this.label4);
            this.gpbServerStatus.Controls.Add(this.lblNodeAlias);
            this.gpbServerStatus.Controls.Add(this.label3);
            this.gpbServerStatus.Controls.Add(this.lblNodeIp);
            this.gpbServerStatus.Controls.Add(this.label2);
            this.gpbServerStatus.Controls.Add(this.lblHostName);
            this.gpbServerStatus.Controls.Add(this.label1);
            this.gpbServerStatus.Location = new System.Drawing.Point(12, 57);
            this.gpbServerStatus.Name = "gpbServerStatus";
            this.gpbServerStatus.Size = new System.Drawing.Size(722, 201);
            this.gpbServerStatus.TabIndex = 4;
            this.gpbServerStatus.TabStop = false;
            this.gpbServerStatus.Text = "Server : [Status]";
            this.gpbServerStatus.UseWaitCursor = true;
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Location = new System.Drawing.Point(440, 32);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(93, 13);
            this.lblOperatingSystem.TabIndex = 23;
            this.lblOperatingSystem.Text = "[OperatingSystem]";
            this.lblOperatingSystem.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Operating System :";
            this.label14.UseWaitCursor = true;
            // 
            // lblDataNextReset
            // 
            this.lblDataNextReset.AutoSize = true;
            this.lblDataNextReset.Location = new System.Drawing.Point(440, 162);
            this.lblDataNextReset.Name = "lblDataNextReset";
            this.lblDataNextReset.Size = new System.Drawing.Size(86, 13);
            this.lblDataNextReset.TabIndex = 21;
            this.lblDataNextReset.Text = "[DataNextReset]";
            this.lblDataNextReset.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(342, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Next Cycle Date :";
            this.label13.UseWaitCursor = true;
            // 
            // lblDataCounter
            // 
            this.lblDataCounter.AutoSize = true;
            this.lblDataCounter.Location = new System.Drawing.Point(108, 162);
            this.lblDataCounter.Name = "lblDataCounter";
            this.lblDataCounter.Size = new System.Drawing.Size(73, 13);
            this.lblDataCounter.TabIndex = 19;
            this.lblDataCounter.Text = "[DataCounter]";
            this.lblDataCounter.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cycle Data Used :";
            this.label11.UseWaitCursor = true;
            // 
            // lblPlanRam
            // 
            this.lblPlanRam.AutoSize = true;
            this.lblPlanRam.Location = new System.Drawing.Point(440, 132);
            this.lblPlanRam.Name = "lblPlanRam";
            this.lblPlanRam.Size = new System.Drawing.Size(56, 13);
            this.lblPlanRam.TabIndex = 17;
            this.lblPlanRam.Text = "[PlanRam]";
            this.lblPlanRam.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Plan Ram Size :";
            this.label9.UseWaitCursor = true;
            // 
            // lblPlanDisk
            // 
            this.lblPlanDisk.AutoSize = true;
            this.lblPlanDisk.Location = new System.Drawing.Point(108, 132);
            this.lblPlanDisk.Name = "lblPlanDisk";
            this.lblPlanDisk.Size = new System.Drawing.Size(55, 13);
            this.lblPlanDisk.TabIndex = 15;
            this.lblPlanDisk.Text = "[PlanDisk]";
            this.lblPlanDisk.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Plan Disk Size :";
            this.label8.UseWaitCursor = true;
            // 
            // lblPlanMonthlyData
            // 
            this.lblPlanMonthlyData.AutoSize = true;
            this.lblPlanMonthlyData.Location = new System.Drawing.Point(440, 112);
            this.lblPlanMonthlyData.Name = "lblPlanMonthlyData";
            this.lblPlanMonthlyData.Size = new System.Drawing.Size(94, 13);
            this.lblPlanMonthlyData.TabIndex = 13;
            this.lblPlanMonthlyData.Text = "[PlanMonthlyData]";
            this.lblPlanMonthlyData.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Plan Monthly Data :";
            this.label7.UseWaitCursor = true;
            // 
            // lblServicePlan
            // 
            this.lblServicePlan.AutoSize = true;
            this.lblServicePlan.Location = new System.Drawing.Point(108, 112);
            this.lblServicePlan.Name = "lblServicePlan";
            this.lblServicePlan.Size = new System.Drawing.Size(70, 13);
            this.lblServicePlan.TabIndex = 11;
            this.lblServicePlan.Text = "[ServicePlan]";
            this.lblServicePlan.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Service Plan :";
            this.label6.UseWaitCursor = true;
            // 
            // lblNodeDataCenter
            // 
            this.lblNodeDataCenter.AutoSize = true;
            this.lblNodeDataCenter.Location = new System.Drawing.Point(440, 82);
            this.lblNodeDataCenter.Name = "lblNodeDataCenter";
            this.lblNodeDataCenter.Size = new System.Drawing.Size(93, 13);
            this.lblNodeDataCenter.TabIndex = 9;
            this.lblNodeDataCenter.Text = "[NodeDataCenter]";
            this.lblNodeDataCenter.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Node DataCenter :";
            this.label5.UseWaitCursor = true;
            // 
            // lblNodeLocation
            // 
            this.lblNodeLocation.AutoSize = true;
            this.lblNodeLocation.Location = new System.Drawing.Point(108, 82);
            this.lblNodeLocation.Name = "lblNodeLocation";
            this.lblNodeLocation.Size = new System.Drawing.Size(80, 13);
            this.lblNodeLocation.TabIndex = 7;
            this.lblNodeLocation.Text = "[NodeLocation]";
            this.lblNodeLocation.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Node Location :";
            this.label4.UseWaitCursor = true;
            // 
            // lblNodeAlias
            // 
            this.lblNodeAlias.AutoSize = true;
            this.lblNodeAlias.Location = new System.Drawing.Point(440, 62);
            this.lblNodeAlias.Name = "lblNodeAlias";
            this.lblNodeAlias.Size = new System.Drawing.Size(61, 13);
            this.lblNodeAlias.TabIndex = 5;
            this.lblNodeAlias.Text = "[NodeAlias]";
            this.lblNodeAlias.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Node Alias :";
            this.label3.UseWaitCursor = true;
            // 
            // lblNodeIp
            // 
            this.lblNodeIp.AutoSize = true;
            this.lblNodeIp.Location = new System.Drawing.Point(108, 62);
            this.lblNodeIp.Name = "lblNodeIp";
            this.lblNodeIp.Size = new System.Drawing.Size(48, 13);
            this.lblNodeIp.TabIndex = 3;
            this.lblNodeIp.Text = "[NodeIp]";
            this.lblNodeIp.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Node IP :";
            this.label2.UseWaitCursor = true;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(108, 32);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(63, 13);
            this.lblHostName.TabIndex = 1;
            this.lblHostName.Text = "[HostName]";
            this.lblHostName.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HostName :";
            this.label1.UseWaitCursor = true;
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(650, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(24, 24);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.UseWaitCursor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(710, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(24, 24);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 6;
            this.btnStop.TabStop = false;
            this.btnStop.UseWaitCursor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.Location = new System.Drawing.Point(680, 27);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(24, 24);
            this.btnRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestart.TabIndex = 7;
            this.btnRestart.TabStop = false;
            this.btnRestart.UseWaitCursor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmMain
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 289);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gpbServerStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpbServerStatus.ResumeLayout(false);
            this.gpbServerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem acionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbServerStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblNodeIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNodeAlias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNodeLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNodeDataCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblServicePlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPlanMonthlyData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPlanDisk;
        private System.Windows.Forms.Label lblPlanRam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDataCounter;
        private System.Windows.Forms.Label lblDataNextReset;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnRestart;
    }
}

