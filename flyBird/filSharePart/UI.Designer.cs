namespace filSharePart
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            this.connectBtn = new System.Windows.Forms.Button();
            this.connectIpText = new System.Windows.Forms.TextBox();
            this.serverStartBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lstTransfers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.serverStopBtn = new System.Windows.Forms.Button();
            this.openDirBtn = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.connectPortText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(41, 29);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(71, 44);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // connectIpText
            // 
            this.connectIpText.Location = new System.Drawing.Point(41, 4);
            this.connectIpText.Name = "connectIpText";
            this.connectIpText.Size = new System.Drawing.Size(82, 20);
            this.connectIpText.TabIndex = 1;
            this.connectIpText.Text = "127.0.0.1";
            // 
            // serverStartBtn
            // 
            this.serverStartBtn.Location = new System.Drawing.Point(0, 30);
            this.serverStartBtn.Name = "serverStartBtn";
            this.serverStartBtn.Size = new System.Drawing.Size(77, 44);
            this.serverStartBtn.TabIndex = 2;
            this.serverStartBtn.Text = "Server start";
            this.serverStartBtn.UseVisualStyleBackColor = true;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(25, 136);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(25, 165);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(405, 23);
            this.progressBar.TabIndex = 6;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(187, 9);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(67, 13);
            this.lblConnected.TabIndex = 7;
            this.lblConnected.Text = "Connection:-";
            // 
            // lstTransfers
            // 
            this.lstTransfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstTransfers.ContextMenuStrip = this.contextMenuStrip1;
            this.lstTransfers.Location = new System.Drawing.Point(25, 207);
            this.lstTransfers.Name = "lstTransfers";
            this.lstTransfers.Size = new System.Drawing.Size(405, 153);
            this.lstTransfers.TabIndex = 8;
            this.lstTransfers.UseCompatibleStateImageBehavior = false;
            this.lstTransfers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Filename";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Progress";
            this.columnHeader4.Width = 139;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.clearCompleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pauseToolStripMenuItem.Text = "Start/Pause";
            // 
            // clearCompleteToolStripMenuItem
            // 
            this.clearCompleteToolStripMenuItem.Name = "clearCompleteToolStripMenuItem";
            this.clearCompleteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearCompleteToolStripMenuItem.Text = "Clear Complete";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(110, 3);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(53, 20);
            this.txtServerPort.TabIndex = 9;
            this.txtServerPort.Text = "4156";
            // 
            // serverStopBtn
            // 
            this.serverStopBtn.Location = new System.Drawing.Point(90, 29);
            this.serverStopBtn.Name = "serverStopBtn";
            this.serverStopBtn.Size = new System.Drawing.Size(73, 44);
            this.serverStopBtn.TabIndex = 10;
            this.serverStopBtn.Text = "Server stop";
            this.serverStopBtn.UseVisualStyleBackColor = true;
            // 
            // openDirBtn
            // 
            this.openDirBtn.Location = new System.Drawing.Point(266, 380);
            this.openDirBtn.Name = "openDirBtn";
            this.openDirBtn.Size = new System.Drawing.Size(164, 23);
            this.openDirBtn.TabIndex = 12;
            this.openDirBtn.Text = "Change Directory";
            this.openDirBtn.UseVisualStyleBackColor = true;
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(29, 385);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(119, 13);
            this.directoryLabel.TabIndex = 13;
            this.directoryLabel.Text = "App Location\\Transfers";
            // 
            // connectPortText
            // 
            this.connectPortText.Location = new System.Drawing.Point(144, 4);
            this.connectPortText.Name = "connectPortText";
            this.connectPortText.Size = new System.Drawing.Size(50, 20);
            this.connectPortText.TabIndex = 14;
            this.connectPortText.Text = "4156";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Server Port:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(25, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.serverStopBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.serverStartBtn);
            this.splitContainer1.Panel1.Controls.Add(this.txtServerPort);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel2.Controls.Add(this.connectBtn);
            this.splitContainer1.Panel2.Controls.Add(this.connectPortText);
            this.splitContainer1.Panel2.Controls.Add(this.connectIpText);
            this.splitContainer1.Size = new System.Drawing.Size(405, 78);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 16;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 415);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.openDirBtn);
            this.Controls.Add(this.lstTransfers);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UI";
            this.Text = "UI";
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox connectIpText;
        private System.Windows.Forms.Button serverStartBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.ListView lstTransfers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button serverStopBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCompleteToolStripMenuItem;
        private System.Windows.Forms.Button openDirBtn;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox connectPortText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

