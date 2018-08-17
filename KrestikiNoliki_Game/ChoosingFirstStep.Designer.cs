namespace KrestikiNoliki_Game
{
    partial class ChoosingFirstStep
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
            this.ChAcceptButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonPlayer = new System.Windows.Forms.RadioButton();
            this.radioButtonMachine = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ChAcceptButton
            // 
            this.ChAcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChAcceptButton.Location = new System.Drawing.Point(109, 111);
            this.ChAcceptButton.Name = "ChAcceptButton";
            this.ChAcceptButton.Size = new System.Drawing.Size(100, 45);
            this.ChAcceptButton.TabIndex = 0;
            this.ChAcceptButton.Text = "OK";
            this.ChAcceptButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(304, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Первым ходит:";
            // 
            // radioButtonPlayer
            // 
            this.radioButtonPlayer.AutoSize = true;
            this.radioButtonPlayer.Checked = true;
            this.radioButtonPlayer.Location = new System.Drawing.Point(12, 46);
            this.radioButtonPlayer.Name = "radioButtonPlayer";
            this.radioButtonPlayer.Size = new System.Drawing.Size(197, 24);
            this.radioButtonPlayer.TabIndex = 2;
            this.radioButtonPlayer.TabStop = true;
            this.radioButtonPlayer.Text = "игрок (по умолчанию)";
            this.radioButtonPlayer.UseVisualStyleBackColor = true;
            // 
            // radioButtonMachine
            // 
            this.radioButtonMachine.AutoSize = true;
            this.radioButtonMachine.Location = new System.Drawing.Point(12, 76);
            this.radioButtonMachine.Name = "radioButtonMachine";
            this.radioButtonMachine.Size = new System.Drawing.Size(94, 24);
            this.radioButtonMachine.TabIndex = 3;
            this.radioButtonMachine.Text = "машина";
            this.radioButtonMachine.UseVisualStyleBackColor = true;
            this.radioButtonMachine.CheckedChanged += new System.EventHandler(this.radioButtonMachine_CheckedChanged);
            // 
            // ChoosingFirstStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 174);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonMachine);
            this.Controls.Add(this.radioButtonPlayer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChAcceptButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosingFirstStep";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите, кто ходит первым";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChAcceptButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonPlayer;
        private System.Windows.Forms.RadioButton radioButtonMachine;
    }
}