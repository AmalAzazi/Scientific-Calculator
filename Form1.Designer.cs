namespace calculator
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sqrt = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.power2 = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.Sinh = new System.Windows.Forms.Button();
            this.Cosh = new System.Windows.Forms.Button();
            this.tanh = new System.Windows.Forms.Button();
            this.absolute = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.power10 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.inversesin = new System.Windows.Forms.Button();
            this.inversecos = new System.Windows.Forms.Button();
            this.inversetan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(229, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(329, 22);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 23);
            this.subtract.TabIndex = 1;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(229, 65);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.button3_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(329, 65);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 3;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button4_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(473, 355);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Second No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result:";
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(229, 110);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 23);
            this.sqrt.TabIndex = 11;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.button5_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(329, 152);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(75, 23);
            this.power.TabIndex = 12;
            this.power.Text = "x^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.button6_Click);
            // 
            // power2
            // 
            this.power2.Location = new System.Drawing.Point(229, 152);
            this.power2.Name = "power2";
            this.power2.Size = new System.Drawing.Size(75, 23);
            this.power2.TabIndex = 13;
            this.power2.Text = "x^2";
            this.power2.UseVisualStyleBackColor = true;
            this.power2.Click += new System.EventHandler(this.button7_Click);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(329, 110);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 14;
            this.root.Text = "^√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.button8_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(427, 22);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 15;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.button9_Click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(427, 65);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 16;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.button10_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(427, 110);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 17;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.button11_Click);
            // 
            // Sinh
            // 
            this.Sinh.Location = new System.Drawing.Point(528, 22);
            this.Sinh.Name = "Sinh";
            this.Sinh.Size = new System.Drawing.Size(75, 23);
            this.Sinh.TabIndex = 18;
            this.Sinh.Text = "Sinh";
            this.Sinh.UseVisualStyleBackColor = true;
            this.Sinh.Click += new System.EventHandler(this.button12_Click);
            // 
            // Cosh
            // 
            this.Cosh.Location = new System.Drawing.Point(528, 65);
            this.Cosh.Name = "Cosh";
            this.Cosh.Size = new System.Drawing.Size(75, 23);
            this.Cosh.TabIndex = 19;
            this.Cosh.Text = "Cosh";
            this.Cosh.UseVisualStyleBackColor = true;
            this.Cosh.Click += new System.EventHandler(this.button13_Click);
            // 
            // tanh
            // 
            this.tanh.Location = new System.Drawing.Point(528, 110);
            this.tanh.Name = "tanh";
            this.tanh.Size = new System.Drawing.Size(75, 23);
            this.tanh.TabIndex = 20;
            this.tanh.Text = "tanh";
            this.tanh.UseVisualStyleBackColor = true;
            this.tanh.Click += new System.EventHandler(this.button14_Click);
            // 
            // absolute
            // 
            this.absolute.Location = new System.Drawing.Point(528, 191);
            this.absolute.Name = "absolute";
            this.absolute.Size = new System.Drawing.Size(75, 23);
            this.absolute.TabIndex = 21;
            this.absolute.Text = "Abs";
            this.absolute.UseVisualStyleBackColor = true;
            this.absolute.Click += new System.EventHandler(this.button15_Click);
            // 
            // inverse
            // 
            this.inverse.Location = new System.Drawing.Point(229, 191);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(75, 23);
            this.inverse.TabIndex = 22;
            this.inverse.Text = "x^-1";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.button16_Click);
            // 
            // percentage
            // 
            this.percentage.Location = new System.Drawing.Point(528, 152);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(75, 23);
            this.percentage.TabIndex = 23;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = true;
            this.percentage.Click += new System.EventHandler(this.button17_Click);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(329, 191);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(75, 23);
            this.factorial.TabIndex = 24;
            this.factorial.Text = "X!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.button18_Click);
            // 
            // power10
            // 
            this.power10.Location = new System.Drawing.Point(329, 237);
            this.power10.Name = "power10";
            this.power10.Size = new System.Drawing.Size(75, 23);
            this.power10.TabIndex = 25;
            this.power10.Text = "10^";
            this.power10.UseVisualStyleBackColor = true;
            this.power10.Click += new System.EventHandler(this.button19_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(229, 237);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 26;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.button20_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(338, 355);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 27;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button21_Click);
            // 
            // inversesin
            // 
            this.inversesin.Location = new System.Drawing.Point(427, 152);
            this.inversesin.Name = "inversesin";
            this.inversesin.Size = new System.Drawing.Size(75, 23);
            this.inversesin.TabIndex = 28;
            this.inversesin.Text = "sin^-1";
            this.inversesin.UseVisualStyleBackColor = true;
            this.inversesin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // inversecos
            // 
            this.inversecos.Location = new System.Drawing.Point(427, 191);
            this.inversecos.Name = "inversecos";
            this.inversecos.Size = new System.Drawing.Size(75, 23);
            this.inversecos.TabIndex = 29;
            this.inversecos.Text = "cos^-1";
            this.inversecos.UseVisualStyleBackColor = true;
            this.inversecos.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // inversetan
            // 
            this.inversetan.Location = new System.Drawing.Point(427, 237);
            this.inversetan.Name = "inversetan";
            this.inversetan.Size = new System.Drawing.Size(75, 23);
            this.inversetan.TabIndex = 30;
            this.inversetan.Text = "tan^-1";
            this.inversetan.UseVisualStyleBackColor = true;
            this.inversetan.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 390);
            this.Controls.Add(this.inversetan);
            this.Controls.Add(this.inversecos);
            this.Controls.Add(this.inversesin);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.log);
            this.Controls.Add(this.power10);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.absolute);
            this.Controls.Add(this.tanh);
            this.Controls.Add(this.Cosh);
            this.Controls.Add(this.Sinh);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.root);
            this.Controls.Add(this.power2);
            this.Controls.Add(this.power);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button power2;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button Sinh;
        private System.Windows.Forms.Button Cosh;
        private System.Windows.Forms.Button tanh;
        private System.Windows.Forms.Button absolute;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button power10;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button inversesin;
        private System.Windows.Forms.Button inversecos;
        private System.Windows.Forms.Button inversetan;
    }
}

