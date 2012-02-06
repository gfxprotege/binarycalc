namespace WindowsFormsApplication1
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
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(32, 58);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(40, 40);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(78, 58);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(40, 40);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(32, 104);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 22);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(78, 104);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(40, 22);
            this.mult.TabIndex = 3;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(32, 22);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(190, 20);
            this.txt.TabIndex = 4;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(147, 104);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 23);
            this.equals.TabIndex = 5;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(146, 58);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 6;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 139);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Worst Binary Calculator Ever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clr;
    }
}

