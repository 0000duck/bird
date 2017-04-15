//namespace flyBird.UI_1
//{
//    partial class chatApp
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;
//
//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//
//        #region Windows Form Designer generated code
//
//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.ipText = new System.Windows.Forms.TextBox();
//            this.connectBtn = new System.Windows.Forms.Button();
//            this.fileSendBtn = new System.Windows.Forms.Button();
//            this.FileListView = new System.Windows.Forms.ListView();
//            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.messageText = new System.Windows.Forms.TextBox();
//            this.textSendBtn = new System.Windows.Forms.Button();
//            this.overallProgressBar = new System.Windows.Forms.ProgressBar();
//            this.chatViewTextBox = new System.Windows.Forms.RichTextBox();
//            this.serverLabel = new System.Windows.Forms.Label();
//            this.clientLabel = new System.Windows.Forms.Label();
//            this.clientPortText = new System.Windows.Forms.TextBox();
//            this.serverPortText = new System.Windows.Forms.TextBox();
//            this.startServerBtn = new System.Windows.Forms.Button();
//            this.chatViewTextBoxT = new System.Windows.Forms.TextBox();
//            this.SuspendLayout();
//            // 
//            // ipText
//            // 
//            this.ipText.Location = new System.Drawing.Point(33, 78);
//            this.ipText.Name = "ipText";
//            this.ipText.Size = new System.Drawing.Size(100, 20);
//            this.ipText.TabIndex = 0;
//            this.ipText.Text = "127.0.0.1";
//            // 
//            // connectBtn
//            // 
//            this.connectBtn.Location = new System.Drawing.Point(218, 75);
//            this.connectBtn.Name = "connectBtn";
//            this.connectBtn.Size = new System.Drawing.Size(75, 23);
//            this.connectBtn.TabIndex = 1;
//            this.connectBtn.Text = "connect";
//            this.connectBtn.UseVisualStyleBackColor = true;
//            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
//            // 
//            // fileSendBtn
//            // 
//            this.fileSendBtn.Location = new System.Drawing.Point(12, 319);
//            this.fileSendBtn.Name = "fileSendBtn";
//            this.fileSendBtn.Size = new System.Drawing.Size(75, 38);
//            this.fileSendBtn.TabIndex = 2;
//            this.fileSendBtn.Text = "sendFile";
//            this.fileSendBtn.UseVisualStyleBackColor = true;
//            this.fileSendBtn.Click += new System.EventHandler(this.fileSendBtn_Click);
//            // 
//            // FileListView
//            // 
//            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//            this.columnHeader1,
//            this.columnHeader2,
//            this.columnHeader3,
//            this.columnHeader4});
//            this.FileListView.Location = new System.Drawing.Point(415, 234);
//            this.FileListView.Name = "FileListView";
//            this.FileListView.Size = new System.Drawing.Size(306, 97);
//            this.FileListView.TabIndex = 3;
//            this.FileListView.UseCompatibleStateImageBehavior = false;
//            this.FileListView.View = System.Windows.Forms.View.Details;
//            // 
//            // columnHeader1
//            // 
//            this.columnHeader1.Text = "ID";
//            // 
//            // columnHeader2
//            // 
//            this.columnHeader2.Text = "Name";
//            this.columnHeader2.Width = 146;
//            // 
//            // columnHeader3
//            // 
//            this.columnHeader3.Text = "Type";
//            this.columnHeader3.Width = 42;
//            // 
//            // columnHeader4
//            // 
//            this.columnHeader4.Text = "Progress";
//            this.columnHeader4.Width = 53;
//            // 
//            // messageText
//            // 
//            this.messageText.Location = new System.Drawing.Point(12, 217);
//            this.messageText.Name = "messageText";
//            this.messageText.Size = new System.Drawing.Size(338, 20);
//            this.messageText.TabIndex = 4;
//            // 
//            // textSendBtn
//            // 
//            this.textSendBtn.Location = new System.Drawing.Point(12, 243);
//            this.textSendBtn.Name = "textSendBtn";
//            this.textSendBtn.Size = new System.Drawing.Size(75, 45);
//            this.textSendBtn.TabIndex = 5;
//            this.textSendBtn.Text = "send text";
//            this.textSendBtn.UseVisualStyleBackColor = true;
//            this.textSendBtn.Click += new System.EventHandler(this.textSendBtn_Click);
//            // 
//            // overallProgressBar
//            // 
//            this.overallProgressBar.Location = new System.Drawing.Point(415, 352);
//            this.overallProgressBar.Name = "overallProgressBar";
//            this.overallProgressBar.Size = new System.Drawing.Size(306, 23);
//            this.overallProgressBar.TabIndex = 6;
//            // 
//            // chatViewTextBox
//            // 
//            this.chatViewTextBox.Location = new System.Drawing.Point(415, 26);
//            this.chatViewTextBox.Name = "chatViewTextBox";
//            this.chatViewTextBox.Size = new System.Drawing.Size(306, 82);
//            this.chatViewTextBox.TabIndex = 7;
//            this.chatViewTextBox.Text = "";
//            // 
//            // serverLabel
//            // 
//            this.serverLabel.AutoSize = true;
//            this.serverLabel.Location = new System.Drawing.Point(33, 9);
//            this.serverLabel.Name = "serverLabel";
//            this.serverLabel.Size = new System.Drawing.Size(117, 13);
//            this.serverLabel.TabIndex = 8;
//            this.serverLabel.Text = "connectedAsServerTo:";
//            // 
//            // clientLabel
//            // 
//            this.clientLabel.AutoSize = true;
//            this.clientLabel.Location = new System.Drawing.Point(33, 29);
//            this.clientLabel.Name = "clientLabel";
//            this.clientLabel.Size = new System.Drawing.Size(112, 13);
//            this.clientLabel.TabIndex = 9;
//            this.clientLabel.Text = "connectedAsClientTo:";
//            // 
//            // clientPortText
//            // 
//            this.clientPortText.Location = new System.Drawing.Point(148, 78);
//            this.clientPortText.Name = "clientPortText";
//            this.clientPortText.Size = new System.Drawing.Size(64, 20);
//            this.clientPortText.TabIndex = 10;
//            this.clientPortText.Text = "3461";
//            // 
//            // serverPortText
//            // 
//            this.serverPortText.Location = new System.Drawing.Point(148, 52);
//            this.serverPortText.Name = "serverPortText";
//            this.serverPortText.Size = new System.Drawing.Size(64, 20);
//            this.serverPortText.TabIndex = 12;
//            this.serverPortText.Text = "3461";
//            // 
//            // startServerBtn
//            // 
//            this.startServerBtn.Location = new System.Drawing.Point(218, 49);
//            this.startServerBtn.Name = "startServerBtn";
//            this.startServerBtn.Size = new System.Drawing.Size(75, 23);
//            this.startServerBtn.TabIndex = 11;
//            this.startServerBtn.Text = "start server";
//            this.startServerBtn.UseVisualStyleBackColor = true;
//            this.startServerBtn.Click += new System.EventHandler(this.startServerBtn_Click);
//            // 
//            // chatViewTextBoxT
//            // 
//            this.chatViewTextBoxT.Location = new System.Drawing.Point(415, 151);
//            this.chatViewTextBoxT.Name = "chatViewTextBoxT";
//            this.chatViewTextBoxT.Size = new System.Drawing.Size(286, 20);
//            this.chatViewTextBoxT.TabIndex = 13;
//            // 
//            // chatApp
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(733, 472);
//            this.Controls.Add(this.chatViewTextBoxT);
//            this.Controls.Add(this.serverPortText);
//            this.Controls.Add(this.startServerBtn);
//            this.Controls.Add(this.clientPortText);
//            this.Controls.Add(this.clientLabel);
//            this.Controls.Add(this.serverLabel);
//            this.Controls.Add(this.chatViewTextBox);
//            this.Controls.Add(this.overallProgressBar);
//            this.Controls.Add(this.textSendBtn);
//            this.Controls.Add(this.messageText);
//            this.Controls.Add(this.FileListView);
//            this.Controls.Add(this.fileSendBtn);
//            this.Controls.Add(this.connectBtn);
//            this.Controls.Add(this.ipText);
//            this.Name = "chatApp";
//            this.Text = "chatApp";
//            this.ResumeLayout(false);
//            this.PerformLayout();
//
//        }
//
//        #endregion
//
//        private System.Windows.Forms.TextBox ipText;
//        private System.Windows.Forms.Button connectBtn;
//        private System.Windows.Forms.Button fileSendBtn;
//        private System.Windows.Forms.ListView FileListView;
//        private System.Windows.Forms.ColumnHeader columnHeader1;
//        private System.Windows.Forms.ColumnHeader columnHeader2;
//        private System.Windows.Forms.ColumnHeader columnHeader3;
//        private System.Windows.Forms.ColumnHeader columnHeader4;
//        private System.Windows.Forms.TextBox messageText;
//        private System.Windows.Forms.Button textSendBtn;
//        private System.Windows.Forms.ProgressBar overallProgressBar;
//        private System.Windows.Forms.RichTextBox chatViewTextBox;
//        private System.Windows.Forms.Label serverLabel;
//        private System.Windows.Forms.Label clientLabel;
//        private System.Windows.Forms.TextBox clientPortText;
//        private System.Windows.Forms.TextBox serverPortText;
//        private System.Windows.Forms.Button startServerBtn;
//        private System.Windows.Forms.TextBox chatViewTextBoxT;
//    }
//}