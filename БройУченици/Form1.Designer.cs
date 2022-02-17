
namespace БройУченици
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
            this.radioButton_Girls = new System.Windows.Forms.RadioButton();
            this.radioButtonBoys = new System.Windows.Forms.RadioButton();
            this.radioButtonTotal = new System.Windows.Forms.RadioButton();
            this.checkBox_8a = new System.Windows.Forms.CheckBox();
            this.checkBox_8b = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girls8a_textBox = new System.Windows.Forms.TextBox();
            this.girls8b_textBox = new System.Windows.Forms.TextBox();
            this.boys8a_textBox = new System.Windows.Forms.TextBox();
            this.boys8b_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_Girls
            // 
            this.radioButton_Girls.AutoSize = true;
            this.radioButton_Girls.Location = new System.Drawing.Point(12, 32);
            this.radioButton_Girls.Name = "radioButton_Girls";
            this.radioButton_Girls.Size = new System.Drawing.Size(96, 21);
            this.radioButton_Girls.TabIndex = 0;
            this.radioButton_Girls.TabStop = true;
            this.radioButton_Girls.Text = "Момичета";
            this.radioButton_Girls.UseVisualStyleBackColor = true;
            // 
            // radioButtonBoys
            // 
            this.radioButtonBoys.AutoSize = true;
            this.radioButtonBoys.Location = new System.Drawing.Point(123, 32);
            this.radioButtonBoys.Name = "radioButtonBoys";
            this.radioButtonBoys.Size = new System.Drawing.Size(88, 21);
            this.radioButtonBoys.TabIndex = 1;
            this.radioButtonBoys.TabStop = true;
            this.radioButtonBoys.Text = "Момчета";
            this.radioButtonBoys.UseVisualStyleBackColor = true;
            this.radioButtonBoys.CheckedChanged += new System.EventHandler(this.radioButtonBoys_CheckedChanged);
            // 
            // radioButtonTotal
            // 
            this.radioButtonTotal.AutoSize = true;
            this.radioButtonTotal.Location = new System.Drawing.Point(249, 32);
            this.radioButtonTotal.Name = "radioButtonTotal";
            this.radioButtonTotal.Size = new System.Drawing.Size(67, 21);
            this.radioButtonTotal.TabIndex = 2;
            this.radioButtonTotal.TabStop = true;
            this.radioButtonTotal.Text = "Общо";
            this.radioButtonTotal.UseVisualStyleBackColor = true;
            // 
            // checkBox_8a
            // 
            this.checkBox_8a.AutoSize = true;
            this.checkBox_8a.Location = new System.Drawing.Point(12, 131);
            this.checkBox_8a.Name = "checkBox_8a";
            this.checkBox_8a.Size = new System.Drawing.Size(80, 21);
            this.checkBox_8a.TabIndex = 3;
            this.checkBox_8a.Text = "8а клас";
            this.checkBox_8a.UseVisualStyleBackColor = true;
            // 
            // checkBox_8b
            // 
            this.checkBox_8b.AutoSize = true;
            this.checkBox_8b.Location = new System.Drawing.Point(12, 158);
            this.checkBox_8b.Name = "checkBox_8b";
            this.checkBox_8b.Size = new System.Drawing.Size(80, 21);
            this.checkBox_8b.TabIndex = 4;
            this.checkBox_8b.Text = "8б клас";
            this.checkBox_8b.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Момичета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Момчета";
            // 
            // girls8a_textBox
            // 
            this.girls8a_textBox.Location = new System.Drawing.Point(105, 129);
            this.girls8a_textBox.Name = "girls8a_textBox";
            this.girls8a_textBox.Size = new System.Drawing.Size(100, 22);
            this.girls8a_textBox.TabIndex = 7;
            // 
            // girls8b_textBox
            // 
            this.girls8b_textBox.Location = new System.Drawing.Point(105, 158);
            this.girls8b_textBox.Name = "girls8b_textBox";
            this.girls8b_textBox.Size = new System.Drawing.Size(100, 22);
            this.girls8b_textBox.TabIndex = 8;
            // 
            // boys8a_textBox
            // 
            this.boys8a_textBox.Location = new System.Drawing.Point(228, 129);
            this.boys8a_textBox.Name = "boys8a_textBox";
            this.boys8a_textBox.Size = new System.Drawing.Size(100, 22);
            this.boys8a_textBox.TabIndex = 9;
            // 
            // boys8b_textBox
            // 
            this.boys8b_textBox.Location = new System.Drawing.Point(228, 158);
            this.boys8b_textBox.Name = "boys8b_textBox";
            this.boys8b_textBox.Size = new System.Drawing.Size(100, 22);
            this.boys8b_textBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Покажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count.Location = new System.Drawing.Point(158, 204);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(180, 52);
            this.label_count.TabIndex = 12;
            this.label_count.Text = "Брой: 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "Изчисти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boys8b_textBox);
            this.Controls.Add(this.boys8a_textBox);
            this.Controls.Add(this.girls8b_textBox);
            this.Controls.Add(this.girls8a_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_8b);
            this.Controls.Add(this.checkBox_8a);
            this.Controls.Add(this.radioButtonTotal);
            this.Controls.Add(this.radioButtonBoys);
            this.Controls.Add(this.radioButton_Girls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Girls;
        private System.Windows.Forms.RadioButton radioButtonBoys;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.CheckBox checkBox_8a;
        private System.Windows.Forms.CheckBox checkBox_8b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox girls8a_textBox;
        private System.Windows.Forms.TextBox girls8b_textBox;
        private System.Windows.Forms.TextBox boys8a_textBox;
        private System.Windows.Forms.TextBox boys8b_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button2;
    }
}

