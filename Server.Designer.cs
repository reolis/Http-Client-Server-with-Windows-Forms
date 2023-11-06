namespace Krasnyanskaya221327Sem3Lab04Var1
{
    partial class Krasnyanskaya221327Lab04Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Krasnyanskaya221327Lab04Server));
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(434, 318);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(172, 53);
            this.buttonSend.TabIndex = 39;
            this.buttonSend.Text = "Подключить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.Location = new System.Drawing.Point(14, 20);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.Size = new System.Drawing.Size(658, 263);
            this.richTextBoxChat.TabIndex = 38;
            this.richTextBoxChat.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(10, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Порт";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(14, 316);
            this.textBoxPort.Multiline = true;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(343, 55);
            this.textBoxPort.TabIndex = 34;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(678, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "F";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(678, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "E";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(678, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "D";
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(682, 493);
            this.textBoxF.Multiline = true;
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(343, 55);
            this.textBoxF.TabIndex = 28;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(682, 409);
            this.textBoxE.Multiline = true;
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(343, 55);
            this.textBoxE.TabIndex = 27;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(682, 328);
            this.textBoxD.Multiline = true;
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(343, 55);
            this.textBoxD.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(678, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(678, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(678, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "A";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(682, 208);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(343, 55);
            this.textBoxC.TabIndex = 22;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(682, 124);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(343, 55);
            this.textBoxB.TabIndex = 21;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(682, 43);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(343, 55);
            this.textBoxA.TabIndex = 20;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Krasnyanskaya221327Lab04Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 564);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.richTextBoxChat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Krasnyanskaya221327Lab04Server";
            this.Text = "Krasnyanskaya221327Lab04Server";
            this.Load += new System.EventHandler(this.Krasnyanskaya221327Lab04Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
