namespace Resturant
{
    partial class Manager
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
            this.GetData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AllBills = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GetData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1016, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "الإدارة";
            // 
            // GetData
            // 
            this.GetData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GetData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetData.Location = new System.Drawing.Point(2, 1);
            this.GetData.Name = "GetData";
            this.GetData.ReadOnly = true;
            this.GetData.RowHeadersWidth = 51;
            this.GetData.RowTemplate.Height = 26;
            this.GetData.Size = new System.Drawing.Size(608, 756);
            this.GetData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(926, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "استخراج الفاتير";
            // 
            // AllBills
            // 
            this.AllBills.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBills.Location = new System.Drawing.Point(954, 120);
            this.AllBills.Name = "AllBills";
            this.AllBills.Size = new System.Drawing.Size(129, 41);
            this.AllBills.TabIndex = 4;
            this.AllBills.Text = "كل الفواتير";
            this.AllBills.UseVisualStyleBackColor = true;
            this.AllBills.Click += new System.EventHandler(this.AllBills_Click);
            // 
            // Options
            // 
            this.Options.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(809, 120);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(129, 41);
            this.Options.TabIndex = 5;
            this.Options.Text = "تخصيص";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 757);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.AllBills);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.label1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GetData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AllBills;
        private System.Windows.Forms.Button Options;
    }
}