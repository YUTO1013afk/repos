namespace BookManager
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
            this.bookDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.MaskedTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.bookDataSet = new BookManager.BookDataSet();
            this.bookDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.著者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDataGrid
            // 
            this.bookDataGrid.AutoGenerateColumns = false;
            this.bookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書名DataGridViewTextBoxColumn,
            this.著者DataGridViewTextBoxColumn,
            this.値段DataGridViewTextBoxColumn});
            this.bookDataGrid.DataSource = this.bookDataTableBindingSource;
            this.bookDataGrid.Location = new System.Drawing.Point(21, 12);
            this.bookDataGrid.Name = "bookDataGrid";
            this.bookDataGrid.RowHeadersWidth = 62;
            this.bookDataGrid.RowTemplate.Height = 27;
            this.bookDataGrid.Size = new System.Drawing.Size(612, 293);
            this.bookDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "書名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "著者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "値段";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(101, 329);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(324, 25);
            this.bookName.TabIndex = 4;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(101, 371);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(324, 25);
            this.author.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(101, 408);
            this.price.Mask = "00000";
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(324, 25);
            this.price.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(478, 321);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 48);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(478, 388);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(109, 50);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDataTableBindingSource
            // 
            this.bookDataTableBindingSource.DataMember = "bookDataTable";
            this.bookDataTableBindingSource.DataSource = this.bookDataSet;
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            this.書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            this.書名DataGridViewTextBoxColumn.Width = 150;
            // 
            // 著者DataGridViewTextBoxColumn
            // 
            this.著者DataGridViewTextBoxColumn.DataPropertyName = "著者";
            this.著者DataGridViewTextBoxColumn.HeaderText = "著者";
            this.著者DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.著者DataGridViewTextBoxColumn.Name = "著者DataGridViewTextBoxColumn";
            this.著者DataGridViewTextBoxColumn.Width = 150;
            // 
            // 値段DataGridViewTextBoxColumn
            // 
            this.値段DataGridViewTextBoxColumn.DataPropertyName = "値段";
            this.値段DataGridViewTextBoxColumn.HeaderText = "値段";
            this.値段DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.値段DataGridViewTextBoxColumn.Name = "値段DataGridViewTextBoxColumn";
            this.値段DataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.MaskedTextBox price;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 著者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値段DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource;
        private BookDataSet bookDataSet;
    }
}

