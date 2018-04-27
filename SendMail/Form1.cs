using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential(txtSender.Text, txtPassword.Text);
            MailMessage message = new MailMessage(txtSender.Text, txtTo.Text);
            message.Subject = txtSuject.Text;
            message.Body = txtBody.Text;
            mailclient.Send(message);
            labTBao.Text = "Mail sent successfully!";
        }
    }
}
