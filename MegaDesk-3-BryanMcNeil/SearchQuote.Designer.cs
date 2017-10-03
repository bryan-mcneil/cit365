namespace MegaDesk_3_BryanMcNeil
{
    partial class SearchQuote
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
            this.Label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.SearchExit = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(52, 78);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Search:";
            // 
            // SearchBox
            // 
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SearchBox.Location = new System.Drawing.Point(102, 75);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(121, 21);
            this.SearchBox.TabIndex = 1;
            // 
            // SearchExit
            // 
            this.SearchExit.Location = new System.Drawing.Point(168, 186);
            this.SearchExit.Name = "SearchExit";
            this.SearchExit.Size = new System.Drawing.Size(75, 23);
            this.SearchExit.TabIndex = 2;
            this.SearchExit.Text = "Exit";
            this.SearchExit.UseVisualStyleBackColor = true;
            this.SearchExit.Click += new System.EventHandler(this.SearchExit_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(44, 186);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchExit);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Label1);
            this.Name = "SearchQuote";
            this.Text = "SearchQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox SearchBox;
        private System.Windows.Forms.Button SearchExit;
        private System.Windows.Forms.Button SearchBtn;
    }
}