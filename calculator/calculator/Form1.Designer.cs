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
            this.labelFife = new System.Windows.Forms.Label();
            this.labelFour = new System.Windows.Forms.Label();
            this.TwoExp = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arctg = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.TenExp = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(12, 13);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(263, 26);
            this.textNumber1.TabIndex = 0;
            this.textNumber1.TextChanged += new System.EventHandler(this.textNumber1_TextChanged);
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(12, 45);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(263, 26);
            this.textNumber2.TabIndex = 1;
            this.textNumber2.TextChanged += new System.EventHandler(this.textNumber2_TextChanged);
            // 
            // AdditionCalculator
            // 
            this.AdditionCalculator.Location = new System.Drawing.Point(12, 153);
            this.AdditionCalculator.Name = "AdditionCalculator";
            this.AdditionCalculator.Size = new System.Drawing.Size(79, 61);
            this.AdditionCalculator.TabIndex = 2;
            this.AdditionCalculator.Text = "+";
            this.AdditionCalculator.UseVisualStyleBackColor = true;
            this.AdditionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // SubstractionCalculator
            // 
            this.SubstractionCalculator.Location = new System.Drawing.Point(97, 153);
            this.SubstractionCalculator.Name = "SubstractionCalculator";
            this.SubstractionCalculator.Size = new System.Drawing.Size(79, 61);
            this.SubstractionCalculator.TabIndex = 3;
            this.SubstractionCalculator.Text = "-";
            this.SubstractionCalculator.UseVisualStyleBackColor = true;
            this.SubstractionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // MultiplyCalculator
            // 
            this.MultiplyCalculator.Location = new System.Drawing.Point(12, 220);
            this.MultiplyCalculator.Name = "MultiplyCalculator";
            this.MultiplyCalculator.Size = new System.Drawing.Size(79, 61);
            this.MultiplyCalculator.TabIndex = 4;
            this.MultiplyCalculator.Text = "*";
            this.MultiplyCalculator.UseVisualStyleBackColor = true;
            this.MultiplyCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // DivisionCalculator
            // 
            this.DivisionCalculator.Location = new System.Drawing.Point(97, 220);
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
            this.labelOne.Location = new System.Drawing.Point(281, 13);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(96, 20);
            this.labelOne.TabIndex = 7;
            this.labelOne.Text = "Number one";
            this.labelOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(281, 45);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(94, 20);
            this.labelTwo.TabIndex = 8;
            this.labelTwo.Text = "Number two";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(281, 77);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Result";
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(12, 307);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(79, 61);
            this.Sinus.TabIndex = 10;
            this.Sinus.Text = "sin(x)";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(97, 374);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(79, 61);
            this.Square.TabIndex = 11;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(97, 307);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(79, 61);
            this.Cosinus.TabIndex = 12;
            this.Cosinus.Text = "cos(x)";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Tangens
            // 
            this.Tangens.Location = new System.Drawing.Point(12, 374);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(79, 61);
            this.Tangens.TabIndex = 13;
            this.Tangens.Text = "tg(x)";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // labelFife
            // 
            this.labelFife.AutoSize = true;
            this.labelFife.Location = new System.Drawing.Point(12, 284);
            this.labelFife.Name = "labelFife";
            this.labelFife.Size = new System.Drawing.Size(187, 20);
            this.labelFife.TabIndex = 15;
            this.labelFife.Text = "One Argument Functions";
            this.labelFife.Click += new System.EventHandler(this.labelFife_Click);
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Location = new System.Drawing.Point(12, 130);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(186, 20);
            this.labelFour.TabIndex = 16;
            this.labelFour.Text = "Two Argument Functions";
            // 
            // TwoExp
            // 
            this.TwoExp.Location = new System.Drawing.Point(370, 374);
            this.TwoExp.Name = "TwoExp";
            this.TwoExp.Size = new System.Drawing.Size(79, 61);
            this.TwoExp.TabIndex = 20;
            this.TwoExp.Text = "2^x";
            this.TwoExp.UseVisualStyleBackColor = true;
            this.TwoExp.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(285, 374);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(79, 61);
            this.Arcsin.TabIndex = 19;
            this.Arcsin.Text = "asin(x)";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Arctg
            // 
            this.Arctg.Location = new System.Drawing.Point(370, 307);
            this.Arctg.Name = "Arctg";
            this.Arctg.Size = new System.Drawing.Size(79, 61);
            this.Arctg.TabIndex = 18;
            this.Arctg.Text = "atg(x)";
            this.Arctg.UseVisualStyleBackColor = true;
            this.Arctg.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(285, 307);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(79, 61);
            this.Arccos.TabIndex = 17;
            this.Arccos.Text = "acos(x)";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(540, 374);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(79, 61);
            this.Exp.TabIndex = 24;
            this.Exp.Text = "e^x";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(455, 374);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(79, 61);
            this.Module.TabIndex = 23;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(540, 307);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(79, 61);
            this.Ln.TabIndex = 22;
            this.Ln.Text = "ln(x)";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // TenExp
            // 
            this.TenExp.Location = new System.Drawing.Point(455, 307);
            this.TenExp.Name = "TenExp";
            this.TenExp.Size = new System.Drawing.Size(79, 61);
            this.TenExp.TabIndex = 21;
            this.TenExp.Text = "10^x";
            this.TenExp.UseVisualStyleBackColor = true;
            this.TenExp.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(625, 374);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(79, 61);
            this.Cube.TabIndex = 26;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(625, 307);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(79, 61);
            this.Fraction.TabIndex = 25;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 471);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.TenExp);
            this.Controls.Add(this.TwoExp);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Arctg);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.labelFour);
            this.Controls.Add(this.labelFife);
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
        private System.Windows.Forms.Label labelFife;
        private System.Windows.Forms.Label labelFour;
        private System.Windows.Forms.Button TwoExp;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arctg;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button TenExp;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Fraction;
    }
}

