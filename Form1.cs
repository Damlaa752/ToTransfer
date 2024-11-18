using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            string text = rchSQL.Text;
            //foreach (char harf in text)
                //{
                //    switch (switch_on)
                //    {
                //        default:
                //    }
                if (text.StartsWith("LG"))
                {
                    int spaceIndex = text.IndexOf(' ');
                    string segment = spaceIndex > 0 ? text.Substring(0, spaceIndex) : text;

                    //en son "_" karakterinin bulunduğu yerden sonrasını al 
                    int lastUnderscoreIndex= segment.LastIndexOf('_');
                    if (lastUnderscoreIndex >= 0 && lastUnderscoreIndex + 1 < segment.Length)
                    {
                        string beforeLastUnderscore = segment.Substring(0, lastUnderscoreIndex + 1);
                        string afterLastUnderscore = segment.Substring(lastUnderscoreIndex + 1);

                        // Güncellenmiş satırı oluştur
                        string updatedLine = beforeLastUnderscore + $"{{{afterLastUnderscore}}}";

                        // Güncellenmiş metni RichTextBox'a yazdır
                        rchTransfer.Text = updatedLine;
                    }
                    else
                    {
                        MessageBox.Show("Metin LG ile başlıyor ama '_' karakteri bulunamadı veya sonrası yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            else
                {
                    MessageBox.Show("Metin LG ile başlamıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

