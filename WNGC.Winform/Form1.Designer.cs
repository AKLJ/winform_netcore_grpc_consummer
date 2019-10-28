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
            this.ArticleCountListBox = new System.Windows.Forms.ListBox();
            this.StockMovementsListView = new System.Windows.Forms.ListView();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.RevenueLabel = new System.Windows.Forms.Label();
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
            // ArticleCountListBox
            // 
            this.ArticleCountListBox.FormattingEnabled = true;
            this.ArticleCountListBox.ItemHeight = 15;
            this.ArticleCountListBox.Location = new System.Drawing.Point(435, 183);
            this.ArticleCountListBox.Name = "ArticleCountListBox";
            this.ArticleCountListBox.Size = new System.Drawing.Size(120, 94);
            this.ArticleCountListBox.TabIndex = 2;
            // 
            // StockMovementsListView
            // 
            this.StockMovementsListView.HideSelection = false;
            this.StockMovementsListView.Location = new System.Drawing.Point(32, 183);
            this.StockMovementsListView.Name = "StockMovementsListView";
            this.StockMovementsListView.Size = new System.Drawing.Size(329, 191);
            this.StockMovementsListView.TabIndex = 3;
            this.StockMovementsListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Location = new System.Drawing.Point(435, 359);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(38, 15);
            this.ProfitLabel.TabIndex = 4;
            this.ProfitLabel.Text = "Profit : ";
            // 
            // label2
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Location = new System.Drawing.Point(506, 359);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(38, 15);
            this.RevenueLabel.TabIndex = 5;
            this.RevenueLabel.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.ProfitLabel);
            this.Controls.Add(this.StockMovementsListView);
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
        private System.Windows.Forms.ListView StockMovementsListView;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.Label RevenueLabel;
    }
}

