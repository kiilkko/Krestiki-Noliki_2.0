namespace KrestikiNoliki_Game
{
    partial class GameInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInfo));
            this.RulesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RulesRichTextBox
            // 
            this.RulesRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.RulesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RulesRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RulesRichTextBox.Location = new System.Drawing.Point(11, 11);
            this.RulesRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RulesRichTextBox.Name = "RulesRichTextBox";
            this.RulesRichTextBox.ReadOnly = true;
            this.RulesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RulesRichTextBox.Size = new System.Drawing.Size(284, 147);
            this.RulesRichTextBox.TabIndex = 0;
            this.RulesRichTextBox.Text = resources.GetString("RulesRichTextBox.Text");
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 104);
            this.Controls.Add(this.RulesRichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Правила игры";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RulesRichTextBox;
    }
}