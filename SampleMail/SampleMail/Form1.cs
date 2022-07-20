using System;
using System.Collections.Generic;
using System.Windows.Forms;
using S22.Imap;

namespace SampleMail
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            using (ImapClient client = new ImapClient("imap.gmail.com", 993, "sample202207@gmail.com", "jghximzgvlunuxhi", AuthMethod.Login, true))
            {
                // 未読メールのみ
                IEnumerable<uint> uids = client.Search(
                  SearchCondition.Unseen()
                );

                foreach (var uid in uids)
                {
                    var message = client.GetMessage(uid, true);
                    // メールの内容（Body）を出力させる
                    label.Text = message.Body;
                }
            }
        }

    }
}
