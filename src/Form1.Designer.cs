namespace NetCheckerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtHostToPing = new TextBox();
            btnStart = new Button();
            btnStop = new Button();
            txtOutput = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtTimer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkSuccessLog = new CheckBox();
            label3 = new Label();
            lblOutageCount = new Label();
            btnReset = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtHostToPing
            // 
            txtHostToPing.Location = new Point(35, 30);
            txtHostToPing.Name = "txtHostToPing";
            txtHostToPing.Size = new Size(338, 27);
            txtHostToPing.TabIndex = 10;
            txtHostToPing.Text = "8.8.8.8,www.bing.com";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(447, 33);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 40;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(547, 31);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 50;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtOutput
            // 
            txtOutput.BorderStyle = BorderStyle.FixedSingle;
            txtOutput.Location = new Point(39, 95);
            txtOutput.MinimumSize = new Size(700, 300);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(700, 300);
            txtOutput.TabIndex = 55;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // txtTimer
            // 
            txtTimer.Location = new Point(379, 32);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(55, 27);
            txtTimer.TabIndex = 20;
            txtTimer.Text = "5";
            txtTimer.TextChanged += txtTimer_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 5;
            label1.Text = "Hosts (comma seperated)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 6;
            label2.Text = "Interval (Secs)";
            // 
            // chkSuccessLog
            // 
            chkSuccessLog.AutoSize = true;
            chkSuccessLog.Location = new Point(39, 65);
            chkSuccessLog.Name = "chkSuccessLog";
            chkSuccessLog.Size = new Size(281, 24);
            chkSuccessLog.TabIndex = 30;
            chkSuccessLog.Text = "Record SUCCESSfull connects as well?";
            chkSuccessLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 66);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 8;
            label3.Text = "No of outages";
            // 
            // lblOutageCount
            // 
            lblOutageCount.AutoSize = true;
            lblOutageCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutageCount.Location = new Point(705, 66);
            lblOutageCount.Name = "lblOutageCount";
            lblOutageCount.Size = new Size(18, 20);
            lblOutageCount.TabIndex = 9;
            lblOutageCount.Text = "0";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(645, 33);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 60;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(255, 421);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(533, 20);
            linkLabel1.TabIndex = 61;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "This is open source project available at https://github.com/shukla18/netchecker";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(chkSuccessLog);
            Controls.Add(btnReset);
            Controls.Add(lblOutageCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTimer);
            Controls.Add(txtOutput);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtHostToPing);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Open Source Internet Connectivity Checker v0.1 (Auth Shantanu)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHostToPing;
        private Button btnStart;
        private Button btnStop;
        private TextBox txtOutput;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTimer;
        private Label label1;
        private Label label2;
        private CheckBox chkSuccessLog;
        private Label label3;
        private Label lblOutageCount;
        private Button btnReset;
        private LinkLabel linkLabel1;
    }
}