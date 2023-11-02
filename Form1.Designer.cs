namespace WinFormsApp12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            OpenForm2Button = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(268, 135);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 0;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(268, 191);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(150, 27);
            ageNumericUpDown.TabIndex = 1;
            // 
            // OpenForm2Button
            // 
            OpenForm2Button.Location = new Point(268, 262);
            OpenForm2Button.Name = "OpenForm2Button";
            OpenForm2Button.Size = new Size(94, 29);
            OpenForm2Button.TabIndex = 2;
            OpenForm2Button.Text = "button1";
            OpenForm2Button.UseVisualStyleBackColor = true;
            OpenForm2Button.Click += OpenForm2Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenForm2Button);
            Controls.Add(ageNumericUpDown);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private NumericUpDown ageNumericUpDown;
        private Button OpenForm2Button;
    }
}