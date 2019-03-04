namespace Calculator
{
    partial class Calculator
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
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(9, 7);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(367, 87);
            this.resultsBox.TabIndex = 0;
            this.resultsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultsBox.TextChanged += new System.EventHandler(this.ResultsBox_TextChanged);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(100, 319);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(85, 51);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(9, 262);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(85, 51);
            this.oneBtn.TabIndex = 3;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(100, 262);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(85, 51);
            this.twoBtn.TabIndex = 4;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(191, 262);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(85, 51);
            this.threeBtn.TabIndex = 5;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(191, 148);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(85, 51);
            this.nineBtn.TabIndex = 6;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(191, 205);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(85, 51);
            this.sixBtn.TabIndex = 7;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(100, 205);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(85, 51);
            this.fiveBtn.TabIndex = 8;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(9, 205);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(85, 51);
            this.fourBtn.TabIndex = 9;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(282, 100);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(94, 42);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(9, 148);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(85, 51);
            this.sevenBtn.TabIndex = 11;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(100, 148);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(85, 51);
            this.eightBtn.TabIndex = 12;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(282, 148);
            this.subtract.Name = "subtract";
            this.subtract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subtract.Size = new System.Drawing.Size(94, 82);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(282, 236);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 77);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Button13_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(191, 319);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(185, 51);
            this.equals.TabIndex = 15;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(9, 319);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(85, 51);
            this.button15.TabIndex = 16;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(191, 100);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(85, 42);
            this.divide.TabIndex = 17;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(100, 100);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(85, 42);
            this.percent.TabIndex = 18;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.resultsBox);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button percent;
    }
}

