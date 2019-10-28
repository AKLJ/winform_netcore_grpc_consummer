namespace WNGC.Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateMvtsButton = new System.Windows.Forms.Button();
            this.ReadMvtsButton = new System.Windows.Forms.Button();
            // 
            // CreateMvtsButton
            // 
            this.CreateMvtsButton.Location = new System.Drawing.Point(30, 13);
            this.CreateMvtsButton.Name = "CreateMvtsButton";
            this.CreateMvtsButton.Size = new System.Drawing.Size(159, 31);
            this.CreateMvtsButton.TabIndex = 0;
            this.CreateMvtsButton.Text = "Create Stocks Movements";
            this.CreateMvtsButton.UseVisualStyleBackColor = true;
            this.CreateMvtsButton.Click += new System.EventHandler(this.CreateMvtsButton_Click);
            // 
            // ReadMvtsButton
            // 
            this.ReadMvtsButton.Location = new System.Drawing.Point(30, 65);
            this.ReadMvtsButton.Name = "ReadMvtsButton";
            this.ReadMvtsButton.Size = new System.Drawing.Size(159, 47);
            this.ReadMvtsButton.TabIndex = 1;
            this.ReadMvtsButton.Text = "Read Stock Movements";
            this.ReadMvtsButton.UseVisualStyleBackColor = true;
            this.ReadMvtsButton.Click += new System.EventHandler(this.ReadMvtsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadMvtsButton);
            this.Controls.Add(this.CreateMvtsButton);
            this.Name = "Form1";
            this.Text = "Form1";

        }

        #endregion

        private System.Windows.Forms.Button CreateMvtsButton;
        private System.Windows.Forms.Button ReadMvtsButton;
    }
}

