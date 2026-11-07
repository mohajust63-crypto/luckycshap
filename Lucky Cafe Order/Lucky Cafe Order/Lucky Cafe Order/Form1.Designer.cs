namespace Lucky_Cafe_Order
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
            this.StudentMemberCheckbox = new System.Windows.Forms.CheckBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.DrinkPrice = new System.Windows.Forms.GroupBox();
            this.CoffeRadioBtn = new System.Windows.Forms.RadioButton();
            this.JuiceRadioBtn = new System.Windows.Forms.RadioButton();
            this.TeaRadioBtn = new System.Windows.Forms.RadioButton();
            this.CustomerNameTxt = new System.Windows.Forms.TextBox();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.object_bace02e1_8a12_4338_b234_5af6461b787d = new System.Windows.Forms.GroupBox();
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d = new System.Windows.Forms.GroupBox();
            this.Order_List = new System.Windows.Forms.ListBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LuckyMessageLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.DrinkPrice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentMemberCheckbox);
            this.groupBox1.Controls.Add(this.QuantityTxt);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.DrinkPrice);
            this.groupBox1.Controls.Add(this.CustomerNameTxt);
            this.groupBox1.Controls.Add(this.Customer_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(579, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // StudentMemberCheckbox
            // 
            this.StudentMemberCheckbox.AutoSize = true;
            this.StudentMemberCheckbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentMemberCheckbox.Location = new System.Drawing.Point(253, 393);
            this.StudentMemberCheckbox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StudentMemberCheckbox.Name = "StudentMemberCheckbox";
            this.StudentMemberCheckbox.Size = new System.Drawing.Size(235, 25);
            this.StudentMemberCheckbox.TabIndex = 5;
            this.StudentMemberCheckbox.Text = "Student Member (10% Off)";
            this.StudentMemberCheckbox.UseVisualStyleBackColor = true;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(138, 386);
            this.QuantityTxt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.QuantityTxt.Multiline = true;
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(78, 34);
            this.QuantityTxt.TabIndex = 4;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(30, 391);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(79, 21);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity:";
            // 
            // DrinkPrice
            // 
            this.DrinkPrice.Controls.Add(this.CoffeRadioBtn);
            this.DrinkPrice.Controls.Add(this.JuiceRadioBtn);
            this.DrinkPrice.Controls.Add(this.TeaRadioBtn);
            this.DrinkPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkPrice.Location = new System.Drawing.Point(30, 188);
            this.DrinkPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DrinkPrice.Name = "DrinkPrice";
            this.DrinkPrice.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DrinkPrice.Size = new System.Drawing.Size(499, 178);
            this.DrinkPrice.TabIndex = 2;
            this.DrinkPrice.TabStop = false;
            this.DrinkPrice.Text = "Drink Type";
            // 
            // CoffeRadioBtn
            // 
            this.CoffeRadioBtn.AutoSize = true;
            this.CoffeRadioBtn.Location = new System.Drawing.Point(20, 66);
            this.CoffeRadioBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CoffeRadioBtn.Name = "CoffeRadioBtn";
            this.CoffeRadioBtn.Size = new System.Drawing.Size(111, 25);
            this.CoffeRadioBtn.TabIndex = 0;
            this.CoffeRadioBtn.TabStop = true;
            this.CoffeRadioBtn.Text = "Coffe  ($2)";
            this.CoffeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // JuiceRadioBtn
            // 
            this.JuiceRadioBtn.AutoSize = true;
            this.JuiceRadioBtn.Location = new System.Drawing.Point(20, 98);
            this.JuiceRadioBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.JuiceRadioBtn.Name = "JuiceRadioBtn";
            this.JuiceRadioBtn.Size = new System.Drawing.Size(110, 25);
            this.JuiceRadioBtn.TabIndex = 0;
            this.JuiceRadioBtn.TabStop = true;
            this.JuiceRadioBtn.Text = "Juice  ($3)";
            this.JuiceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TeaRadioBtn
            // 
            this.TeaRadioBtn.AutoSize = true;
            this.TeaRadioBtn.Location = new System.Drawing.Point(20, 33);
            this.TeaRadioBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TeaRadioBtn.Name = "TeaRadioBtn";
            this.TeaRadioBtn.Size = new System.Drawing.Size(101, 25);
            this.TeaRadioBtn.TabIndex = 0;
            this.TeaRadioBtn.TabStop = true;
            this.TeaRadioBtn.Text = "Tea  ($1)";
            this.TeaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.Location = new System.Drawing.Point(30, 129);
            this.CustomerNameTxt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CustomerNameTxt.Multiline = true;
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.Size = new System.Drawing.Size(499, 38);
            this.CustomerNameTxt.TabIndex = 1;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name.Location = new System.Drawing.Point(27, 92);
            this.Customer_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(135, 21);
            this.Customer_Name.TabIndex = 0;
            this.Customer_Name.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // object_bace02e1_8a12_4338_b234_5af6461b787d
            // 
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.Location = new System.Drawing.Point(30, 188);
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.Name = "object_bace02e1_8a12_4338_b234_5af6461b787d";
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.Size = new System.Drawing.Size(499, 178);
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.TabIndex = 2;
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.TabStop = false;
            // 
            // object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d
            // 
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.Location = new System.Drawing.Point(30, 188);
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.Name = "object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d";
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.Size = new System.Drawing.Size(499, 178);
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.TabIndex = 2;
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.TabStop = false;
            // 
            // Order_List
            // 
            this.Order_List.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_List.ForeColor = System.Drawing.Color.Black;
            this.Order_List.FormattingEnabled = true;
            this.Order_List.ItemHeight = 24;
            this.Order_List.Location = new System.Drawing.Point(612, 49);
            this.Order_List.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Order_List.Name = "Order_List";
            this.Order_List.Size = new System.Drawing.Size(508, 460);
            this.Order_List.TabIndex = 1;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(12, 521);
            this.CalculateBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(227, 49);
            this.CalculateBtn.TabIndex = 2;
            this.CalculateBtn.Text = "Calculate Order";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(265, 521);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(227, 49);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save to File";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(520, 521);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(227, 49);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Load from File";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(775, 521);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(227, 49);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LuckyMessageLbl
            // 
            this.LuckyMessageLbl.AutoSize = true;
            this.LuckyMessageLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuckyMessageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LuckyMessageLbl.Location = new System.Drawing.Point(16, 65);
            this.LuckyMessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LuckyMessageLbl.Name = "LuckyMessageLbl";
            this.LuckyMessageLbl.Size = new System.Drawing.Size(150, 24);
            this.LuckyMessageLbl.TabIndex = 5;
            this.LuckyMessageLbl.Text = "Lucky Message:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLbl.ForeColor = System.Drawing.Color.Navy;
            this.TotalPriceLbl.Location = new System.Drawing.Point(15, 26);
            this.TotalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(112, 24);
            this.TotalPriceLbl.TabIndex = 6;
            this.TotalPriceLbl.Text = "Total Price:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LuckyMessageLbl);
            this.groupBox2.Controls.Add(this.TotalPriceLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 576);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(1093, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label.Location = new System.Drawing.Point(16, 4);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(211, 28);
            this.Label.TabIndex = 8;
            this.Label.Text = "Lucky Cafe Order";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(612, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 716);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Order_List);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DrinkPrice.ResumeLayout(false);
            this.DrinkPrice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DrinkPrice;
        private System.Windows.Forms.RadioButton CoffeRadioBtn;
        private System.Windows.Forms.RadioButton JuiceRadioBtn;
        private System.Windows.Forms.RadioButton TeaRadioBtn;
        private System.Windows.Forms.TextBox CustomerNameTxt;
        private System.Windows.Forms.Label Customer_Name;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.CheckBox StudentMemberCheckbox;
        private System.Windows.Forms.GroupBox object_bace02e1_8a12_4338_b234_5af6461b787d;
        private System.Windows.Forms.GroupBox object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d;
        private System.Windows.Forms.ListBox Order_List;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label LuckyMessageLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
    }
}

