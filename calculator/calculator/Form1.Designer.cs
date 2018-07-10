namespace calculator
{
    partial class Form1
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
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.AdditionCalculator = new System.Windows.Forms.Button();
            this.SubstractionCalculator = new System.Windows.Forms.Button();
            this.MultiplyCalculator = new System.Windows.Forms.Button();
            this.DivisionCalculator = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(13, 13);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(263, 26);
            this.textNumber1.TabIndex = 0;
            this.textNumber1.TextChanged += new System.EventHandler(this.textNumber1_TextChanged);
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(345, 12);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(263, 26);
            this.textNumber2.TabIndex = 1;
            this.textNumber2.TextChanged += new System.EventHandler(this.textNumber2_TextChanged);
            // 
            // AdditionCalculator
            // 
            this.AdditionCalculator.Location = new System.Drawing.Point(13, 107);
            this.AdditionCalculator.Name = "AdditionCalculator";
            this.AdditionCalculator.Size = new System.Drawing.Size(79, 61);
            this.AdditionCalculator.TabIndex = 2;
            this.AdditionCalculator.Text = "+";
            this.AdditionCalculator.UseVisualStyleBackColor = true;
            this.AdditionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // SubstractionCalculator
            // 
            this.SubstractionCalculator.Location = new System.Drawing.Point(197, 107);
            this.SubstractionCalculator.Name = "SubstractionCalculator";
            this.SubstractionCalculator.Size = new System.Drawing.Size(79, 61);
            this.SubstractionCalculator.TabIndex = 3;
            this.SubstractionCalculator.Text = "-";
            this.SubstractionCalculator.UseVisualStyleBackColor = true;
            this.SubstractionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // MultiplyCalculator
            // 
            this.MultiplyCalculator.Location = new System.Drawing.Point(345, 107);
            this.MultiplyCalculator.Name = "MultiplyCalculator";
            this.MultiplyCalculator.Size = new System.Drawing.Size(79, 61);
            this.MultiplyCalculator.TabIndex = 4;
            this.MultiplyCalculator.Text = "*";
            this.MultiplyCalculator.UseVisualStyleBackColor = true;
            this.MultiplyCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // DivisionCalculator
            // 
            this.DivisionCalculator.Location = new System.Drawing.Point(529, 107);
            this.DivisionCalculator.Name = "DivisionCalculator";
            this.DivisionCalculator.Size = new System.Drawing.Size(79, 61);
            this.DivisionCalculator.TabIndex = 5;
            this.DivisionCalculator.Text = "/";
            this.DivisionCalculator.UseVisualStyleBackColor = true;
            this.DivisionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(179, 55);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(263, 26);
            this.textResult.TabIndex = 6;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 226);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.DivisionCalculator);
            this.Controls.Add(this.MultiplyCalculator);
            this.Controls.Add(this.SubstractionCalculator);
            this.Controls.Add(this.AdditionCalculator);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.Button AdditionCalculator;
        private System.Windows.Forms.Button SubstractionCalculator;
        private System.Windows.Forms.Button MultiplyCalculator;
        private System.Windows.Forms.Button DivisionCalculator;
        private System.Windows.Forms.TextBox textResult;
    }
}

