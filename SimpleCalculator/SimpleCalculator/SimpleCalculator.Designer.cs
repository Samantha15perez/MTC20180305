namespace SimpleCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDivision = new System.Windows.Forms.RadioButton();
            this.ButtonMultiplication = new System.Windows.Forms.RadioButton();
            this.ButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.ButtonAddition = new System.Windows.Forms.RadioButton();
            this.TextFirstValue = new System.Windows.Forms.TextBox();
            this.TextSecondValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDivision);
            this.groupBox1.Controls.Add(this.ButtonMultiplication);
            this.groupBox1.Controls.Add(this.ButtonSubtraction);
            this.groupBox1.Controls.Add(this.ButtonAddition);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.AutoSize = true;
            this.ButtonDivision.Location = new System.Drawing.Point(7, 92);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(55, 17);
            this.ButtonDivision.TabIndex = 3;
            this.ButtonDivision.TabStop = true;
            this.ButtonDivision.Text = "Divide";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.AutoSize = true;
            this.ButtonMultiplication.Location = new System.Drawing.Point(7, 68);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(60, 17);
            this.ButtonMultiplication.TabIndex = 2;
            this.ButtonMultiplication.TabStop = true;
            this.ButtonMultiplication.Text = "Multiply";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ButtonSubtraction
            // 
            this.ButtonSubtraction.AutoSize = true;
            this.ButtonSubtraction.Location = new System.Drawing.Point(7, 44);
            this.ButtonSubtraction.Name = "ButtonSubtraction";
            this.ButtonSubtraction.Size = new System.Drawing.Size(65, 17);
            this.ButtonSubtraction.TabIndex = 1;
            this.ButtonSubtraction.TabStop = true;
            this.ButtonSubtraction.Text = "Subtract";
            this.ButtonSubtraction.UseVisualStyleBackColor = true;
            this.ButtonSubtraction.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.AutoSize = true;
            this.ButtonAddition.Location = new System.Drawing.Point(7, 20);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(44, 17);
            this.ButtonAddition.TabIndex = 0;
            this.ButtonAddition.TabStop = true;
            this.ButtonAddition.Text = "Add";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TextFirstValue
            // 
            this.TextFirstValue.Location = new System.Drawing.Point(112, 32);
            this.TextFirstValue.Name = "TextFirstValue";
            this.TextFirstValue.Size = new System.Drawing.Size(82, 20);
            this.TextFirstValue.TabIndex = 1;
            this.TextFirstValue.TextChanged += new System.EventHandler(this.FirstValue_TextChanged);
            // 
            // TextSecondValue
            // 
            this.TextSecondValue.Location = new System.Drawing.Point(112, 73);
            this.TextSecondValue.Name = "TextSecondValue";
            this.TextSecondValue.Size = new System.Drawing.Size(82, 20);
            this.TextSecondValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Value";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(116, 99);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(67, 37);
            this.ButtonCalculate.TabIndex = 4;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(203, 55);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(82, 20);
            this.ResultBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSecondValue);
            this.Controls.Add(this.TextFirstValue);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ButtonDivision;
        private System.Windows.Forms.RadioButton ButtonMultiplication;
        private System.Windows.Forms.RadioButton ButtonSubtraction;
        private System.Windows.Forms.RadioButton ButtonAddition;
        private System.Windows.Forms.TextBox TextFirstValue;
        private System.Windows.Forms.TextBox TextSecondValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label3;
    }
}

