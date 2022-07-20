namespace SampleDatabase
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AdrTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SearchAdrButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchIdButton = new System.Windows.Forms.Button();
            this.SearchAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressDataSet = new SampleDatabase.AddressDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(212, 373);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 30);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(46, 373);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 30);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "登録";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdrTextBox
            // 
            this.AdrTextBox.Location = new System.Drawing.Point(321, 74);
            this.AdrTextBox.Name = "AdrTextBox";
            this.AdrTextBox.Size = new System.Drawing.Size(100, 25);
            this.AdrTextBox.TabIndex = 15;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(321, 29);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 25);
            this.IdTextBox.TabIndex = 14;
            // 
            // SearchAdrButton
            // 
            this.SearchAdrButton.Location = new System.Drawing.Point(196, 71);
            this.SearchAdrButton.Name = "SearchAdrButton";
            this.SearchAdrButton.Size = new System.Drawing.Size(119, 30);
            this.SearchAdrButton.TabIndex = 13;
            this.SearchAdrButton.Text = "住所指定";
            this.SearchAdrButton.UseVisualStyleBackColor = true;
            this.SearchAdrButton.Click += new System.EventHandler(this.SearchAllButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(30, 69);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(119, 30);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "表示をクリア";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchIdButton
            // 
            this.SearchIdButton.Location = new System.Drawing.Point(196, 26);
            this.SearchIdButton.Name = "SearchIdButton";
            this.SearchIdButton.Size = new System.Drawing.Size(119, 30);
            this.SearchIdButton.TabIndex = 11;
            this.SearchIdButton.Text = "ID指定";
            this.SearchIdButton.UseVisualStyleBackColor = true;
            this.SearchIdButton.Click += new System.EventHandler(this.SearchIdButton_Click);
            // 
            // SearchAllButton
            // 
            this.SearchAllButton.Location = new System.Drawing.Point(30, 24);
            this.SearchAllButton.Name = "SearchAllButton";
            this.SearchAllButton.Size = new System.Drawing.Size(119, 30);
            this.SearchAllButton.TabIndex = 10;
            this.SearchAllButton.Text = "全件表示";
            this.SearchAllButton.UseVisualStyleBackColor = true;
            this.SearchAllButton.Click += new System.EventHandler(this.SearchAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(707, 234);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // aDRESSDataGridViewTextBoxColumn
            // 
            this.aDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.HeaderText = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aDRESSDataGridViewTextBoxColumn.Name = "aDRESSDataGridViewTextBoxColumn";
            // 
            // addressDataTableBindingSource
            // 
            this.addressDataTableBindingSource.DataMember = "addressDataTable";
            this.addressDataTableBindingSource.DataSource = this.addressDataSet;
            // 
            // addressDataSet
            // 
            this.addressDataSet.DataSetName = "AddressDataSet";
            this.addressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 415);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AdrTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.SearchAdrButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchIdButton);
            this.Controls.Add(this.SearchAllButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AdrTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button SearchAdrButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchIdButton;
        private System.Windows.Forms.Button SearchAllButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressDataTableBindingSource;
        private AddressDataSet addressDataSet;
    }
}

