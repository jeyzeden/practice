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
            this.labelFife = new System.Windows.Forms.Label();
            this.labelFour = new System.Windows.Forms.Label();
            this.Coud = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
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
            this.AdditionCalculator.Location = new System.Drawing.Point(13, 185);
            this.AdditionCalculator.Name = "AdditionCalculator";
            this.AdditionCalculator.Size = new System.Drawing.Size(79, 61);
            this.AdditionCalculator.TabIndex = 2;
            this.AdditionCalculator.Text = "+";
            this.AdditionCalculator.UseVisualStyleBackColor = true;
            this.AdditionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // SubstractionCalculator
            // 
            this.SubstractionCalculator.Location = new System.Drawing.Point(98, 185);
            this.SubstractionCalculator.Name = "SubstractionCalculator";
            this.SubstractionCalculator.Size = new System.Drawing.Size(79, 61);
            this.SubstractionCalculator.TabIndex = 3;
            this.SubstractionCalculator.Text = "-";
            this.SubstractionCalculator.UseVisualStyleBackColor = true;
            this.SubstractionCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // MultiplyCalculator
            // 
            this.MultiplyCalculator.Location = new System.Drawing.Point(183, 185);
            this.MultiplyCalculator.Name = "MultiplyCalculator";
            this.MultiplyCalculator.Size = new System.Drawing.Size(79, 61);
            this.MultiplyCalculator.TabIndex = 4;
            this.MultiplyCalculator.Text = "*";
            this.MultiplyCalculator.UseVisualStyleBackColor = true;
            this.MultiplyCalculator.Click += new System.EventHandler(this.button_Click);
            // 
            // DivisionCalculator
            // 
            this.DivisionCalculator.Location = new System.Drawing.Point(268, 185);
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
            this.Sinus.Location = new System.Drawing.Point(485, 185);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(79, 61);
            this.Sinus.TabIndex = 10;
            this.Sinus.Text = "sin(x)";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(740, 185);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(79, 61);
            this.Square.TabIndex = 11;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(570, 185);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(79, 61);
            this.Cosinus.TabIndex = 12;
            this.Cosinus.Text = "cos(x)";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Tangens
            // 
            this.Tangens.Location = new System.Drawing.Point(655, 185);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(79, 61);
            this.Tangens.TabIndex = 13;
            this.Tangens.Text = "tg(x)";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(825, 185);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(79, 61);
            this.Module.TabIndex = 14;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // labelFife
            // 
            this.labelFife.AutoSize = true;
            this.labelFife.Location = new System.Drawing.Point(717, 162);
            this.labelFife.Name = "labelFife";
            this.labelFife.Size = new System.Drawing.Size(187, 20);
            this.labelFife.TabIndex = 15;
            this.labelFife.Text = "One Argument Functions";
            this.labelFife.Click += new System.EventHandler(this.labelFife_Click);
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Location = new System.Drawing.Point(12, 162);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(186, 20);
            this.labelFour.TabIndex = 16;
            this.labelFour.Text = "Two Argument Functions";
            // 
            // Coud
            // 
            this.Coud.Location = new System.Drawing.Point(485, 252);
            this.Coud.Name = "Coud";
            this.Coud.Size = new System.Drawing.Size(79, 61);
            this.Coud.TabIndex = 17;
            this.Coud.Text = "x^3";
            this.Coud.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 61);
            this.button1.TabIndex = 18;
            this.button1.Text = "ctg(x)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 61);
            this.button2.TabIndex = 19;
            this.button2.Text = "arctg(x)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 61);
            this.button3.TabIndex = 20;
            this.button3.Text = "lg(x)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(825, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 61);
            this.button4.TabIndex = 21;
            this.button4.Text = "arcsin(x)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(485, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 61);
            this.button5.TabIndex = 22;
            this.button5.Text = "1/x";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(570, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 61);
            this.button6.TabIndex = 23;
            this.button6.Text = "10^x";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(655, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 61);
            this.button7.TabIndex = 24;
            this.button7.Text = "arccos(x)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(268, 252);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 61);
            this.button8.TabIndex = 28;
            this.button8.Text = "2(x/y)";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(183, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 61);
            this.button9.TabIndex = 27;
            this.button9.Text = "2(x*y)";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(98, 252);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(79, 61);
            this.button10.TabIndex = 26;
            this.button10.Text = "2(x-y)";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(13, 252);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(79, 61);
            this.button11.TabIndex = 25;
            this.button11.Text = "2(x+y)";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(268, 319);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(79, 61);
            this.button12.TabIndex = 32;
            this.button12.Text = "x^3-y^3";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(183, 319);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 61);
            this.button13.TabIndex = 31;
            this.button13.Text = "x^3-y^3";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(98, 319);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 61);
            this.button14.TabIndex = 30;
            this.button14.Text = "(x/y)-(y/x)";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(13, 319);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(79, 61);
            this.button15.TabIndex = 29;
            this.button15.Text = "x^2-y^2";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 500);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Coud);
            this.Controls.Add(this.labelFour);
            this.Controls.Add(this.labelFife);
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
        private System.Windows.Forms.Label labelFife;
        private System.Windows.Forms.Label labelFour;
        private System.Windows.Forms.Button Coud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }
}

