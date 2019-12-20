namespace C4D_r19_delete_needless_files
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_folder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.select_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.tb_ext = new System.Windows.Forms.TextBox();
            this.tb_example = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_output = new System.Windows.Forms.CheckBox();
            this.output_counter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.int_num = new System.Windows.Forms.NumericUpDown();
            this.int_size = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_fakedel = new System.Windows.Forms.CheckBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p_output = new System.Windows.Forms.Panel();
            this.p_work = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scan_start = new System.Windows.Forms.Button();
            this.scan_stop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scan_normal = new System.Windows.Forms.Timer(this.components);
            this.scan_woutput = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.int_num)).BeginInit();
            this.p_output.SuspendLayout();
            this.p_work.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_folder
            // 
            this.tb_folder.Location = new System.Drawing.Point(12, 29);
            this.tb_folder.MaxLength = 16000;
            this.tb_folder.Name = "tb_folder";
            this.tb_folder.Size = new System.Drawing.Size(442, 23);
            this.tb_folder.TabIndex = 0;
            this.toolTip.SetToolTip(this.tb_folder, "Введите путь к папке, в которую будут сохраняться многопроходные файлы.");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(460, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = ". . .";
            this.toolTip.SetToolTip(this.button1, "Открыть окно выбора папки, в которую будут сохраняться многопроходные файлы.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Папка с многопроходными файлами:";
            // 
            // select_folder
            // 
            this.select_folder.Description = "Ввберите папку, в которую будут сохраняться многопроходные файлы.";
            this.select_folder.ShowNewFolderButton = false;
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(12, 83);
            this.tb_prefix.MaxLength = 255;
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(341, 23);
            this.tb_prefix.TabIndex = 2;
            this.toolTip.SetToolTip(this.tb_prefix, "Введите начало имени ненужного многопроходного файла, по которому его можно будет" +
        " отличить от нужных. Например: \"myname_rgb\"");
            this.tb_prefix.TextChanged += new System.EventHandler(this.tb_prefix_TextChanged);
            // 
            // tb_ext
            // 
            this.tb_ext.Location = new System.Drawing.Point(359, 83);
            this.tb_ext.MaxLength = 10;
            this.tb_ext.Name = "tb_ext";
            this.tb_ext.Size = new System.Drawing.Size(154, 23);
            this.tb_ext.TabIndex = 3;
            this.toolTip.SetToolTip(this.tb_ext, "Введите расширение многопроходного файла.");
            this.tb_ext.TextChanged += new System.EventHandler(this.tb_ext_TextChanged);
            // 
            // tb_example
            // 
            this.tb_example.BackColor = System.Drawing.SystemColors.Window;
            this.tb_example.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_example.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_example.DetectUrls = false;
            this.tb_example.Location = new System.Drawing.Point(12, 137);
            this.tb_example.MaxLength = 512;
            this.tb_example.Multiline = false;
            this.tb_example.Name = "tb_example";
            this.tb_example.ReadOnly = true;
            this.tb_example.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tb_example.ShortcutsEnabled = false;
            this.tb_example.Size = new System.Drawing.Size(501, 21);
            this.tb_example.TabIndex = 4;
            this.tb_example.Text = "";
            this.toolTip.SetToolTip(this.tb_example, "Здесь выведен пример имени файла, который будет удалён.");
            this.tb_example.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Проверить";
            this.toolTip.SetToolTip(this.button2, "Выполнить одинарный поиск и удаление файлов в указанной папке.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_output
            // 
            this.cb_output.AutoSize = true;
            this.cb_output.Checked = true;
            this.cb_output.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_output.Location = new System.Drawing.Point(12, 164);
            this.cb_output.Name = "cb_output";
            this.cb_output.Size = new System.Drawing.Size(64, 20);
            this.cb_output.TabIndex = 5;
            this.cb_output.Text = "Вывод";
            this.toolTip.SetToolTip(this.cb_output, "Включить вывод удалённых файлов.\r\nРекомендуется только для проверки.");
            this.cb_output.UseVisualStyleBackColor = true;
            this.cb_output.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // output_counter
            // 
            this.output_counter.AutoSize = true;
            this.output_counter.Location = new System.Drawing.Point(362, 20);
            this.output_counter.Name = "output_counter";
            this.output_counter.Size = new System.Drawing.Size(27, 16);
            this.output_counter.TabIndex = 101;
            this.output_counter.Text = "0/0";
            this.toolTip.SetToolTip(this.output_counter, "удалено файлов / обнаружено файлов");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Удалено файлов:";
            this.toolTip.SetToolTip(this.label5, "Количество удалённых файлов.");
            // 
            // int_num
            // 
            this.int_num.Location = new System.Drawing.Point(208, 4);
            this.int_num.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.int_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.int_num.Name = "int_num";
            this.int_num.Size = new System.Drawing.Size(71, 23);
            this.int_num.TabIndex = 9;
            this.toolTip.SetToolTip(this.int_num, "Введите значение промежутка.");
            this.int_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // int_size
            // 
            this.int_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.int_size.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.int_size.FormattingEnabled = true;
            this.int_size.Items.AddRange(new object[] {
            "час",
            "минута",
            "секунда"});
            this.int_size.Location = new System.Drawing.Point(286, 4);
            this.int_size.Name = "int_size";
            this.int_size.Size = new System.Drawing.Size(82, 24);
            this.int_size.TabIndex = 10;
            this.toolTip.SetToolTip(this.int_size, "Выберите единицу промежутка.");
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(416, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 22);
            this.button3.TabIndex = 14;
            this.button3.Text = "Сохранить";
            this.toolTip.SetToolTip(this.button3, "Сохранить значения полей для следующих запусков программы.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_fakedel
            // 
            this.cb_fakedel.AutoSize = true;
            this.cb_fakedel.Checked = true;
            this.cb_fakedel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_fakedel.Location = new System.Drawing.Point(281, 167);
            this.cb_fakedel.Name = "cb_fakedel";
            this.cb_fakedel.Size = new System.Drawing.Size(93, 20);
            this.cb_fakedel.TabIndex = 6;
            this.cb_fakedel.Text = "Не удалять";
            this.toolTip.SetToolTip(this.cb_fakedel, resources.GetString("cb_fakedel.ToolTip"));
            this.cb_fakedel.UseVisualStyleBackColor = true;
            // 
            // tb_output
            // 
            this.tb_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_output.BackColor = System.Drawing.SystemColors.Window;
            this.tb_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_output.Location = new System.Drawing.Point(4, 4);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_output.ShortcutsEnabled = false;
            this.tb_output.Size = new System.Drawing.Size(352, 133);
            this.tb_output.TabIndex = 0;
            this.tb_output.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "Префикс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Расширение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "Пример файла, который будет удалён:";
            // 
            // p_output
            // 
            this.p_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_output.Controls.Add(this.label5);
            this.p_output.Controls.Add(this.output_counter);
            this.p_output.Controls.Add(this.tb_output);
            this.p_output.Location = new System.Drawing.Point(12, 194);
            this.p_output.Name = "p_output";
            this.p_output.Size = new System.Drawing.Size(501, 142);
            this.p_output.TabIndex = 8;
            // 
            // p_work
            // 
            this.p_work.Controls.Add(this.button3);
            this.p_work.Controls.Add(this.label7);
            this.p_work.Controls.Add(this.tableLayoutPanel1);
            this.p_work.Controls.Add(this.int_size);
            this.p_work.Controls.Add(this.int_num);
            this.p_work.Controls.Add(this.label6);
            this.p_work.Location = new System.Drawing.Point(12, 342);
            this.p_work.Name = "p_work";
            this.p_work.Size = new System.Drawing.Size(500, 127);
            this.p_work.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(492, 38);
            this.label7.TabIndex = 106;
            this.label7.Text = "Вы можете задать процессу этой программы другой приоритет, что повлияет на скорос" +
    "ть работа данной программы.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.scan_start, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scan_stop, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 38);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // scan_start
            // 
            this.scan_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scan_start.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scan_start.Location = new System.Drawing.Point(3, 3);
            this.scan_start.Name = "scan_start";
            this.scan_start.Size = new System.Drawing.Size(240, 32);
            this.scan_start.TabIndex = 0;
            this.scan_start.Text = "Запустить сканирование";
            this.scan_start.UseVisualStyleBackColor = true;
            this.scan_start.Click += new System.EventHandler(this.scan_start_Click);
            // 
            // scan_stop
            // 
            this.scan_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scan_stop.Enabled = false;
            this.scan_stop.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scan_stop.Location = new System.Drawing.Point(249, 3);
            this.scan_stop.Name = "scan_stop";
            this.scan_stop.Size = new System.Drawing.Size(240, 32);
            this.scan_stop.TabIndex = 1;
            this.scan_stop.Text = "Остановить сканирование";
            this.scan_stop.UseVisualStyleBackColor = true;
            this.scan_stop.Click += new System.EventHandler(this.scan_stop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "Введите период сканирования: ";
            // 
            // scan_normal
            // 
            this.scan_normal.Tick += new System.EventHandler(this.scan_normal_Tick);
            // 
            // scan_woutput
            // 
            this.scan_woutput.Tick += new System.EventHandler(this.scan_woutput_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 481);
            this.Controls.Add(this.cb_fakedel);
            this.Controls.Add(this.p_work);
            this.Controls.Add(this.p_output);
            this.Controls.Add(this.cb_output);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_example);
            this.Controls.Add(this.tb_ext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_folder);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Cinema 4D R19.053 - удалить лишние многопроходные файлы";
            ((System.ComponentModel.ISupportInitialize)(this.int_num)).EndInit();
            this.p_output.ResumeLayout(false);
            this.p_output.PerformLayout();
            this.p_work.ResumeLayout(false);
            this.p_work.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog select_folder;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ext;
        private System.Windows.Forms.RichTextBox tb_example;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb_output;
        private System.Windows.Forms.Panel p_output;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label output_counter;
        private System.Windows.Forms.Panel p_work;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown int_num;
        private System.Windows.Forms.ComboBox int_size;
        private System.Windows.Forms.Button scan_start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button scan_stop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer scan_normal;
        private System.Windows.Forms.Timer scan_woutput;
        private System.Windows.Forms.CheckBox cb_fakedel;
    }
}

