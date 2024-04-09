namespace Assessed_Exercise_1_Solution
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
            this.CustomersBox = new System.Windows.Forms.ListBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.dequeueTextBox = new System.Windows.Forms.RichTextBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalDebtTextBox = new System.Windows.Forms.TextBox();
            this.totalDebtButton = new System.Windows.Forms.Button();
            this.highestDebtorTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersBox
            // 
            this.CustomersBox.FormattingEnabled = true;
            this.CustomersBox.Location = new System.Drawing.Point(1, 23);
            this.CustomersBox.Name = "CustomersBox";
            this.CustomersBox.Size = new System.Drawing.Size(421, 95);
            this.CustomersBox.TabIndex = 0;
            this.CustomersBox.SelectedIndexChanged += new System.EventHandler(this.CustomersBox_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(622, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 20);
            this.nameBox.TabIndex = 1;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(622, 73);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(148, 20);
            this.ageBox.TabIndex = 2;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(622, 114);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(148, 103);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(627, 246);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(142, 20);
            this.amountBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(646, 281);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Customer";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(428, 37);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(120, 23);
            this.displayButton.TabIndex = 6;
            this.displayButton.Text = "Show customers";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // dequeueTextBox
            // 
            this.dequeueTextBox.Location = new System.Drawing.Point(12, 150);
            this.dequeueTextBox.Name = "dequeueTextBox";
            this.dequeueTextBox.Size = new System.Drawing.Size(162, 37);
            this.dequeueTextBox.TabIndex = 7;
            this.dequeueTextBox.Text = "";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(180, 150);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(111, 23);
            this.dequeueButton.TabIndex = 9;
            this.dequeueButton.Text = "Show next customer";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount Owed";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalDebtTextBox
            // 
            this.totalDebtTextBox.Location = new System.Drawing.Point(12, 281);
            this.totalDebtTextBox.Name = "totalDebtTextBox";
            this.totalDebtTextBox.Size = new System.Drawing.Size(162, 20);
            this.totalDebtTextBox.TabIndex = 14;
            // 
            // totalDebtButton
            // 
            this.totalDebtButton.Location = new System.Drawing.Point(180, 278);
            this.totalDebtButton.Name = "totalDebtButton";
            this.totalDebtButton.Size = new System.Drawing.Size(111, 23);
            this.totalDebtButton.TabIndex = 15;
            this.totalDebtButton.Text = "Get Total Debt";
            this.totalDebtButton.UseVisualStyleBackColor = true;
            this.totalDebtButton.Click += new System.EventHandler(this.totalDebtButton_Click);
            // 
            // highestDebtorTextBox
            // 
            this.highestDebtorTextBox.Location = new System.Drawing.Point(12, 204);
            this.highestDebtorTextBox.Name = "highestDebtorTextBox";
            this.highestDebtorTextBox.Size = new System.Drawing.Size(162, 37);
            this.highestDebtorTextBox.TabIndex = 16;
            this.highestDebtorTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Show Customer with Highest Debt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.highestDebtorTextBox);
            this.Controls.Add(this.totalDebtButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.dequeueTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.CustomersBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.RichTextBox dequeueTextBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalDebtTextBox;
        private System.Windows.Forms.Button totalDebtButton;
        private System.Windows.Forms.RichTextBox highestDebtorTextBox;
        private System.Windows.Forms.Button button1;
    }
}

