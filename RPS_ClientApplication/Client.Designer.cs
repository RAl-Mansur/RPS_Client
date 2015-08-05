namespace RPS_ClientApplication
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.label1 = new System.Windows.Forms.Label();
            this.IP_TB = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.playersLbl = new System.Windows.Forms.Label();
            this.userLB = new System.Windows.Forms.ListBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.strtBtn = new System.Windows.Forms.Button();
            this.opHealthLbl = new System.Windows.Forms.Label();
            this.oppHealth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plyrHealth = new System.Windows.Forms.TextBox();
            this.movBtn = new System.Windows.Forms.Button();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.LogLbl = new System.Windows.Forms.Label();
            this.logTB = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.chatLog = new System.Windows.Forms.TextBox();
            this.chatLogLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorBtn = new System.Windows.Forms.Button();
            this.rockBtn = new System.Windows.Forms.Button();
            this.gameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP Address:";
            // 
            // IP_TB
            // 
            this.IP_TB.Location = new System.Drawing.Point(114, 9);
            this.IP_TB.Name = "IP_TB";
            this.IP_TB.Size = new System.Drawing.Size(100, 20);
            this.IP_TB.TabIndex = 1;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(12, 38);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(69, 13);
            this.portLbl.TabIndex = 2;
            this.portLbl.Text = "Port Number:";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(114, 38);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(100, 20);
            this.portTB.TabIndex = 3;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(216, 12);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(58, 13);
            this.userLbl.TabIndex = 4;
            this.userLbl.Text = "Username:";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(271, 9);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(100, 20);
            this.userTB.TabIndex = 5;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 71);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(129, 23);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.Text = "Connect to Server";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // playersLbl
            // 
            this.playersLbl.AutoSize = true;
            this.playersLbl.Location = new System.Drawing.Point(263, 65);
            this.playersLbl.Name = "playersLbl";
            this.playersLbl.Size = new System.Drawing.Size(90, 13);
            this.playersLbl.TabIndex = 7;
            this.playersLbl.Text = "Available Players:";
            // 
            // userLB
            // 
            this.userLB.FormattingEnabled = true;
            this.userLB.Location = new System.Drawing.Point(228, 81);
            this.userLB.Name = "userLB";
            this.userLB.Size = new System.Drawing.Size(143, 43);
            this.userLB.TabIndex = 8;
            this.userLB.SelectedIndexChanged += new System.EventHandler(this.userLB_SelectedIndexChanged);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(12, 101);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(129, 23);
            this.disconnectBtn.TabIndex = 9;
            this.disconnectBtn.Text = "Disconnect from Server";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // strtBtn
            // 
            this.strtBtn.Location = new System.Drawing.Point(147, 71);
            this.strtBtn.Name = "strtBtn";
            this.strtBtn.Size = new System.Drawing.Size(75, 54);
            this.strtBtn.TabIndex = 10;
            this.strtBtn.Text = "Start Match";
            this.strtBtn.UseVisualStyleBackColor = true;
            this.strtBtn.Click += new System.EventHandler(this.strtBtn_Click);
            // 
            // opHealthLbl
            // 
            this.opHealthLbl.AutoSize = true;
            this.opHealthLbl.Location = new System.Drawing.Point(175, 24);
            this.opHealthLbl.Name = "opHealthLbl";
            this.opHealthLbl.Size = new System.Drawing.Size(91, 13);
            this.opHealthLbl.TabIndex = 11;
            this.opHealthLbl.Text = "Opponent Health:";
            // 
            // oppHealth
            // 
            this.oppHealth.Location = new System.Drawing.Point(272, 21);
            this.oppHealth.Name = "oppHealth";
            this.oppHealth.ReadOnly = true;
            this.oppHealth.Size = new System.Drawing.Size(77, 20);
            this.oppHealth.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Your Health:";
            // 
            // plyrHealth
            // 
            this.plyrHealth.Location = new System.Drawing.Point(272, 180);
            this.plyrHealth.Name = "plyrHealth";
            this.plyrHealth.ReadOnly = true;
            this.plyrHealth.Size = new System.Drawing.Size(77, 20);
            this.plyrHealth.TabIndex = 15;
            // 
            // movBtn
            // 
            this.movBtn.Location = new System.Drawing.Point(24, 286);
            this.movBtn.Name = "movBtn";
            this.movBtn.Size = new System.Drawing.Size(75, 45);
            this.movBtn.TabIndex = 19;
            this.movBtn.Text = "Send Move";
            this.movBtn.UseVisualStyleBackColor = true;
            this.movBtn.Click += new System.EventHandler(this.movBtn_Click);
            // 
            // gameBox
            // 
            this.gameBox.Controls.Add(this.label5);
            this.gameBox.Controls.Add(this.label4);
            this.gameBox.Controls.Add(this.label3);
            this.gameBox.Controls.Add(this.paperBtn);
            this.gameBox.Controls.Add(this.scissorBtn);
            this.gameBox.Controls.Add(this.plyrHealth);
            this.gameBox.Controls.Add(this.oppHealth);
            this.gameBox.Controls.Add(this.opHealthLbl);
            this.gameBox.Controls.Add(this.label2);
            this.gameBox.Controls.Add(this.rockBtn);
            this.gameBox.Location = new System.Drawing.Point(12, 131);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(359, 213);
            this.gameBox.TabIndex = 20;
            this.gameBox.TabStop = false;
            this.gameBox.Text = "Game";
            // 
            // LogLbl
            // 
            this.LogLbl.AutoSize = true;
            this.LogLbl.Location = new System.Drawing.Point(584, 12);
            this.LogLbl.Name = "LogLbl";
            this.LogLbl.Size = new System.Drawing.Size(65, 13);
            this.LogLbl.TabIndex = 21;
            this.LogLbl.Text = "System Log:";
            // 
            // logTB
            // 
            this.logTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logTB.Location = new System.Drawing.Point(587, 27);
            this.logTB.Multiline = true;
            this.logTB.Name = "logTB";
            this.logTB.ReadOnly = true;
            this.logTB.Size = new System.Drawing.Size(204, 289);
            this.logTB.TabIndex = 22;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(535, 319);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(46, 23);
            this.sendBtn.TabIndex = 23;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(383, 321);
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(146, 20);
            this.messageTB.TabIndex = 24;
            this.messageTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTB_KeyDown);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(686, 319);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(103, 23);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Clear System Log";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(228, 36);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(143, 22);
            this.confirmBtn.TabIndex = 26;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // chatLog
            // 
            this.chatLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chatLog.Location = new System.Drawing.Point(383, 27);
            this.chatLog.Multiline = true;
            this.chatLog.Name = "chatLog";
            this.chatLog.ReadOnly = true;
            this.chatLog.Size = new System.Drawing.Size(198, 289);
            this.chatLog.TabIndex = 27;
            // 
            // chatLogLabel
            // 
            this.chatLogLabel.AutoSize = true;
            this.chatLogLabel.Location = new System.Drawing.Point(380, 12);
            this.chatLogLabel.Name = "chatLogLabel";
            this.chatLogLabel.Size = new System.Drawing.Size(53, 13);
            this.chatLogLabel.TabIndex = 28;
            this.chatLogLabel.Text = "Chat Log:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 29;
            this.button1.Text = "Clear Chat Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Damage = 20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Damage = 10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Damage = 15";
            // 
            // paperBtn
            // 
            this.paperBtn.Image = global::RPS_ClientApplication.Properties.Resources.Paper_Icon;
            this.paperBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paperBtn.Location = new System.Drawing.Point(272, 80);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(61, 55);
            this.paperBtn.TabIndex = 17;
            this.paperBtn.Text = "Paper";
            this.paperBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorBtn
            // 
            this.scissorBtn.Image = global::RPS_ClientApplication.Properties.Resources.Scissors_Icon;
            this.scissorBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.scissorBtn.Location = new System.Drawing.Point(153, 80);
            this.scissorBtn.Name = "scissorBtn";
            this.scissorBtn.Size = new System.Drawing.Size(65, 55);
            this.scissorBtn.TabIndex = 18;
            this.scissorBtn.Text = "Scissors";
            this.scissorBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scissorBtn.UseVisualStyleBackColor = true;
            this.scissorBtn.Click += new System.EventHandler(this.scissorBtn_Click);
            // 
            // rockBtn
            // 
            this.rockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rockBtn.Image = global::RPS_ClientApplication.Properties.Resources.Rock_Icon;
            this.rockBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rockBtn.Location = new System.Drawing.Point(21, 80);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(66, 55);
            this.rockBtn.TabIndex = 16;
            this.rockBtn.Text = "Rock";
            this.rockBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chatLogLabel);
            this.Controls.Add(this.chatLog);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.LogLbl);
            this.Controls.Add(this.movBtn);
            this.Controls.Add(this.strtBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.userLB);
            this.Controls.Add(this.playersLbl);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.IP_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Rock, Paper, Scissors | Client";
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_TB;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label playersLbl;
        private System.Windows.Forms.ListBox userLB;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button strtBtn;
        private System.Windows.Forms.Label opHealthLbl;
        private System.Windows.Forms.TextBox oppHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plyrHealth;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorBtn;
        private System.Windows.Forms.Button movBtn;
        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.Label LogLbl;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox chatLog;
        private System.Windows.Forms.Label chatLogLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

