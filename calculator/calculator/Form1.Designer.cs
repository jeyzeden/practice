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
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.Sinus = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Tangens = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
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
            this.textNumber2.Location = new System.Drawing.Point(13, 45);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(263, 26);
            this.textNumber2.TabIndex = 1;
            this.textNumber2.TextChanged += new System.EventHandler(this.textNumber2_TextChanged);
            // 
            // AdditionCalculator
            // 
            this.AdditionCalculator.Location = new System.Drawing.Point(12, 135);
            this.AdditionCalculator.Name = "AdditionCalculator";
            this.AdditionCalculator.Size = new System.Drawing.Size(79, 61);
            this.AdditionCalculator.TabIndex = 2;
            this.AdditionCalculator.Text = "+";
            this.AdditionCalculator.UseVisualStyleBackColor = true;
            this.AdditionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // SubstractionCalculator
            // 
            this.SubstractionCalculator.Location = new System.Drawing.Point(97, 135);
            this.SubstractionCalculator.Name = "SubstractionCalculator";
            this.SubstractionCalculator.Size = new System.Drawing.Size(79, 61);
            this.SubstractionCalculator.TabIndex = 3;
            this.SubstractionCalculator.Text = "-";
            this.SubstractionCalculator.UseVisualStyleBackColor = true;
            this.SubstractionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // MultiplyCalculator
            // 
            this.MultiplyCalculator.Location = new System.Drawing.Point(13, 202);
            this.MultiplyCalculator.Name = "MultiplyCalculator";
            this.MultiplyCalculator.Size = new System.Drawing.Size(79, 61);
            this.MultiplyCalculator.TabIndex = 4;
            this.MultiplyCalculator.Text = "*";
            this.MultiplyCalculator.UseVisualStyleBackColor = true;
            this.MultiplyCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // DivisionCalculator
            // 
            this.DivisionCalculator.Location = new System.Drawing.Point(97, 202);
            this.DivisionCalculator.Name = "DivisionCalculator";
            this.DivisionCalculator.Size = new System.Drawing.Size(79, 61);
            this.DivisionCalculator.TabIndex = 5;
            this.DivisionCalculator.Text = "/";
            this.DivisionCalculator.UseVisualStyleBackColor = true;
            this.DivisionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(12, 77);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(263, 26);
            this.textResult.TabIndex = 6;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(295, 13);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(96, 20);
            this.labelOne.TabIndex = 7;
            this.labelOne.Text = "Number one";
            this.labelOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(295, 45);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(94, 20);
            this.labelTwo.TabIndex = 8;
            this.labelTwo.Text = "Number two";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(295, 77);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Result";
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(359, 202);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(79, 61);
            this.Sinus.TabIndex = 10;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(444, 135);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(79, 61);
            this.Square.TabIndex = 11;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(444, 202);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(79, 61);
            this.Cosinus.TabIndex = 12;
            this.Cosinus.Text = "cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Tangens
            // 
            this.Tangens.Location = new System.Drawing.Point(529, 202);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(79, 61);
            this.Tangens.TabIndex = 13;
            this.Tangens.Text = "tg";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(529, 135);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(79, 61);
            this.Module.TabIndex = 14;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 356);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Tangens);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
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
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Tangens;
        private System.Windows.Forms.Button Module;
    }
}

