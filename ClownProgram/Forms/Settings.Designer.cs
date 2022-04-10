
namespace ClownProgram.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeColorElementCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeColorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeColorElementCB
            // 
            this.ChangeColorElementCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeColorElementCB.FormattingEnabled = true;
            this.ChangeColorElementCB.Items.AddRange(new object[] {
            "Окно (Фон)",
            "Кнопка (Фон)",
            "Кнопка (Цвет шрифта)",
            "Кнопка (Шрифт)",
            "Разделитель (Фон)",
            "Label (Цвет шрифта)",
            "Label (Шрифт)",
            "Текстовое поле (Фон)",
            "Текстовое поле (Цвет шрифта)",
            "Текстовое поле (Шрифт)",
            "Линии графика (Цвет)"});
            this.ChangeColorElementCB.Location = new System.Drawing.Point(12, 34);
            this.ChangeColorElementCB.Name = "ChangeColorElementCB";
            this.ChangeColorElementCB.Size = new System.Drawing.Size(349, 28);
            this.ChangeColorElementCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите элемент";
            // 
            // ChangeColorBtn
            // 
            this.ChangeColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeColorBtn.Location = new System.Drawing.Point(87, 216);
            this.ChangeColorBtn.Name = "ChangeColorBtn";
            this.ChangeColorBtn.Size = new System.Drawing.Size(189, 68);
            this.ChangeColorBtn.TabIndex = 3;
            this.ChangeColorBtn.Text = "Изменить";
            this.ChangeColorBtn.UseVisualStyleBackColor = true;
            this.ChangeColorBtn.Click += new System.EventHandler(this.ChangeColorBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 296);
            this.Controls.Add(this.ChangeColorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeColorElementCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChangeColorElementCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeColorBtn;
    }
}