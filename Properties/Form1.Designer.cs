namespace UnicornsAndRainbows
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
            this.c_buttonUnicorns = new System.Windows.Forms.Button();
            this.c_buttonRainbows = new System.Windows.Forms.Button();
            this.c_labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_buttonUnicorns
            // 
            this.c_buttonUnicorns.Location = new System.Drawing.Point(27, 26);
            this.c_buttonUnicorns.Name = "c_buttonUnicorns";
            this.c_buttonUnicorns.Size = new System.Drawing.Size(75, 23);
            this.c_buttonUnicorns.TabIndex = 0;
            this.c_buttonUnicorns.Text = "Unicorns";
            this.c_buttonUnicorns.UseVisualStyleBackColor = true;
            // 
            // c_buttonRainbows
            // 
            this.c_buttonRainbows.Location = new System.Drawing.Point(27, 70);
            this.c_buttonRainbows.Name = "c_buttonRainbows";
            this.c_buttonRainbows.Size = new System.Drawing.Size(75, 23);
            this.c_buttonRainbows.TabIndex = 1;
            this.c_buttonRainbows.Text = "Rainbows";
            this.c_buttonRainbows.UseVisualStyleBackColor = true;
            // 
            // c_labelCount
            // 
            this.c_labelCount.AutoSize = true;
            this.c_labelCount.Location = new System.Drawing.Point(49, 117);
            this.c_labelCount.Name = "c_labelCount";
            this.c_labelCount.Size = new System.Drawing.Size(0, 13);
            this.c_labelCount.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 159);
            this.Controls.Add(this.c_labelCount);
            this.Controls.Add(this.c_buttonRainbows);
            this.Controls.Add(this.c_buttonUnicorns);
            this.Name = "Form1";
            this.Text = "Unicorns and Rainbows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c_buttonUnicorns;
        private System.Windows.Forms.Button c_buttonRainbows;
        private System.Windows.Forms.Label c_labelCount;
    }
}

