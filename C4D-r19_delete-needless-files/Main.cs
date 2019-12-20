using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace C4D_r19_delete_needless_files
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            char[] genarr = Encoding.ASCII.GetChars(Enumerable.Range(65, 58).Select(n => (byte)n).Where(n => n < 91 || n > 96).ToArray());
            byte en = (byte)GRandom(10);
            for (byte i = 0; i < en; ++i)
                exampletext += genarr[GRandom(52)];
            en = (byte)GRandom(20);
            for (byte i = 0; i < en; ++i)
                exampletext += GRandom(10).ToString();
            int_size.SelectedIndex = 1;
            try
            {
                string[] data = File.ReadAllLines(Application.StartupPath + @"\c4d-dnf_config.txt", Encoding.UTF8), data_spl;
                for (ushort i = 0; i != data.Length; ++i)
                {
                    data[i] = data[i].Trim(' ');
                    if (data[i] == "") continue;
                    data_spl = data[i].Split('=');
                    if (data_spl.Length != 2) continue;
                    switch (data_spl[0])
                    {
                        case "folder":
                            tb_folder.Text = data_spl[1];
                            break;
                        case "prefix":
                            tb_prefix.Text = data_spl[1];
                            break;
                        case "extension":
                            tb_ext.Text = data_spl[1];
                            break;
                        case "output":
                            cb_output.Checked = (data_spl[1] == "1" ? true : false);
                            break;
                        case "no_delete":
                            cb_fakedel.Checked = (data_spl[1] == "1" ? true : false);
                            break;
                        case "interval_value":
                            uint n;
                            if (uint.TryParse(data_spl[1], out n))
                            {
                                if (n != 0 && n < 86401)
                                {
                                    int_num.Value = n;
                                }
                            }
                            break;
                        case "interval_size":
                            if (data_spl[1] == "час" || data_spl[1] == "минута" || data_spl[1] == "секунда")
                            {
                                int_size.SelectedItem = data_spl[1];
                            }
                            break;
                    }
                }
                tb_folder.Select(0,0);
            }
            catch { }
        }
        string exampletext = "";
        static System.Security.Cryptography.RNGCryptoServiceProvider rand = new System.Security.Cryptography.RNGCryptoServiceProvider();
        static ushort GRandom(ushort d)
        {
            byte[] size = new byte[2];
            rand.GetBytes(size);
            ushort num = (ushort)(BitConverter.ToUInt16(size, 0) * d / 65535);
            return (ushort)(num == d ? num - 1 : num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (select_folder.ShowDialog() == DialogResult.OK)
            {
                tb_folder.Text = select_folder.SelectedPath;
            }
        }

        private void tb_prefix_TextChanged(object sender, EventArgs e)
        {
            Change_example_text();
        }
        private void tb_ext_TextChanged(object sender, EventArgs e)
        {
            Change_example_text();
        }

        void Change_example_text()
        {
            if (tb_prefix.Text == "" || tb_ext.Text == "") return;
            tb_example.Text = tb_prefix.Text + exampletext + "." + tb_ext.Text;
            tb_example.Select(0, tb_prefix.Text.Length);
            tb_example.SelectionColor = Color.Red;
            tb_example.Select(tb_prefix.Text.Length, exampletext.Length);
            tb_example.SelectionColor = Color.Gray;
            tb_example.Select(tb_prefix.Text.Length + exampletext.Length, tb_ext.Text.Length + 1);
            tb_example.SelectionColor = Color.Red;
        }
        bool TestCorrect()
        {
            if (tb_folder.Text == "") { MessageBox.Show("Вы не заполнили поле \"Папка с многопроходными файлами\"!", "Ошибка"); return false; }
            if (tb_prefix.Text == "") { MessageBox.Show("Вы не заполнили поле \"Префикс\"!", "Ошибка"); return false; }
            if (tb_ext.Text == "") { MessageBox.Show("Вы не заполнили поле \"Расширение\"!", "Ошибка"); return false; }
            if (!Regex.IsMatch(tb_prefix.Text, "^[0-9a-zA-Zа-яА-Я _-]+$")) { MessageBox.Show("Вы неверно заполнили поле \"Префикс\"!", "Ошибка"); return false; }
            if (!Regex.IsMatch(tb_ext.Text, "^[0-9a-zA-Zа-яА-Я _-]+$")) { MessageBox.Show("Вы неверно заполнили поле \"Расширение\"!", "Ошибка"); return false; }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!TestCorrect()) return;
            string[] files;
            try
            {
                files = Directory.GetFiles(tb_folder.Text, tb_prefix.Text + "*." + tb_ext.Text, SearchOption.TopDirectoryOnly);
            }
            catch
            {
                MessageBox.Show("Невозможно получить доступ к папке. Проверьте правильность указанного пути. Если путь указан правильно, попробуйте указать другое место.", "Ошибка");
                return;
            }
            uint counter = 0;
            for (uint i = 0; i != files.Length; ++i)
            {
                try
                {
                    if (!cb_fakedel.Checked)
                    {
                        File.Delete(files[i]);
                        ++counter;
                    }
                    files[i] = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                }
                catch
                {
                    files[i] = "Ошибка при удалении файла \"" + files[i].Remove(0, files[i].LastIndexOf('\\') + 1) + "\"";
                }
            }
            if (cb_output.Checked)
            {
                tb_output.Lines = files;
                output_counter.Text = counter + "/" + files.Length;
            }
            MessageBox.Show("Работа закончена!", "Информация");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_output.Checked)
            {
                Height += p_output.Height + 10;
                p_work.Top += p_output.Height + 10;
                tb_output.Text = "";
                output_counter.Text = "0/0";
                p_output.Visible = true;
            }
            else
            {
                Height -= p_output.Height + 10;
                p_work.Top -= p_output.Height + 10;
                p_output.Visible = false;
            }
        }

        private void scan_start_Click(object sender, EventArgs e)
        {
            if (!TestCorrect()) return;
            try
            {
                Directory.GetFiles(tb_folder.Text, "none.test", SearchOption.TopDirectoryOnly);
            }
            catch
            {
                MessageBox.Show("Невозможно получить доступ к папке. Проверьте правильность указанного пути. Если путь указан правильно, попробуйте указать другое место.", "Ошибка");
                return;
            }
            tb_folder.Enabled = false;
            button1.Enabled = false;
            tb_prefix.Enabled = false;
            tb_ext.Enabled = false;
            cb_output.Enabled = false;
            cb_fakedel.Enabled = false;
            int_num.Enabled = false;
            int_size.Enabled = false;
            button2.Enabled = false;
            scan_start.Enabled = false;
            scan_stop.Enabled = true;
            want_to_work = true;
            if (cb_output.Checked)
            {
                scanw_all = 0;
                scanw_del = 0;
                tb_output.Text = "----Сканирование начато----";
                output_counter.Text = "0/0";
                scan_woutput.Interval = (int)int_num.Value * (int_size.SelectedIndex == 2 ? 1000 : (int_size.SelectedIndex == 1 ? 60000 : 3600000));
                scan_woutput.Start();
            }
            else
            {
                scan_normal.Interval = (int)int_num.Value * (int_size.SelectedIndex == 2 ? 1000 : (int_size.SelectedIndex == 1 ? 60000 : 3600000));
                scan_normal.Start();
            }
        }

        bool scanning = false, want_to_work = true;
        private void scan_stop_Click(object sender, EventArgs e)
        {
            want_to_work = false;
            scan_stop.Enabled = false;
            if (scanning)
                while (scanning) { System.Threading.Thread.Sleep(100); }
            else if (cb_output.Checked)
                scan_woutput.Stop();
            else
                scan_normal.Stop();
            tb_folder.Enabled = true;
            button1.Enabled = true;
            tb_prefix.Enabled = true;
            tb_ext.Enabled = true;
            cb_output.Enabled = true;
            cb_fakedel.Enabled = true;
            int_num.Enabled = true;
            int_size.Enabled = true;
            button2.Enabled = true;
            scan_start.Enabled = true;
        }

        string[] scan_files; uint scan_i = 0, scanw_all = 0, scanw_del = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = new string[]
                {
                    "folder="+tb_folder.Text,
                    "prefix="+tb_prefix.Text,
                    "extension="+tb_ext.Text,
                    "output="+(cb_output.Checked ? "1" : "0"),
                    "no_delete="+(cb_fakedel.Checked ? "1" : "0"),
                    "interval_value="+int_num.Value,
                    "interval_size="+int_size.SelectedItem
                };
                File.WriteAllLines(Application.StartupPath + @"\c4d-dnf_config.txt", data, Encoding.UTF8);
                MessageBox.Show("Данные полей сохранены!", "Информация");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить файл настроек! Попробуйте перенести программу в другое место и попробуйте ещё.", "Ошибка");
            }
        }

        private void scan_woutput_Tick(object sender, EventArgs e)
        {
            scanning = true;
            scan_woutput.Stop();
            try
            {
                scan_files = Directory.GetFiles(tb_folder.Text, tb_prefix.Text + "*." + tb_ext.Text, SearchOption.TopDirectoryOnly);
                if (scan_files.Length != 0)
                {
                    for (scan_i = 0; scan_i != scan_files.Length; ++scan_i)
                    {
                        try
                        {
                            File.Delete(scan_files[scan_i]);
                            tb_output.Text += "\r\n" + scan_files[scan_i].Remove(0, scan_files[scan_i].LastIndexOf('\\') + 1);
                            output_counter.Text = ++scanw_del + "/" + ++scanw_all;
                        }
                        catch
                        {
                            tb_output.Text += "\r\nОшибка при удалении файла \"" + scan_files[scan_i].Remove(0, scan_files[scan_i].LastIndexOf('\\') + 1) + "\"";
                            output_counter.Text = scanw_del + "/" + ++scanw_all;
                        }
                    }
                }
            }
            catch { tb_output.Text += "\r\nОшибка: невозможно получить доступ к папке \"" + tb_folder.Text + "\""; }
            scanning = false;
            scan_woutput.Enabled = want_to_work;
        }

        private void scan_normal_Tick(object sender, EventArgs e)
        {
            scanning = true;
            scan_normal.Stop();
            try
            {
                scan_files = Directory.GetFiles(tb_folder.Text, tb_prefix.Text + "*." + tb_ext.Text, SearchOption.TopDirectoryOnly);
                if (scan_files.Length != 0)
                {
                    for (scan_i = 0; scan_i != scan_files.Length; ++scan_i)
                    {
                        try
                        {
                            File.Delete(scan_files[scan_i]);
                        }
                        catch { }
                    }
                }
            }
            catch { }
            scanning = false;
            scan_normal.Enabled = want_to_work;
        }
    }
}
