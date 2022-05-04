namespace TaxCalc
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
            this.priceBox = new System.Windows.Forms.TextBox();
            this.taxPriceBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(258, 67);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(347, 25);
            this.priceBox.TabIndex = 1;
            // 
            // taxPriceBox
            // 
            this.taxPriceBox.Enabled = false;
            this.taxPriceBox.Location = new System.Drawing.Point(258, 131);
            this.taxPriceBox.Name = "taxPriceBox";
            this.taxPriceBox.Size = new System.Drawing.Size(347, 25);
            this.taxPriceBox.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(626, 216);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(110, 44);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "計算する";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "税抜価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "税込価格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.taxPriceBox);
            this.Controls.Add(this.priceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox taxPriceBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

