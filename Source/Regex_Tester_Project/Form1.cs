using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Regex_Tester_Project
{
    public partial class Form1 : Form
    {
        Regex regex_standard = new Regex("^(?:(?:[^?+*{}()[\\]\\\\|]+|\\\\.|\\[(?:\\^?\\\\.|\\^[^\\\\]|[^\\\\^])(?:[^\\]\\\\]+|\\\\.)*\\]|\\((?:\\?[:=!]|\\?<[=!]|\\?>|\\?<[^\\W\\d]\\w*>|\\?'[^\\W\\d]\\w*')?(?<N>)|\\)(?<-N>))(?:(?:[?+*]|\\{\\d+(?:,\\d*)?\\})[?+]?)?|\\|)*$(?(N)(?!))");
        string unicode_test = "\\u";
        string unicode_key = "(á|à|ạ|ả|ã|ă|ắ|ằ|ặ|ẳ|ẵ|â|ấ|ầ|ậ|ẩ|ẫ|đ|é|è|ẹ|ẻ|ẽ|ê|ế|ề|ệ|ể|ễ|í|ì|ị|ỉ|ĩ|ó|ò|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ớ|ờ|ợ|ở|ỡ|ú|ù|ụ|ủ|ũ|ư|ứ|ừ|ự|ử|ữ|ý|ỳ|ỵ|ỷ|ỹ|Á|À|Ạ|Ả|Ã|Ă|Ắ|Ằ|Ặ|Ẳ|Ẵ|Â|Ấ|Ầ|Ậ|Ẩ|Ẫ|Đ|É|È|Ẹ|Ẻ|Ẽ|Ê|Ế|Ề|Ệ|Ể|Ễ|Í|Ì|Ị|Ỉ|Ĩ|Ó|Ò|Ọ|Ỏ|Õ|Ô|Ố|Ồ|Ộ|Ổ|Ỗ|Ơ|Ớ|Ờ|Ợ|Ở|Ỡ|Ú|Ù|Ụ|Ủ|Ũ|Ư|Ứ|Ừ|Ự|Ử|Ữ|Ý|Ỳ|Ỵ|Ỷ|Ỹ)";
        int temp = 0;
        public Form1()
        {
            InitializeComponent();              
        }

        string Vietnamese(string S)
        {
            List<int> lPosition = new List<int>();
            int position = 0;

            for (position = 2; position < S.Length - 2; position++)
            {
                if (S[position] == '-' && S[position - 1] != '0' && S[position - 1] != '1' && S[position - 1] != '\\' && S[position - 1] != '2' && S[position - 1] != '3' && S[position - 1] != '4' && S[position - 1] != '5' && S[position - 1] != '6' && S[position - 1] != '7' && S[position - 1] != '8' && S[position - 1] != '9' && S[position + 1] != '0' && S[position + 1] != '1' && S[position + 1] != '2' && S[position + 1] != '3' && S[position + 1] != '4' && S[position + 1] != '5' && S[position + 1] != '6' && S[position + 1] != '7' && S[position + 1] != '8' && S[position + 1] != '9' && S[position + 1] != '\\')
                    if (S[position] == '-')
                        lPosition.Add(position);
            }
            string az = "aáàạảãăắằặẳẵâấầậẩẫbcdđeéèẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôồốộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹzAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉÈẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸZ";

            char cStart = 'a';
            char cEnd = 'z';
            string sNew = "";
            int n = lPosition.Count();
            for (int i = n - 1; i >= 0; i--)
            {
                sNew = "";
                cStart = S[lPosition[i] - 1];
                cEnd = S[lPosition[i] + 1];
                int a = az.IndexOf(cStart);
                int b = az.IndexOf(cEnd);
                for (int j = a; j < b; j++)
                {
                    sNew = sNew + az[j] + '|';
                }
                sNew = sNew + cEnd;
                S = S.Replace(cStart + "-" + cEnd, sNew);

            }
            return S;
        }
        private void result_tester_TextChanged(object sender, EventArgs e)
         {
            regex_analyst();
        }

        public void regex_analyst()
        {
            string pattern_check = input_pattern.Text;
            string result_check = result_tester.Text;
            Match check_regex_standard = regex_standard.Match(pattern_check);
            if (check_regex_standard.Groups[0].Value != "")
            {
                pattern_check = Vietnamese(pattern_check);
                pattern_check = pattern_check.Replace(unicode_test, unicode_key);
                pattern_check = pattern_check.Replace("\\U", "[a-z]|[A-Z]");
                Regex rx = new Regex(pattern_check, RegexOptions.Compiled);
                Match match = rx.Match(result_check);
                if (match.Groups[0].Value == "")
                {
                    Error_Box.Text = "NOT EXIST";
                    Error_Box.BackColor = Color.Red;
                }
                else
                {
                    Error_Box.Text = "";
                    Error_Box.BackColor = SystemColors.ActiveBorder;
                    while (match.Groups[0].Value != "")
                    {
                        result_tester.Select(match.Index, match.Length);
                        result_tester.SelectionBackColor = Color.Yellow;
                        match = match.NextMatch();
                        temp = 1;
                    }
                    result_tester.Select(result_check.Length, result_check.Length);
                    result_tester.SelectionBackColor = SystemColors.ActiveBorder;
                    temp = 0;
                }
            }
        }

        private void input_pattern_TextChanged(object sender, EventArgs e)
        {
            regex_analyst();
            if (temp == 0)
            {
                result_tester.SelectAll();
                result_tester.SelectionBackColor = SystemColors.ActiveBorder;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT|*.txt";
            ofd.Title = "Mở file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(ofd.FileName));
                result_tester.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void exportFile_Click(object sender, EventArgs e)
        {
            string newFindBox = Vietnamese(input_pattern.Text);
            Regex regg = new Regex(newFindBox);
            Match match = Regex.Match(result_tester.Text, newFindBox);
            string a = "";
            while (match.Groups[0].Value != "")
            {
                a = a + match.Value + "\n";
                match = match.NextMatch();
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".TXT|*.txt";
            sfd.Title = "Xuất file";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(sfd.FileName));
                write.Write(a);
                write.Dispose();
            }
        }

    }
}
