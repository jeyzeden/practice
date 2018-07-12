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
            this.Addition = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
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
            this.SubstractionSquare = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.MultiplySquare = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.MultiplyCube = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.DivisionSquare = new System.Windows.Forms.Button();
            this.AdditionSquare = new System.Windows.Forms.Button();
            this.DivisionCube = new System.Windows.Forms.Button();
            this.AdditionCube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(8, 8);
            this.textNumber1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(177, 20);
            this.textNumber1.TabIndex = 0;
            this.textNumber1.TextChanged += new System.EventHandler(this.textNumber1_TextChanged);
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(8, 29);
            this.textNumber2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(177, 20);
            this.textNumber2.TabIndex = 1;
            this.textNumber2.TextChanged += new System.EventHandler(this.textNumber2_TextChanged);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(8, 99);
            this.Addition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(53, 40);
            this.Addition.TabIndex = 2;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.button_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(65, 99);
            this.Substraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(53, 40);
            this.Substraction.TabIndex = 3;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.button_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(8, 143);
            this.Multiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(53, 40);
            this.Multiply.TabIndex = 4;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.button_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(65, 143);
            this.Division.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(53, 40);
            this.Division.TabIndex = 5;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(8, 50);
            this.textResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(177, 20);
            this.textResult.TabIndex = 6;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(187, 8);
            this.labelOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(65, 13);
            this.labelOne.TabIndex = 7;
            this.labelOne.Text = "Number one";
            this.labelOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(187, 29);
            this.labelTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(64, 13);
            this.labelTwo.TabIndex = 8;
            this.labelTwo.Text = "Number two";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(187, 50);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Result";
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(8, 200);
            this.Sinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(53, 40);
            this.Sinus.TabIndex = 10;
            this.Sinus.Text = "sin(x)";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(65, 243);
            this.Square.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(53, 40);
            this.Square.TabIndex = 11;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(65, 200);
            this.Cosinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(53, 40);
            this.Cosinus.TabIndex = 12;
            this.Cosinus.Text = "cos(x)";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Tangens
            // 
            this.Tangens.Location = new System.Drawing.Point(8, 243);
            this.Tangens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(53, 40);
            this.Tangens.TabIndex = 13;
            this.Tangens.Text = "tg(x)";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // labelFife
            // 
            this.labelFife.AutoSize = true;
            this.labelFife.Location = new System.Drawing.Point(8, 185);
            this.labelFife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFife.Name = "labelFife";
            this.labelFife.Size = new System.Drawing.Size(124, 13);
            this.labelFife.TabIndex = 15;
            this.labelFife.Text = "One Argument Functions";
            this.labelFife.Click += new System.EventHandler(this.labelFife_Click);
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Location = new System.Drawing.Point(8, 84);
            this.labelFour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(125, 13);
            this.labelFour.TabIndex = 16;
            this.labelFour.Text = "Two Argument Functions";
            // 
            // TwoExp
            // 
            this.TwoExp.Location = new System.Drawing.Point(246, 243);
            this.TwoExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TwoExp.Name = "TwoExp";
            this.TwoExp.Size = new System.Drawing.Size(53, 40);
            this.TwoExp.TabIndex = 20;
            this.TwoExp.Text = "2^x";
            this.TwoExp.UseVisualStyleBackColor = true;
            this.TwoExp.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(189, 243);
            this.Arcsin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(53, 40);
            this.Arcsin.TabIndex = 19;
            this.Arcsin.Text = "asin(x)";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Arctg
            // 
            this.Arctg.Location = new System.Drawing.Point(246, 200);
            this.Arctg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Arctg.Name = "Arctg";
            this.Arctg.Size = new System.Drawing.Size(53, 40);
            this.Arctg.TabIndex = 18;
            this.Arctg.Text = "atg(x)";
            this.Arctg.UseVisualStyleBackColor = true;
            this.Arctg.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(189, 200);
            this.Arccos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(53, 40);
            this.Arccos.TabIndex = 17;
            this.Arccos.Text = "acos(x)";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(359, 243);
            this.Exp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(53, 40);
            this.Exp.TabIndex = 24;
            this.Exp.Text = "e^x";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(302, 243);
            this.Module.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(53, 40);
            this.Module.TabIndex = 23;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(359, 200);
            this.Ln.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(53, 40);
            this.Ln.TabIndex = 22;
            this.Ln.Text = "ln(x)";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // TenExp
            // 
            this.TenExp.Location = new System.Drawing.Point(302, 200);
            this.TenExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TenExp.Name = "TenExp";
            this.TenExp.Size = new System.Drawing.Size(53, 40);
            this.TenExp.TabIndex = 21;
            this.TenExp.Text = "10^x";
            this.TenExp.UseVisualStyleBackColor = true;
            this.TenExp.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(416, 243);
            this.Cube.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(53, 40);
            this.Cube.TabIndex = 26;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(416, 200);
            this.Fraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(53, 40);
            this.Fraction.TabIndex = 25;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // SubstractionSquare
            // 
            this.SubstractionSquare.Location = new System.Drawing.Point(416, 143);
            this.SubstractionSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubstractionSquare.Name = "SubstractionSquare";
            this.SubstractionSquare.Size = new System.Drawing.Size(53, 40);
            this.SubstractionSquare.TabIndex = 36;
            this.SubstractionSquare.Text = "x^2-y^2";
            this.SubstractionSquare.UseVisualStyleBackColor = true;
            this.SubstractionSquare.Click += new System.EventHandler(this.button_Click);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(416, 99);
            this.Pow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(53, 40);
            this.Pow.TabIndex = 35;
            this.Pow.Text = "x^y";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.button_Click);
            // 
            // MultiplySquare
            // 
            this.MultiplySquare.Location = new System.Drawing.Point(359, 143);
            this.MultiplySquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiplySquare.Name = "MultiplySquare";
            this.MultiplySquare.Size = new System.Drawing.Size(53, 40);
            this.MultiplySquare.TabIndex = 34;
            this.MultiplySquare.Text = "x^2*y^2";
            this.MultiplySquare.UseVisualStyleBackColor = true;
            this.MultiplySquare.Click += new System.EventHandler(this.button_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(302, 143);
            this.Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(53, 40);
            this.Min.TabIndex = 33;
            this.Min.Text = "min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.button_Click);
            // 
            // MultiplyCube
            // 
            this.MultiplyCube.Location = new System.Drawing.Point(359, 99);
            this.MultiplyCube.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiplyCube.Name = "MultiplyCube";
            this.MultiplyCube.Size = new System.Drawing.Size(53, 40);
            this.MultiplyCube.TabIndex = 32;
            this.MultiplyCube.Text = "x^3*y^3";
            this.MultiplyCube.UseVisualStyleBackColor = true;
            this.MultiplyCube.Click += new System.EventHandler(this.button_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(302, 99);
            this.Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(53, 40);
            this.Max.TabIndex = 31;
            this.Max.Text = "max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.button_Click);
            // 
            // DivisionSquare
            // 
            this.DivisionSquare.Location = new System.Drawing.Point(246, 143);
            this.DivisionSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DivisionSquare.Name = "DivisionSquare";
            this.DivisionSquare.Size = new System.Drawing.Size(53, 40);
            this.DivisionSquare.TabIndex = 30;
            this.DivisionSquare.Text = "x^2/y^2";
            this.DivisionSquare.UseVisualStyleBackColor = true;
            this.DivisionSquare.Click += new System.EventHandler(this.button_Click);
            // 
            // AdditionSquare
            // 
            this.AdditionSquare.Location = new System.Drawing.Point(189, 143);
            this.AdditionSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdditionSquare.Name = "AdditionSquare";
            this.AdditionSquare.Size = new System.Drawing.Size(53, 40);
            this.AdditionSquare.TabIndex = 29;
            this.AdditionSquare.Text = "x^2+y^2";
            this.AdditionSquare.UseVisualStyleBackColor = true;
            this.AdditionSquare.Click += new System.EventHandler(this.button_Click);
            // 
            // DivisionCube
            // 
            this.DivisionCube.Location = new System.Drawing.Point(246, 99);
            this.DivisionCube.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DivisionCube.Name = "DivisionCube";
            this.DivisionCube.Size = new System.Drawing.Size(53, 40);
            this.DivisionCube.TabIndex = 28;
            this.DivisionCube.Text = "x^3/y^3";
            this.DivisionCube.UseVisualStyleBackColor = true;
            this.DivisionCube.Click += new System.EventHandler(this.button_Click);
            // 
            // AdditionCube
            // 
            this.AdditionCube.Location = new System.Drawing.Point(189, 99);
            this.AdditionCube.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdditionCube.Name = "AdditionCube";
            this.AdditionCube.Size = new System.Drawing.Size(53, 40);
            this.AdditionCube.TabIndex = 27;
            this.AdditionCube.Text = "x^3+y^3";
            this.AdditionCube.UseVisualStyleBackColor = true;
            this.AdditionCube.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.SubstractionSquare);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.MultiplySquare);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.MultiplyCube);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.DivisionSquare);
            this.Controls.Add(this.AdditionSquare);
            this.Controls.Add(this.DivisionCube);
            this.Controls.Add(this.AdditionCube);
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
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
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
        private System.Windows.Forms.Button SubstractionSquare;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button MultiplySquare;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button MultiplyCube;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button DivisionSquare;
        private System.Windows.Forms.Button AdditionSquare;
        private System.Windows.Forms.Button DivisionCube;
        private System.Windows.Forms.Button AdditionCube;
    }
}

