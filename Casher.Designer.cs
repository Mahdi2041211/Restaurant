namespace Resturant
{
    partial class Casher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderDetialsTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.MealsList = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetialsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(834, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "كاشير المطعم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "المنتجات المطلوبة";
            // 
            // OrderDetialsTable
            // 
            this.OrderDetialsTable.AllowUserToAddRows = false;
            this.OrderDetialsTable.AllowUserToDeleteRows = false;
            this.OrderDetialsTable.AllowUserToResizeColumns = false;
            this.OrderDetialsTable.AllowUserToResizeRows = false;
            this.OrderDetialsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderDetialsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetialsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Meal,
            this.Price,
            this.details,
            this.Number});
            this.OrderDetialsTable.Location = new System.Drawing.Point(-60, 59);
            this.OrderDetialsTable.Name = "OrderDetialsTable";
            this.OrderDetialsTable.ReadOnly = true;
            this.OrderDetialsTable.RowHeadersWidth = 51;
            this.OrderDetialsTable.RowTemplate.Height = 26;
            this.OrderDetialsTable.Size = new System.Drawing.Size(708, 667);
            this.OrderDetialsTable.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Meal
            // 
            this.Meal.Frozen = true;
            this.Meal.HeaderText = "الوجبة";
            this.Meal.MinimumWidth = 6;
            this.Meal.Name = "Meal";
            this.Meal.ReadOnly = true;
            this.Meal.Width = 125;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "السعر للواحدة";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // details
            // 
            this.details.Frozen = true;
            this.details.HeaderText = "التفاصيل";
            this.details.MinimumWidth = 6;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Width = 125;
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "الكمية";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(893, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "اختيار وجبة لإضافتها";
            // 
            // MealsList
            // 
            this.MealsList.FormattingEnabled = true;
            this.MealsList.Items.AddRange(new object[] {
            "شاورما",
            "مسبحة",
            "فلافل",
            "فول",
            "حمص",
            "فجل"});
            this.MealsList.Location = new System.Drawing.Point(683, 132);
            this.MealsList.Name = "MealsList";
            this.MealsList.Size = new System.Drawing.Size(416, 42);
            this.MealsList.TabIndex = 4;
            // 
            // Casher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 722);
            this.Controls.Add(this.MealsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderDetialsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Casher";
            this.Text = "Casher";
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetialsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OrderDetialsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox MealsList;
    }
}