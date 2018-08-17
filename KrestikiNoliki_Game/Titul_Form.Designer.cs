namespace KrestikiNoliki_Game
{
    partial class Titul_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titul_Form));
            this.NameOfWork_label = new System.Windows.Forms.Label();
            this.Inform_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameOfWork_label
            // 
            this.NameOfWork_label.AutoSize = true;
            this.NameOfWork_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfWork_label.Location = new System.Drawing.Point(2, 6);
            this.NameOfWork_label.Name = "NameOfWork_label";
            this.NameOfWork_label.Size = new System.Drawing.Size(315, 40);
            this.NameOfWork_label.TabIndex = 0;
            this.NameOfWork_label.Text = "Курсовая работа\r\n\"Создание игры \"Крестики-нолики\"\"";
            this.NameOfWork_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inform_label
            // 
            this.Inform_label.AutoSize = true;
            this.Inform_label.Location = new System.Drawing.Point(0, 56);
            this.Inform_label.Name = "Inform_label";
            this.Inform_label.Size = new System.Drawing.Size(316, 180);
            this.Inform_label.TabIndex = 1;
            this.Inform_label.Text = resources.GetString("Inform_label.Text");
            this.Inform_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titul_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 244);
            this.Controls.Add(this.Inform_label);
            this.Controls.Add(this.NameOfWork_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Titul_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfWork_label;
        private System.Windows.Forms.Label Inform_label;
    }
}