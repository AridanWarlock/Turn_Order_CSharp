namespace TurnOrder
{
    partial class Concentration
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Yes_button = new Button();
            No_button = new Button();
            dcText = new Label();
            label2 = new Label();
            heroNameText = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Yes_button, 0, 0);
            tableLayoutPanel1.Controls.Add(No_button, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 376);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(460, 60);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // Yes_button
            // 
            Yes_button.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Yes_button.Location = new Point(3, 3);
            Yes_button.Name = "Yes_button";
            Yes_button.Size = new Size(224, 51);
            Yes_button.TabIndex = 1;
            Yes_button.Text = "YES";
            Yes_button.UseVisualStyleBackColor = true;
            Yes_button.Click += Yes_button_Click;
            // 
            // No_button
            // 
            No_button.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            No_button.Location = new Point(233, 3);
            No_button.Name = "No_button";
            No_button.Size = new Size(224, 51);
            No_button.TabIndex = 0;
            No_button.Text = "NO";
            No_button.UseVisualStyleBackColor = true;
            No_button.Click += No_button_Click;
            // 
            // dcText
            // 
            dcText.AutoSize = true;
            dcText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            dcText.Location = new Point(219, 63);
            dcText.Name = "dcText";
            dcText.Size = new Size(93, 25);
            dcText.TabIndex = 10;
            dcText.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(144, 24);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 9;
            label2.Text = "Сложность проверки: ";
            // 
            // heroNameText
            // 
            heroNameText.AutoSize = true;
            heroNameText.Font = new Font("Monotype Corsiva", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            heroNameText.Location = new Point(196, 158);
            heroNameText.Name = "heroNameText";
            heroNameText.Size = new Size(79, 36);
            heroNameText.TabIndex = 8;
            heroNameText.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(116, 194);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 7;
            label1.Text = "Чек концентрации пройден?";
            // 
            // Concentration
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dcText);
            Controls.Add(label2);
            Controls.Add(heroNameText);
            Controls.Add(label1);
            Name = "Concentration";
            Text = "Concentration";
            Load += Concentration_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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