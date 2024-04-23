namespace Turn_Order
{
    partial class Concentration
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Yes_button = new System.Windows.Forms.Button();
            this.No_button = new System.Windows.Forms.Button();
            this.dcText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heroNameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Yes_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.No_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 376);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 60);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Yes_button
            // 
            this.Yes_button.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yes_button.Location = new System.Drawing.Point(3, 3);
            this.Yes_button.Name = "Yes_button";
            this.Yes_button.Size = new System.Drawing.Size(224, 51);
            this.Yes_button.TabIndex = 1;
            this.Yes_button.Text = "YES";
            this.Yes_button.UseVisualStyleBackColor = true;
            this.Yes_button.Click += new System.EventHandler(this.Yes_button_Click);
            // 
            // No_button
            // 
            this.No_button.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.No_button.Location = new System.Drawing.Point(233, 3);
            this.No_button.Name = "No_button";
            this.No_button.Size = new System.Drawing.Size(224, 51);
            this.No_button.TabIndex = 0;
            this.No_button.Text = "NO";
            this.No_button.UseVisualStyleBackColor = true;
            this.No_button.Click += new System.EventHandler(this.No_button_Click);
            // 
            // Dc_text
            // 
            this.dcText.AutoSize = true;
            this.dcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dcText.Location = new System.Drawing.Point(219, 63);
            this.dcText.Name = "Dc_text";
            this.dcText.Size = new System.Drawing.Size(93, 25);
            this.dcText.TabIndex = 10;
            this.dcText.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(144, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сложность проверки: ";
            // 
            // Hero_name_text
            // 
            this.heroNameText.AutoSize = true;
            this.heroNameText.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heroNameText.Location = new System.Drawing.Point(196, 158);
            this.heroNameText.Name = "Hero_name_text";
            this.heroNameText.Size = new System.Drawing.Size(79, 36);
            this.heroNameText.TabIndex = 8;
            this.heroNameText.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Чек концентрации пройден?";
            // 
            // Concentration
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dcText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heroNameText);
            this.Controls.Add(this.label1);
            this.Name = "Concentration";
            this.Text = "Concentration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Yes_button;
        private System.Windows.Forms.Button No_button;
        private System.Windows.Forms.Label dcText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label heroNameText;
        private System.Windows.Forms.Label label1;
    }
}