namespace SendMail
{
    partial class Frm
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
            this.labSender = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labSubject = new System.Windows.Forms.Label();
            this.labBody = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSuject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.labTBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labSender
            // 
            this.labSender.AutoSize = true;
            this.labSender.Location = new System.Drawing.Point(63, 57);
            this.labSender.Name = "labSender";
            this.labSender.Size = new System.Drawing.Size(41, 13);
            this.labSender.TabIndex = 0;
            this.labSender.Text = "Sender";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(63, 103);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 13);
            this.labPassword.TabIndex = 1;
            this.labPassword.Text = "Password";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Location = new System.Drawing.Point(63, 148);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(20, 13);
            this.labTo.TabIndex = 2;
            this.labTo.Text = "To";
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(63, 191);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(43, 13);
            this.labSubject.TabIndex = 3;
            this.labSubject.Text = "Subject";
            // 
            // labBody
            // 
            this.labBody.AutoSize = true;
            this.labBody.Location = new System.Drawing.Point(63, 233);
            this.labBody.Name = "labBody";
            this.labBody.Size = new System.Drawing.Size(31, 13);
            this.labBody.TabIndex = 4;
            this.labBody.Text = "Body";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(542, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(136, 54);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(367, 20);
            this.txtSender.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(367, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(136, 145);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(367, 20);
            this.txtTo.TabIndex = 8;
            // 
            // txtSuject
            // 
            this.txtSuject.Location = new System.Drawing.Point(136, 188);
            this.txtSuject.Name = "txtSuject";
            this.txtSuject.Size = new System.Drawing.Size(481, 20);
            this.txtSuject.TabIndex = 9;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(136, 230);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(481, 155);
            this.txtBody.TabIndex = 10;
            // 
            // labTBao
            // 
            this.labTBao.AutoSize = true;
            this.labTBao.Location = new System.Drawing.Point(274, 420);
            this.labTBao.Name = "labTBao";
            this.labTBao.Size = new System.Drawing.Size(0, 13);
            this.labTBao.TabIndex = 11;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 459);
            this.Controls.Add(this.labTBao);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSuject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labBody);
            this.Controls.Add(this.labSubject);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labSender);
            this.Name = "Frm";
            this.Text = "Send Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSender;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.Label labBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSuject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label labTBao;
    }
}

