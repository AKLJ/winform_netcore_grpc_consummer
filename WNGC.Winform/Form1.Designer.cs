using System.Windows.Forms;

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
            this.ReadMvtsButton = new System.Windows.Forms.Button();
            this.ArticleCountListBox = new System.Windows.Forms.ListBox();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.StockMovementListBox = new System.Windows.Forms.ListBox();
            // 
            // ReadMvtsButton
            // 
            this.ReadMvtsButton.Location = new System.Drawing.Point(32, 87);
            this.ReadMvtsButton.Name = "ReadMvtsButton";
            this.ReadMvtsButton.Size = new System.Drawing.Size(159, 47);
            this.ReadMvtsButton.TabIndex = 1;
            this.ReadMvtsButton.Text = "Read Stock Movements";
            this.ReadMvtsButton.UseVisualStyleBackColor = true;
            this.ReadMvtsButton.Click += new System.EventHandler(this.ReadMvtsButton_Click);
            // 
            // ArticleCountListBox
            // 
            this.ArticleCountListBox.FormattingEnabled = true;
            this.ArticleCountListBox.ItemHeight = 15;
            this.ArticleCountListBox.Location = new System.Drawing.Point(426, 11);
            this.ArticleCountListBox.Name = "ArticleCountListBox";
            this.ArticleCountListBox.Size = new System.Drawing.Size(120, 94);
            this.ArticleCountListBox.TabIndex = 2;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Location = new System.Drawing.Point(426, 187);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(45, 15);
            this.ProfitLabel.TabIndex = 4;
            this.ProfitLabel.Text = "Profit : ";
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Location = new System.Drawing.Point(497, 187);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(0, 15);
            this.RevenueLabel.TabIndex = 5;
            // 
            // StockMovementListBox
            // 
            this.StockMovementListBox.FormattingEnabled = true;
            this.StockMovementListBox.ItemHeight = 15;
            this.StockMovementListBox.Location = new System.Drawing.Point(32, 216);
            this.StockMovementListBox.Name = "StockMovementListBox";
            this.StockMovementListBox.Size = new System.Drawing.Size(747, 214);
            this.StockMovementListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StockMovementListBox);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.ProfitLabel);
            this.Controls.Add(this.ArticleCountListBox);
            this.Controls.Add(this.ReadMvtsButton);
            this.Controls.Add(this.CreateMvtsButton);
            this.Name = "Form1";
            this.Text = "Form1";

        }

        #endregion

        private System.Windows.Forms.Button CreateMvtsButton;
        private System.Windows.Forms.Button ReadMvtsButton;
        private System.Windows.Forms.ListBox ArticleCountListBox;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.Label RevenueLabel;
        private ListBox StockMovementListBox;
    }
}

