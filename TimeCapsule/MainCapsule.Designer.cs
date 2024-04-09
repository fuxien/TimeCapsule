namespace TimeCapsule
{
    partial class TimeCapsule
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.displayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDisplayDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nowDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.futureDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pastDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPages.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futureDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPage4);
            this.tabPages.Controls.Add(this.tabPage1);
            this.tabPages.Controls.Add(this.tabPage3);
            this.tabPages.Controls.Add(this.tabPage2);
            this.tabPages.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPages.Location = new System.Drawing.Point(0, 2);
            this.tabPages.Name = "tabPages";
            this.tabPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPages.RightToLeftLayout = true;
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(437, 372);
            this.tabPages.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAdd);
            this.tabPage4.Controls.Add(this.displayDateTimePicker);
            this.tabPage4.Controls.Add(this.lblDisplayDate);
            this.tabPage4.Controls.Add(this.lblNote);
            this.tabPage4.Controls.Add(this.txtNote);
            this.tabPage4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(429, 340);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ADD";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // displayDateTimePicker
            // 
            this.displayDateTimePicker.Location = new System.Drawing.Point(126, 256);
            this.displayDateTimePicker.Name = "displayDateTimePicker";
            this.displayDateTimePicker.Size = new System.Drawing.Size(295, 26);
            this.displayDateTimePicker.TabIndex = 3;
            // 
            // lblDisplayDate
            // 
            this.lblDisplayDate.AutoSize = true;
            this.lblDisplayDate.Location = new System.Drawing.Point(8, 262);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(86, 19);
            this.lblDisplayDate.TabIndex = 2;
            this.lblDisplayDate.Text = "Display Date";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(8, 12);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(35, 19);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(60, 12);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(361, 238);
            this.txtNote.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nowDataGridView);
            this.tabPage1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NOW";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nowDataGridView
            // 
            this.nowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nowDataGridView.Location = new System.Drawing.Point(3, 3);
            this.nowDataGridView.MultiSelect = false;
            this.nowDataGridView.Name = "nowDataGridView";
            this.nowDataGridView.ReadOnly = true;
            this.nowDataGridView.Size = new System.Drawing.Size(423, 332);
            this.nowDataGridView.TabIndex = 0;
       
            this.nowDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nowDataGridView_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.futureDataGridView);
            this.tabPage3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(429, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FUTURE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // futureDataGridView
            // 
            this.futureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.futureDataGridView.Location = new System.Drawing.Point(3, 3);
            this.futureDataGridView.MultiSelect = false;
            this.futureDataGridView.Name = "futureDataGridView";
            this.futureDataGridView.ReadOnly = true;
            this.futureDataGridView.Size = new System.Drawing.Size(423, 332);
            this.futureDataGridView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pastDataGridView);
            this.tabPage2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PAST";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pastDataGridView
            // 
            this.pastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastDataGridView.Location = new System.Drawing.Point(3, 3);
            this.pastDataGridView.MultiSelect = false;
            this.pastDataGridView.Name = "pastDataGridView";
            this.pastDataGridView.ReadOnly = true;
            this.pastDataGridView.Size = new System.Drawing.Size(423, 332);
            this.pastDataGridView.TabIndex = 0;
            this.pastDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pastDataGridView_CellDoubleClick);
            
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(413, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TimeCapsule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 374);
            this.Controls.Add(this.tabPages);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeCapsule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Capsule";
            this.Load += new System.EventHandler(this.TimeCapsule_Load);
            this.tabPages.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.futureDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pastDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView nowDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker displayDateTimePicker;
        private System.Windows.Forms.Label lblDisplayDate;
        private System.Windows.Forms.DataGridView futureDataGridView;
        private System.Windows.Forms.DataGridView pastDataGridView;
        private System.Windows.Forms.Button btnAdd;
    }
}

