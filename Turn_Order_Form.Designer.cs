namespace Turn_Order
{
    partial class Turn_Order_Form
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
            Conc_button = new Button();
            Conc_text = new Label();
            groupBox5 = new GroupBox();
            Damage_text = new TextBox();
            label11 = new Label();
            Damage_button = new Button();
            Damage_comboBox = new ComboBox();
            label13 = new Label();
            groupBox4 = new GroupBox();
            Init_change_text = new TextBox();
            label10 = new Label();
            Init_change_button = new Button();
            Init_change_comboBox = new ComboBox();
            label9 = new Label();
            Current_label = new Label();
            label4 = new Label();
            Next_button = new Button();
            List_of_Characters_groupBox = new GroupBox();
            _label2 = new Label();
            label14 = new Label();
            Health_text = new TextBox();
            drop_groupBox = new GroupBox();
            Delete_button = new Button();
            Delete_comboBox = new ComboBox();
            label12 = new Label();
            label3 = new Label();
            add_groupBox = new GroupBox();
            Actor_check = new CheckBox();
            Add_max_health_text = new TextBox();
            label8 = new Label();
            Add_button = new Button();
            Add_health_text = new TextBox();
            label7 = new Label();
            Add_init_text = new TextBox();
            label6 = new Label();
            Add_name_text = new TextBox();
            label5 = new Label();
            label1 = new Label();
            Init_text = new TextBox();
            Name_text = new TextBox();
            _label1 = new Label();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            List_of_Characters_groupBox.SuspendLayout();
            drop_groupBox.SuspendLayout();
            add_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Conc_button
            // 
            Conc_button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Conc_button.Location = new Point(560, 135);
            Conc_button.Margin = new Padding(4, 3, 4, 3);
            Conc_button.Name = "Conc_button";
            Conc_button.Size = new Size(266, 38);
            Conc_button.TabIndex = 26;
            Conc_button.Text = "Сконцентрироваться / Не";
            Conc_button.UseVisualStyleBackColor = true;
            Conc_button.Click += Conc_button_Click;
            // 
            // Conc_text
            // 
            Conc_text.AutoSize = true;
            Conc_text.BackColor = SystemColors.GradientInactiveCaption;
            Conc_text.Font = new Font("Noto Serif Cond", 18F, FontStyle.Bold);
            Conc_text.ForeColor = SystemColors.ControlText;
            Conc_text.Location = new Point(585, 362);
            Conc_text.Margin = new Padding(4, 0, 4, 0);
            Conc_text.Name = "Conc_text";
            Conc_text.Size = new Size(216, 33);
            Conc_text.TabIndex = 25;
            Conc_text.Text = "Концентрируется";
            Conc_text.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.AppWorkspace;
            groupBox5.Controls.Add(Damage_text);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(Damage_button);
            groupBox5.Controls.Add(Damage_comboBox);
            groupBox5.Controls.Add(label13);
            groupBox5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox5.Location = new Point(48, 280);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(343, 195);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Нанести урон";
            // 
            // Damage_text
            // 
            Damage_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Damage_text.Location = new Point(164, 78);
            Damage_text.Margin = new Padding(4, 3, 4, 3);
            Damage_text.Name = "Damage_text";
            Damage_text.Size = new Size(156, 29);
            Damage_text.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(7, 82);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(59, 24);
            label11.TabIndex = 7;
            label11.Text = "Урон";
            // 
            // Damage_button
            // 
            Damage_button.Location = new Point(61, 129);
            Damage_button.Margin = new Padding(4, 3, 4, 3);
            Damage_button.Name = "Damage_button";
            Damage_button.Size = new Size(210, 46);
            Damage_button.TabIndex = 6;
            Damage_button.Text = "Ударить!";
            Damage_button.UseVisualStyleBackColor = true;
            Damage_button.Click += Damage_button_Click;
            // 
            // Damage_comboBox
            // 
            Damage_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Damage_comboBox.FormattingEnabled = true;
            Damage_comboBox.ImeMode = ImeMode.NoControl;
            Damage_comboBox.Location = new Point(180, 35);
            Damage_comboBox.Margin = new Padding(4, 3, 4, 3);
            Damage_comboBox.MaxDropDownItems = 15;
            Damage_comboBox.Name = "Damage_comboBox";
            Damage_comboBox.Size = new Size(140, 33);
            Damage_comboBox.Sorted = true;
            Damage_comboBox.TabIndex = 6;
            Damage_comboBox.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(7, 38);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(49, 24);
            label13.TabIndex = 4;
            label13.Text = "Имя";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.AppWorkspace;
            groupBox4.Controls.Add(Init_change_text);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(Init_change_button);
            groupBox4.Controls.Add(Init_change_comboBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(48, 59);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(343, 195);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Изменить инициативу";
            // 
            // Init_change_text
            // 
            Init_change_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Init_change_text.Location = new Point(164, 78);
            Init_change_text.Margin = new Padding(4, 3, 4, 3);
            Init_change_text.Name = "Init_change_text";
            Init_change_text.Size = new Size(156, 29);
            Init_change_text.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(7, 82);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(129, 24);
            label10.TabIndex = 7;
            label10.Text = "Инициатива";
            // 
            // Init_change_button
            // 
            Init_change_button.Location = new Point(61, 129);
            Init_change_button.Margin = new Padding(4, 3, 4, 3);
            Init_change_button.Name = "Init_change_button";
            Init_change_button.Size = new Size(210, 46);
            Init_change_button.TabIndex = 6;
            Init_change_button.Text = "Изменить";
            Init_change_button.UseVisualStyleBackColor = true;
            Init_change_button.Click += Init_change_button_Click;
            // 
            // Init_change_comboBox
            // 
            Init_change_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Init_change_comboBox.FormattingEnabled = true;
            Init_change_comboBox.ImeMode = ImeMode.NoControl;
            Init_change_comboBox.Location = new Point(180, 35);
            Init_change_comboBox.Margin = new Padding(4, 3, 4, 3);
            Init_change_comboBox.MaxDropDownItems = 15;
            Init_change_comboBox.Name = "Init_change_comboBox";
            Init_change_comboBox.Size = new Size(140, 33);
            Init_change_comboBox.Sorted = true;
            Init_change_comboBox.TabIndex = 6;
            Init_change_comboBox.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(7, 38);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 24);
            label9.TabIndex = 4;
            label9.Text = "Имя";
            // 
            // Current_label
            // 
            Current_label.AutoSize = true;
            Current_label.BackColor = SystemColors.InactiveCaption;
            Current_label.Font = new Font("Monotype Corsiva", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Current_label.Location = new Point(614, 283);
            Current_label.Margin = new Padding(4, 0, 4, 0);
            Current_label.Name = "Current_label";
            Current_label.Size = new Size(157, 57);
            Current_label.TabIndex = 22;
            Current_label.Text = "Fighter";
            Current_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Font = new Font("MV Boli", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(572, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(238, 34);
            label4.TabIndex = 21;
            label4.Text = "Текущий Воин:";
            // 
            // Next_button
            // 
            Next_button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Next_button.Location = new Point(595, 421);
            Next_button.Margin = new Padding(4, 3, 4, 3);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(205, 44);
            Next_button.TabIndex = 20;
            Next_button.Text = "Далее!";
            Next_button.UseVisualStyleBackColor = true;
            Next_button.Click += Next_button_Click;
            // 
            // List_of_Characters_groupBox
            // 
            List_of_Characters_groupBox.Controls.Add(_label2);
            List_of_Characters_groupBox.Controls.Add(label14);
            List_of_Characters_groupBox.Controls.Add(Health_text);
            List_of_Characters_groupBox.Controls.Add(drop_groupBox);
            List_of_Characters_groupBox.Controls.Add(label3);
            List_of_Characters_groupBox.Controls.Add(add_groupBox);
            List_of_Characters_groupBox.Controls.Add(label1);
            List_of_Characters_groupBox.Controls.Add(Init_text);
            List_of_Characters_groupBox.Controls.Add(Name_text);
            List_of_Characters_groupBox.Controls.Add(_label1);
            List_of_Characters_groupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            List_of_Characters_groupBox.Location = new Point(1088, 14);
            List_of_Characters_groupBox.Margin = new Padding(4, 3, 4, 3);
            List_of_Characters_groupBox.Name = "List_of_Characters_groupBox";
            List_of_Characters_groupBox.Padding = new Padding(4, 3, 4, 3);
            List_of_Characters_groupBox.Size = new Size(746, 678);
            List_of_Characters_groupBox.TabIndex = 19;
            List_of_Characters_groupBox.TabStop = false;
            List_of_Characters_groupBox.Text = "Список";
            // 
            // _label2
            // 
            _label2.AutoSize = true;
            _label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            _label2.Location = new Point(448, 126);
            _label2.Margin = new Padding(4, 0, 4, 0);
            _label2.Name = "_label2";
            _label2.Size = new Size(20, 25);
            _label2.TabIndex = 16;
            _label2.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(555, 31);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(80, 33);
            label14.TabIndex = 15;
            label14.Text = "Хиты";
            // 
            // Health_text
            // 
            Health_text.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Health_text.Location = new Point(522, 80);
            Health_text.Margin = new Padding(4, 3, 4, 3);
            Health_text.Multiline = true;
            Health_text.Name = "Health_text";
            Health_text.ReadOnly = true;
            Health_text.Size = new Size(173, 136);
            Health_text.TabIndex = 14;
            Health_text.TabStop = false;
            Health_text.TextAlign = HorizontalAlignment.Center;
            // 
            // drop_groupBox
            // 
            drop_groupBox.BackColor = SystemColors.AppWorkspace;
            drop_groupBox.Controls.Add(Delete_button);
            drop_groupBox.Controls.Add(Delete_comboBox);
            drop_groupBox.Controls.Add(label12);
            drop_groupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            drop_groupBox.Location = new Point(364, 345);
            drop_groupBox.Margin = new Padding(4, 3, 4, 3);
            drop_groupBox.Name = "drop_groupBox";
            drop_groupBox.Padding = new Padding(4, 3, 4, 3);
            drop_groupBox.Size = new Size(223, 168);
            drop_groupBox.TabIndex = 13;
            drop_groupBox.TabStop = false;
            drop_groupBox.Text = "Удалить бойца";
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(7, 96);
            Delete_button.Margin = new Padding(4, 3, 4, 3);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(210, 46);
            Delete_button.TabIndex = 6;
            Delete_button.Text = "Удалить";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // Delete_comboBox
            // 
            Delete_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Delete_comboBox.FormattingEnabled = true;
            Delete_comboBox.ImeMode = ImeMode.NoControl;
            Delete_comboBox.Location = new Point(71, 33);
            Delete_comboBox.Margin = new Padding(4, 3, 4, 3);
            Delete_comboBox.MaxDropDownItems = 15;
            Delete_comboBox.Name = "Delete_comboBox";
            Delete_comboBox.Size = new Size(140, 33);
            Delete_comboBox.Sorted = true;
            Delete_comboBox.TabIndex = 6;
            Delete_comboBox.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(7, 38);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 24);
            label12.TabIndex = 4;
            label12.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(278, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 33);
            label3.TabIndex = 5;
            label3.Text = "Инициатива";
            // 
            // add_groupBox
            // 
            add_groupBox.BackColor = SystemColors.AppWorkspace;
            add_groupBox.Controls.Add(Actor_check);
            add_groupBox.Controls.Add(Add_max_health_text);
            add_groupBox.Controls.Add(label8);
            add_groupBox.Controls.Add(Add_button);
            add_groupBox.Controls.Add(Add_health_text);
            add_groupBox.Controls.Add(label7);
            add_groupBox.Controls.Add(Add_init_text);
            add_groupBox.Controls.Add(label6);
            add_groupBox.Controls.Add(Add_name_text);
            add_groupBox.Controls.Add(label5);
            add_groupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            add_groupBox.Location = new Point(7, 345);
            add_groupBox.Margin = new Padding(4, 3, 4, 3);
            add_groupBox.Name = "add_groupBox";
            add_groupBox.Padding = new Padding(4, 3, 4, 3);
            add_groupBox.Size = new Size(350, 323);
            add_groupBox.TabIndex = 5;
            add_groupBox.TabStop = false;
            add_groupBox.Text = "Добавить бойца";
            // 
            // Actor_check
            // 
            Actor_check.AutoSize = true;
            Actor_check.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Actor_check.Location = new Point(110, 203);
            Actor_check.Margin = new Padding(4, 3, 4, 3);
            Actor_check.Name = "Actor_check";
            Actor_check.Size = new Size(100, 28);
            Actor_check.TabIndex = 12;
            Actor_check.Text = "Герой?";
            Actor_check.UseVisualStyleBackColor = true;
            // 
            // Add_max_health_text
            // 
            Add_max_health_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Add_max_health_text.Location = new Point(164, 163);
            Add_max_health_text.Margin = new Padding(4, 3, 4, 3);
            Add_max_health_text.Name = "Add_max_health_text";
            Add_max_health_text.Size = new Size(156, 29);
            Add_max_health_text.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(7, 166);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 24);
            label8.TabIndex = 10;
            label8.Text = "Макс Хиты";
            // 
            // Add_button
            // 
            Add_button.Location = new Point(70, 254);
            Add_button.Margin = new Padding(4, 3, 4, 3);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(210, 46);
            Add_button.TabIndex = 6;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // Add_health_text
            // 
            Add_health_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Add_health_text.Location = new Point(164, 121);
            Add_health_text.Margin = new Padding(4, 3, 4, 3);
            Add_health_text.Name = "Add_health_text";
            Add_health_text.Size = new Size(156, 29);
            Add_health_text.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(7, 125);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 24);
            label7.TabIndex = 8;
            label7.Text = "Хиты";
            // 
            // Add_init_text
            // 
            Add_init_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Add_init_text.Location = new Point(164, 78);
            Add_init_text.Margin = new Padding(4, 3, 4, 3);
            Add_init_text.Name = "Add_init_text";
            Add_init_text.Size = new Size(156, 29);
            Add_init_text.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(7, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 24);
            label6.TabIndex = 6;
            label6.Text = "Инициатива";
            // 
            // Add_name_text
            // 
            Add_name_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Add_name_text.Location = new Point(164, 35);
            Add_name_text.Margin = new Padding(4, 3, 4, 3);
            Add_name_text.Name = "Add_name_text";
            Add_name_text.Size = new Size(156, 29);
            Add_name_text.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(7, 38);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 24);
            label5.TabIndex = 4;
            label5.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(70, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 33);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // Init_text
            // 
            Init_text.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Init_text.Location = new Point(328, 80);
            Init_text.Margin = new Padding(4, 3, 4, 3);
            Init_text.Multiline = true;
            Init_text.Name = "Init_text";
            Init_text.ReadOnly = true;
            Init_text.Size = new Size(75, 136);
            Init_text.TabIndex = 3;
            Init_text.TabStop = false;
            Init_text.TextAlign = HorizontalAlignment.Center;
            // 
            // Name_text
            // 
            Name_text.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name_text.Location = new Point(7, 80);
            Name_text.Margin = new Padding(4, 3, 4, 3);
            Name_text.Multiline = true;
            Name_text.Name = "Name_text";
            Name_text.ReadOnly = true;
            Name_text.Size = new Size(219, 136);
            Name_text.TabIndex = 2;
            Name_text.TabStop = false;
            Name_text.TextAlign = HorizontalAlignment.Center;
            // 
            // _label1
            // 
            _label1.AutoSize = true;
            _label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            _label1.Location = new Point(258, 126);
            _label1.Margin = new Padding(4, 0, 4, 0);
            _label1.Name = "_label1";
            _label1.Size = new Size(20, 25);
            _label1.TabIndex = 1;
            _label1.Text = "-";
            // 
            // Turn_Order_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1848, 993);
            Controls.Add(Conc_button);
            Controls.Add(Conc_text);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(Current_label);
            Controls.Add(label4);
            Controls.Add(Next_button);
            Controls.Add(List_of_Characters_groupBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Turn_Order_Form";
            Text = "Turn_Order_Form";
            Load += Turn_Order_Form_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            List_of_Characters_groupBox.ResumeLayout(false);
            List_of_Characters_groupBox.PerformLayout();
            drop_groupBox.ResumeLayout(false);
            drop_groupBox.PerformLayout();
            add_groupBox.ResumeLayout(false);
            add_groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Conc_button;
        private System.Windows.Forms.Label Conc_text;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Damage_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Damage_button;
        private System.Windows.Forms.ComboBox Damage_comboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Init_change_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Init_change_button;
        private System.Windows.Forms.ComboBox Init_change_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Current_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.GroupBox List_of_Characters_groupBox;
        public System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox Health_text;
        private System.Windows.Forms.GroupBox drop_groupBox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.ComboBox Delete_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox add_groupBox;
        private System.Windows.Forms.CheckBox Actor_check;
        private System.Windows.Forms.TextBox Add_max_health_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Add_health_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Add_init_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Add_name_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Init_text;
        public System.Windows.Forms.TextBox Name_text;
        public System.Windows.Forms.Label _label1;
    }
}