namespace CalculatorForm
{
    partial class CalculatorForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Key1Button = new System.Windows.Forms.Button();
            this.Key2Button = new System.Windows.Forms.Button();
            this.Key3Button = new System.Windows.Forms.Button();
            this.Key4Button = new System.Windows.Forms.Button();
            this.Key5Button = new System.Windows.Forms.Button();
            this.Key6Button = new System.Windows.Forms.Button();
            this.Key7Button = new System.Windows.Forms.Button();
            this.Key8Button = new System.Windows.Forms.Button();
            this.Key9Button = new System.Windows.Forms.Button();
            this.Key0Button = new System.Windows.Forms.Button();
            this.KeyComaButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubstractButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StringBuilderButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultTextBox.Location = new System.Drawing.Point(10, 54);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(274, 43);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // Key1Button
            // 
            this.Key1Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key1Button.Location = new System.Drawing.Point(10, 215);
            this.Key1Button.Name = "Key1Button";
            this.Key1Button.Size = new System.Drawing.Size(50, 50);
            this.Key1Button.TabIndex = 1;
            this.Key1Button.Tag = "1";
            this.Key1Button.Text = "1";
            this.Key1Button.UseVisualStyleBackColor = true;
            this.Key1Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key2Button
            // 
            this.Key2Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key2Button.Location = new System.Drawing.Point(66, 215);
            this.Key2Button.Name = "Key2Button";
            this.Key2Button.Size = new System.Drawing.Size(50, 50);
            this.Key2Button.TabIndex = 2;
            this.Key2Button.Tag = "2";
            this.Key2Button.Text = "2";
            this.Key2Button.UseVisualStyleBackColor = true;
            this.Key2Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key3Button
            // 
            this.Key3Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key3Button.Location = new System.Drawing.Point(122, 215);
            this.Key3Button.Name = "Key3Button";
            this.Key3Button.Size = new System.Drawing.Size(50, 50);
            this.Key3Button.TabIndex = 3;
            this.Key3Button.Tag = "3";
            this.Key3Button.Text = "3";
            this.Key3Button.UseVisualStyleBackColor = true;
            this.Key3Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key4Button
            // 
            this.Key4Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key4Button.Location = new System.Drawing.Point(10, 159);
            this.Key4Button.Name = "Key4Button";
            this.Key4Button.Size = new System.Drawing.Size(50, 50);
            this.Key4Button.TabIndex = 4;
            this.Key4Button.Tag = "4";
            this.Key4Button.Text = "4";
            this.Key4Button.UseVisualStyleBackColor = true;
            this.Key4Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key5Button
            // 
            this.Key5Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key5Button.Location = new System.Drawing.Point(66, 159);
            this.Key5Button.Name = "Key5Button";
            this.Key5Button.Size = new System.Drawing.Size(50, 50);
            this.Key5Button.TabIndex = 5;
            this.Key5Button.Tag = "5";
            this.Key5Button.Text = "5";
            this.Key5Button.UseVisualStyleBackColor = true;
            this.Key5Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key6Button
            // 
            this.Key6Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key6Button.Location = new System.Drawing.Point(122, 159);
            this.Key6Button.Name = "Key6Button";
            this.Key6Button.Size = new System.Drawing.Size(50, 50);
            this.Key6Button.TabIndex = 6;
            this.Key6Button.Tag = "6";
            this.Key6Button.Text = "6";
            this.Key6Button.UseVisualStyleBackColor = true;
            this.Key6Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key7Button
            // 
            this.Key7Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key7Button.Location = new System.Drawing.Point(10, 103);
            this.Key7Button.Name = "Key7Button";
            this.Key7Button.Size = new System.Drawing.Size(50, 50);
            this.Key7Button.TabIndex = 7;
            this.Key7Button.Tag = "7";
            this.Key7Button.Text = "7";
            this.Key7Button.UseVisualStyleBackColor = true;
            this.Key7Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key8Button
            // 
            this.Key8Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key8Button.Location = new System.Drawing.Point(66, 103);
            this.Key8Button.Name = "Key8Button";
            this.Key8Button.Size = new System.Drawing.Size(50, 50);
            this.Key8Button.TabIndex = 8;
            this.Key8Button.Tag = "8";
            this.Key8Button.Text = "8";
            this.Key8Button.UseVisualStyleBackColor = true;
            this.Key8Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key9Button
            // 
            this.Key9Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key9Button.Location = new System.Drawing.Point(122, 103);
            this.Key9Button.Name = "Key9Button";
            this.Key9Button.Size = new System.Drawing.Size(50, 50);
            this.Key9Button.TabIndex = 9;
            this.Key9Button.Tag = "9";
            this.Key9Button.Text = "9";
            this.Key9Button.UseVisualStyleBackColor = true;
            this.Key9Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Key0Button
            // 
            this.Key0Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Key0Button.Location = new System.Drawing.Point(10, 271);
            this.Key0Button.Name = "Key0Button";
            this.Key0Button.Size = new System.Drawing.Size(106, 50);
            this.Key0Button.TabIndex = 10;
            this.Key0Button.Tag = "0";
            this.Key0Button.Text = "0";
            this.Key0Button.UseVisualStyleBackColor = true;
            this.Key0Button.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // KeyComaButton
            // 
            this.KeyComaButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyComaButton.Location = new System.Drawing.Point(122, 271);
            this.KeyComaButton.Name = "KeyComaButton";
            this.KeyComaButton.Size = new System.Drawing.Size(50, 50);
            this.KeyComaButton.TabIndex = 11;
            this.KeyComaButton.Tag = ",";
            this.KeyComaButton.Text = ",";
            this.KeyComaButton.UseVisualStyleBackColor = true;
            this.KeyComaButton.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(178, 103);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(50, 50);
            this.DivideButton.TabIndex = 12;
            this.DivideButton.Tag = "/";
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.Location = new System.Drawing.Point(178, 159);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(50, 50);
            this.MultiplyButton.TabIndex = 13;
            this.MultiplyButton.Tag = "*";
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // SubstractButton
            // 
            this.SubstractButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubstractButton.Location = new System.Drawing.Point(178, 215);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(50, 50);
            this.SubstractButton.TabIndex = 14;
            this.SubstractButton.Tag = "-";
            this.SubstractButton.Text = "-";
            this.SubstractButton.UseVisualStyleBackColor = true;
            this.SubstractButton.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(178, 271);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 50);
            this.AddButton.TabIndex = 15;
            this.AddButton.Tag = "+";
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.Location = new System.Drawing.Point(234, 159);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(50, 162);
            this.EqualsButton.TabIndex = 16;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(234, 103);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(50, 50);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StringBuilderButton
            // 
            this.StringBuilderButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StringBuilderButton.Location = new System.Drawing.Point(10, 327);
            this.StringBuilderButton.Name = "StringBuilderButton";
            this.StringBuilderButton.Size = new System.Drawing.Size(106, 50);
            this.StringBuilderButton.TabIndex = 18;
            this.StringBuilderButton.Text = "String builder demo";
            this.StringBuilderButton.UseVisualStyleBackColor = true;
            this.StringBuilderButton.Click += new System.EventHandler(this.StringBuilderButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogBox.Location = new System.Drawing.Point(10, 5);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(274, 43);
            this.LogBox.TabIndex = 19;
            this.LogBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(296, 435);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.StringBuilderButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubstractButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.KeyComaButton);
            this.Controls.Add(this.Key0Button);
            this.Controls.Add(this.Key9Button);
            this.Controls.Add(this.Key8Button);
            this.Controls.Add(this.Key7Button);
            this.Controls.Add(this.Key6Button);
            this.Controls.Add(this.Key5Button);
            this.Controls.Add(this.Key4Button);
            this.Controls.Add(this.Key3Button);
            this.Controls.Add(this.Key2Button);
            this.Controls.Add(this.Key1Button);
            this.Controls.Add(this.ResultTextBox);
            this.Name = "CalculatorForm";
            this.Text = "Calculaor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ResultTextBox;
        private Button Key1Button;
        private Button Key2Button;
        private Button Key3Button;
        private Button Key4Button;
        private Button Key5Button;
        private Button Key6Button;
        private Button Key7Button;
        private Button Key8Button;
        private Button Key9Button;
        private Button Key0Button;
        private Button KeyComaButton;
        private Button DivideButton;
        private Button MultiplyButton;
        private Button SubstractButton;
        private Button AddButton;
        private Button EqualsButton;
        private Button ClearButton;
        private Button StringBuilderButton;
        private TextBox LogBox;
    }
}