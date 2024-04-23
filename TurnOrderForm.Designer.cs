namespace Turn_Order
{
    partial class TurnOrderForm
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
            concentrationButton = new Button();
            concentraionText = new Label();
            groupBox5 = new GroupBox();
            damageText = new TextBox();
            label11 = new Label();
            damageButton = new Button();
            damageComboBox = new ComboBox();
            label13 = new Label();
            groupBox4 = new GroupBox();
            initChangeText = new TextBox();
            label10 = new Label();
            initChangeButton = new Button();
            initChangeComboBox = new ComboBox();
            label9 = new Label();
            currentFighterLabel = new Label();
            label4 = new Label();
            nextButton = new Button();
            listOfCharactersGroupBox = new GroupBox();
            _label2 = new Label();
            label14 = new Label();
            healthText = new TextBox();
            dropGroupBox = new GroupBox();
            Delete_button = new Button();
            deleteComboBox = new ComboBox();
            label12 = new Label();
            label3 = new Label();
            addGroupBox = new GroupBox();
            villainCheck = new RadioButton();
            heroCheck = new RadioButton();
            addMaxHealthText = new TextBox();
            label8 = new Label();
            addButton = new Button();
            addHealthText = new TextBox();
            label7 = new Label();
            addInitText = new TextBox();
            label6 = new Label();
            addNameText = new TextBox();
            label5 = new Label();
            label1 = new Label();
            initText = new TextBox();
            nameText = new TextBox();
            _label1 = new Label();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            listOfCharactersGroupBox.SuspendLayout();
            dropGroupBox.SuspendLayout();
            addGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // concentrationButton
            // 
            concentrationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            concentrationButton.Location = new Point(560, 135);
            concentrationButton.Margin = new Padding(4, 3, 4, 3);
            concentrationButton.Name = "concentrationButton";
            concentrationButton.Size = new Size(266, 38);
            concentrationButton.TabIndex = 26;
            concentrationButton.Text = "Сконцентрироваться / Не";
            concentrationButton.UseVisualStyleBackColor = true;
            concentrationButton.Click += Conc_button_Click;
            // 
            // concentraionText
            // 
            concentraionText.AutoSize = true;
            concentraionText.BackColor = SystemColors.GradientInactiveCaption;
            concentraionText.Font = new Font("Noto Serif Cond", 18F, FontStyle.Bold);
            concentraionText.ForeColor = SystemColors.ControlText;
            concentraionText.Location = new Point(585, 362);
            concentraionText.Margin = new Padding(4, 0, 4, 0);
            concentraionText.Name = "concentraionText";
            concentraionText.Size = new Size(216, 33);
            concentraionText.TabIndex = 25;
            concentraionText.Text = "Концентрируется";
            concentraionText.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.AppWorkspace;
            groupBox5.Controls.Add(damageText);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(damageButton);
            groupBox5.Controls.Add(damageComboBox);
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
            // damageText
            // 
            damageText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            damageText.Location = new Point(164, 78);
            damageText.Margin = new Padding(4, 3, 4, 3);
            damageText.Name = "damageText";
            damageText.Size = new Size(156, 29);
            damageText.TabIndex = 13;
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
            // damageButton
            // 
            damageButton.Location = new Point(61, 129);
            damageButton.Margin = new Padding(4, 3, 4, 3);
            damageButton.Name = "damageButton";
            damageButton.Size = new Size(210, 46);
            damageButton.TabIndex = 6;
            damageButton.Text = "Ударить!";
            damageButton.UseVisualStyleBackColor = true;
            damageButton.Click += Damage_button_Click;
            // 
            // damageComboBox
            // 
            damageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            damageComboBox.FormattingEnabled = true;
            damageComboBox.ImeMode = ImeMode.NoControl;
            damageComboBox.Location = new Point(180, 35);
            damageComboBox.Margin = new Padding(4, 3, 4, 3);
            damageComboBox.MaxDropDownItems = 15;
            damageComboBox.Name = "damageComboBox";
            damageComboBox.Size = new Size(140, 33);
            damageComboBox.Sorted = true;
            damageComboBox.TabIndex = 6;
            damageComboBox.TabStop = false;
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
            groupBox4.Controls.Add(initChangeText);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(initChangeButton);
            groupBox4.Controls.Add(initChangeComboBox);
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
            // initChangeText
            // 
            initChangeText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            initChangeText.Location = new Point(164, 78);
            initChangeText.Margin = new Padding(4, 3, 4, 3);
            initChangeText.Name = "initChangeText";
            initChangeText.Size = new Size(156, 29);
            initChangeText.TabIndex = 13;
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
            // initChangeButton
            // 
            initChangeButton.Location = new Point(61, 129);
            initChangeButton.Margin = new Padding(4, 3, 4, 3);
            initChangeButton.Name = "initChangeButton";
            initChangeButton.Size = new Size(210, 46);
            initChangeButton.TabIndex = 6;
            initChangeButton.Text = "Изменить";
            initChangeButton.UseVisualStyleBackColor = true;
            initChangeButton.Click += Init_change_button_Click;
            // 
            // initChangeComboBox
            // 
            initChangeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            initChangeComboBox.FormattingEnabled = true;
            initChangeComboBox.ImeMode = ImeMode.NoControl;
            initChangeComboBox.Location = new Point(180, 35);
            initChangeComboBox.Margin = new Padding(4, 3, 4, 3);
            initChangeComboBox.MaxDropDownItems = 15;
            initChangeComboBox.Name = "initChangeComboBox";
            initChangeComboBox.Size = new Size(140, 33);
            initChangeComboBox.Sorted = true;
            initChangeComboBox.TabIndex = 6;
            initChangeComboBox.TabStop = false;
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
            // currentFighterLabel
            // 
            currentFighterLabel.AutoSize = true;
            currentFighterLabel.BackColor = SystemColors.InactiveCaption;
            currentFighterLabel.Font = new Font("Monotype Corsiva", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            currentFighterLabel.Location = new Point(614, 283);
            currentFighterLabel.Margin = new Padding(4, 0, 4, 0);
            currentFighterLabel.Name = "currentFighterLabel";
            currentFighterLabel.Size = new Size(157, 57);
            currentFighterLabel.TabIndex = 22;
            currentFighterLabel.Text = "Fighter";
            currentFighterLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // nextButton
            // 
            nextButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(595, 421);
            nextButton.Margin = new Padding(4, 3, 4, 3);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(205, 44);
            nextButton.TabIndex = 20;
            nextButton.Text = "Далее!";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += Next_button_Click;
            // 
            // listOfCharactersGroupBox
            // 
            listOfCharactersGroupBox.Controls.Add(_label2);
            listOfCharactersGroupBox.Controls.Add(label14);
            listOfCharactersGroupBox.Controls.Add(healthText);
            listOfCharactersGroupBox.Controls.Add(dropGroupBox);
            listOfCharactersGroupBox.Controls.Add(label3);
            listOfCharactersGroupBox.Controls.Add(addGroupBox);
            listOfCharactersGroupBox.Controls.Add(label1);
            listOfCharactersGroupBox.Controls.Add(initText);
            listOfCharactersGroupBox.Controls.Add(nameText);
            listOfCharactersGroupBox.Controls.Add(_label1);
            listOfCharactersGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            listOfCharactersGroupBox.Location = new Point(1088, 14);
            listOfCharactersGroupBox.Margin = new Padding(4, 3, 4, 3);
            listOfCharactersGroupBox.Name = "listOfCharactersGroupBox";
            listOfCharactersGroupBox.Padding = new Padding(4, 3, 4, 3);
            listOfCharactersGroupBox.Size = new Size(746, 678);
            listOfCharactersGroupBox.TabIndex = 19;
            listOfCharactersGroupBox.TabStop = false;
            listOfCharactersGroupBox.Text = "Список";
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
            // healthText
            // 
            healthText.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            healthText.Location = new Point(522, 80);
            healthText.Margin = new Padding(4, 3, 4, 3);
            healthText.Multiline = true;
            healthText.Name = "healthText";
            healthText.ReadOnly = true;
            healthText.Size = new Size(173, 136);
            healthText.TabIndex = 14;
            healthText.TabStop = false;
            healthText.TextAlign = HorizontalAlignment.Center;
            // 
            // dropGroupBox
            // 
            dropGroupBox.BackColor = SystemColors.AppWorkspace;
            dropGroupBox.Controls.Add(Delete_button);
            dropGroupBox.Controls.Add(deleteComboBox);
            dropGroupBox.Controls.Add(label12);
            dropGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            dropGroupBox.Location = new Point(364, 345);
            dropGroupBox.Margin = new Padding(4, 3, 4, 3);
            dropGroupBox.Name = "dropGroupBox";
            dropGroupBox.Padding = new Padding(4, 3, 4, 3);
            dropGroupBox.Size = new Size(223, 168);
            dropGroupBox.TabIndex = 13;
            dropGroupBox.TabStop = false;
            dropGroupBox.Text = "Удалить бойца";
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
            // deleteComboBox
            // 
            deleteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deleteComboBox.FormattingEnabled = true;
            deleteComboBox.ImeMode = ImeMode.NoControl;
            deleteComboBox.Location = new Point(71, 33);
            deleteComboBox.Margin = new Padding(4, 3, 4, 3);
            deleteComboBox.MaxDropDownItems = 15;
            deleteComboBox.Name = "deleteComboBox";
            deleteComboBox.Size = new Size(140, 33);
            deleteComboBox.Sorted = true;
            deleteComboBox.TabIndex = 6;
            deleteComboBox.TabStop = false;
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
            // addGroupBox
            // 
            addGroupBox.BackColor = SystemColors.AppWorkspace;
            addGroupBox.Controls.Add(villainCheck);
            addGroupBox.Controls.Add(heroCheck);
            addGroupBox.Controls.Add(addMaxHealthText);
            addGroupBox.Controls.Add(label8);
            addGroupBox.Controls.Add(addButton);
            addGroupBox.Controls.Add(addHealthText);
            addGroupBox.Controls.Add(label7);
            addGroupBox.Controls.Add(addInitText);
            addGroupBox.Controls.Add(label6);
            addGroupBox.Controls.Add(addNameText);
            addGroupBox.Controls.Add(label5);
            addGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            addGroupBox.Location = new Point(7, 345);
            addGroupBox.Margin = new Padding(4, 3, 4, 3);
            addGroupBox.Name = "addGroupBox";
            addGroupBox.Padding = new Padding(4, 3, 4, 3);
            addGroupBox.Size = new Size(350, 323);
            addGroupBox.TabIndex = 5;
            addGroupBox.TabStop = false;
            addGroupBox.Text = "Добавить бойца";
            // 
            // villainCheck
            // 
            villainCheck.AutoSize = true;
            villainCheck.Checked = true;
            villainCheck.Location = new Point(171, 210);
            villainCheck.Name = "villainCheck";
            villainCheck.Size = new Size(109, 29);
            villainCheck.TabIndex = 14;
            villainCheck.TabStop = true;
            villainCheck.Text = "Злодей";
            villainCheck.UseVisualStyleBackColor = true;
            // 
            // heroCheck
            // 
            heroCheck.AutoSize = true;
            heroCheck.Location = new Point(70, 210);
            heroCheck.Name = "heroCheck";
            heroCheck.Size = new Size(95, 29);
            heroCheck.TabIndex = 13;
            heroCheck.Text = "Герой";
            heroCheck.UseVisualStyleBackColor = true;
            // 
            // addMaxHealthText
            // 
            addMaxHealthText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addMaxHealthText.Location = new Point(164, 163);
            addMaxHealthText.Margin = new Padding(4, 3, 4, 3);
            addMaxHealthText.Name = "addMaxHealthText";
            addMaxHealthText.Size = new Size(156, 29);
            addMaxHealthText.TabIndex = 11;
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
            // addButton
            // 
            addButton.Location = new Point(70, 254);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(210, 46);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += Add_button_Click;
            // 
            // addHealthText
            // 
            addHealthText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addHealthText.Location = new Point(164, 121);
            addHealthText.Margin = new Padding(4, 3, 4, 3);
            addHealthText.Name = "addHealthText";
            addHealthText.Size = new Size(156, 29);
            addHealthText.TabIndex = 9;
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
            // addInitText
            // 
            addInitText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addInitText.Location = new Point(164, 78);
            addInitText.Margin = new Padding(4, 3, 4, 3);
            addInitText.Name = "addInitText";
            addInitText.Size = new Size(156, 29);
            addInitText.TabIndex = 7;
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
            // addNameText
            // 
            addNameText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addNameText.Location = new Point(164, 35);
            addNameText.Margin = new Padding(4, 3, 4, 3);
            addNameText.Name = "addNameText";
            addNameText.Size = new Size(156, 29);
            addNameText.TabIndex = 5;
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
            // initText
            // 
            initText.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            initText.Location = new Point(328, 80);
            initText.Margin = new Padding(4, 3, 4, 3);
            initText.Multiline = true;
            initText.Name = "initText";
            initText.ReadOnly = true;
            initText.Size = new Size(75, 136);
            initText.TabIndex = 3;
            initText.TabStop = false;
            initText.TextAlign = HorizontalAlignment.Center;
            // 
            // nameText
            // 
            nameText.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameText.Location = new Point(7, 80);
            nameText.Margin = new Padding(4, 3, 4, 3);
            nameText.Multiline = true;
            nameText.Name = "nameText";
            nameText.ReadOnly = true;
            nameText.Size = new Size(219, 136);
            nameText.TabIndex = 2;
            nameText.TabStop = false;
            nameText.TextAlign = HorizontalAlignment.Center;
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
            // TurnOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1848, 993);
            Controls.Add(concentrationButton);
            Controls.Add(concentraionText);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(currentFighterLabel);
            Controls.Add(label4);
            Controls.Add(nextButton);
            Controls.Add(listOfCharactersGroupBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TurnOrderForm";
            Text = "TurnOrderForm";
            Load += Turn_Order_Form_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            listOfCharactersGroupBox.ResumeLayout(false);
            listOfCharactersGroupBox.PerformLayout();
            dropGroupBox.ResumeLayout(false);
            dropGroupBox.PerformLayout();
            addGroupBox.ResumeLayout(false);
            addGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button concentrationButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox damageText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.ComboBox damageComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox initChangeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button initChangeButton;
        private System.Windows.Forms.ComboBox initChangeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label currentFighterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox listOfCharactersGroupBox;
        public System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox healthText;
        private System.Windows.Forms.GroupBox dropGroupBox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox addMaxHealthText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addHealthText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addInitText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox initText;
        public System.Windows.Forms.TextBox nameText;
        public System.Windows.Forms.Label _label1;
        private RadioButton villainCheck;
        private RadioButton heroCheck;
        public Label concentraionText;
    }
}