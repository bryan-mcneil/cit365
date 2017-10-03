namespace MegaDesk_3_BryanMcNeil
{
    partial class AddQuote
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
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawerBox = new System.Windows.Forms.ComboBox();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.addExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(121, 84);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 20);
            this.WidthBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Width:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(49, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Enter Depth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Drawers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Material:";
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(121, 122);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(100, 20);
            this.DepthBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Name:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(121, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawerBox
            // 
            this.DrawerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawerBox.FormattingEnabled = true;
            this.DrawerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerBox.Location = new System.Drawing.Point(121, 159);
            this.DrawerBox.Name = "DrawerBox";
            this.DrawerBox.Size = new System.Drawing.Size(100, 21);
            this.DrawerBox.TabIndex = 3;
            // 
            // MaterialBox
            // 
            this.MaterialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.MaterialBox.Location = new System.Drawing.Point(121, 191);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(100, 21);
            this.MaterialBox.TabIndex = 4;
            // 
            // addExit
            // 
            this.addExit.Location = new System.Drawing.Point(180, 239);
            this.addExit.Name = "addExit";
            this.addExit.Size = new System.Drawing.Size(75, 23);
            this.addExit.TabIndex = 11;
            this.addExit.Text = "Exit";
            this.addExit.UseVisualStyleBackColor = true;
            this.addExit.Click += new System.EventHandler(this.addExit_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 274);
            this.Controls.Add(this.addExit);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.DrawerBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthBox);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DrawerBox;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.Button addExit;
    }
}