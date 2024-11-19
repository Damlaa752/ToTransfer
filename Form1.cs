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


            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                //dbo. damla. test. gelen kelimede içerisinde bu ifade yer alanı kontrol et
                if (words[i].Contains("LG") || words[i].Contains("LV"))
                {
                    string lgWord = words[i].TrimEnd();

                    var firstIndexOf = lgWord.IndexOf("LG");

                    if (firstIndexOf == -1)
                    {
                        firstIndexOf = lgWord.IndexOf("LV");
                    }
                    var firstSide = lgWord.Substring(0, firstIndexOf);
                    int lastUnderscoreIndex = lgWord.LastIndexOf('_');
                    if (lastUnderscoreIndex>=0 && lastUnderscoreIndex+1 <lgWord.Length)
                    {
                        string afterLastUnderscore = lgWord.Substring(lastUnderscoreIndex+1);
                        //lgWord=lgWord.Substring(0, lastUnderscoreIndex+1)+$"{{{afterLasUnderscore}}}";
                        char[] invalidChars = { ')', '*', '/', '[', '?', ']', '-', '+' };
                        if (!string.IsNullOrEmpty(afterLastUnderscore))
                        {
                            char lastChar = afterLastUnderscore[afterLastUnderscore.Length-1];
                            if (Array.Exists(invalidChars, c => c == lastChar))
                            {
                                string result = afterLastUnderscore.Substring(0, afterLastUnderscore.Length - 1);
                                words[i]=$"{{{result}}}{lastChar}";
                            }
                            else
                            {
                                words[i]=$"{{{afterLastUnderscore}}}";
                            }
                        }

                    }
                }
            }
            rchTransfer.Text=string.Join(" ", words);
        }
    }
}

