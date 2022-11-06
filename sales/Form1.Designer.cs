namespace sales
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_value = new System.Windows.Forms.NumericUpDown();
            this.quantity_value = new System.Windows.Forms.NumericUpDown();
            this.total_price_value = new System.Windows.Forms.NumericUpDown();
            this.type_value = new System.Windows.Forms.TextBox();
            this.item_name_value = new System.Windows.Forms.TextBox();
            this.sold_on_value = new System.Windows.Forms.DateTimePicker();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.data_box = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amount_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.id_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_price_value)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Record";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(51, 74);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(460, 22);
            this.searchText.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(538, 76);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(93, 19);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sold on";
            // 
            // id_value
            // 
            this.id_value.Location = new System.Drawing.Point(63, 151);
            this.id_value.Name = "id_value";
            this.id_value.Size = new System.Drawing.Size(120, 22);
            this.id_value.TabIndex = 9;
            // 
            // quantity_value
            // 
            this.quantity_value.Location = new System.Drawing.Point(247, 151);
            this.quantity_value.Name = "quantity_value";
            this.quantity_value.Size = new System.Drawing.Size(120, 22);
            this.quantity_value.TabIndex = 10;
            // 
            // total_price_value
            // 
            this.total_price_value.Location = new System.Drawing.Point(247, 230);
            this.total_price_value.Name = "total_price_value";
            this.total_price_value.Size = new System.Drawing.Size(120, 22);
            this.total_price_value.TabIndex = 11;
            // 
            // type_value
            // 
            this.type_value.Location = new System.Drawing.Point(63, 230);
            this.type_value.Name = "type_value";
            this.type_value.Size = new System.Drawing.Size(100, 22);
            this.type_value.TabIndex = 12;
            // 
            // item_name_value
            // 
            this.item_name_value.Location = new System.Drawing.Point(63, 294);
            this.item_name_value.Name = "item_name_value";
            this.item_name_value.Size = new System.Drawing.Size(100, 22);
            this.item_name_value.TabIndex = 13;
            // 
            // sold_on_value
            // 
            this.sold_on_value.Location = new System.Drawing.Point(247, 294);
            this.sold_on_value.Name = "sold_on_value";
            this.sold_on_value.Size = new System.Drawing.Size(120, 22);
            this.sold_on_value.TabIndex = 14;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(108, 353);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(225, 353);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // data_box
            // 
            this.data_box.FormattingEnabled = true;
            this.data_box.ItemHeight = 12;
            this.data_box.Location = new System.Drawing.Point(421, 136);
            this.data_box.Name = "data_box";
            this.data_box.Size = new System.Drawing.Size(229, 208);
            this.data_box.TabIndex = 18;
            this.data_box.SelectedIndexChanged += new System.EventHandler(this.data_box_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total sales amount:";
            // 
            // amount_count
            // 
            this.amount_count.AutoSize = true;
            this.amount_count.Location = new System.Drawing.Point(558, 358);
            this.amount_count.Name = "amount_count";
            this.amount_count.Size = new System.Drawing.Size(17, 12);
            this.amount_count.TabIndex = 20;
            this.amount_count.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amount_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.data_box);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.sold_on_value);
            this.Controls.Add(this.item_name_value);
            this.Controls.Add(this.type_value);
            this.Controls.Add(this.total_price_value);
            this.Controls.Add(this.quantity_value);
            this.Controls.Add(this.id_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.id_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_price_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown id_value;
        private System.Windows.Forms.NumericUpDown quantity_value;
        private System.Windows.Forms.NumericUpDown total_price_value;
        private System.Windows.Forms.TextBox type_value;
        private System.Windows.Forms.TextBox item_name_value;
        private System.Windows.Forms.DateTimePicker sold_on_value;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ListBox data_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label amount_count;
    }
}

