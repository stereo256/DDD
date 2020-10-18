namespace DDD.WinForm
{
    partial class WeatherLatestView
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
            this.TxtAreaId = new System.Windows.Forms.TextBox();
            this.LblAreaId = new System.Windows.Forms.Label();
            this.BtnLatest = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.LblDataDate = new System.Windows.Forms.Label();
            this.LblCondition = new System.Windows.Forms.Label();
            this.LblTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAreaId
            // 
            this.TxtAreaId.Location = new System.Drawing.Point(150, 42);
            this.TxtAreaId.Name = "TxtAreaId";
            this.TxtAreaId.Size = new System.Drawing.Size(100, 25);
            this.TxtAreaId.TabIndex = 0;
            // 
            // LblAreaId
            // 
            this.LblAreaId.AutoSize = true;
            this.LblAreaId.Location = new System.Drawing.Point(31, 45);
            this.LblAreaId.Name = "LblAreaId";
            this.LblAreaId.Size = new System.Drawing.Size(44, 18);
            this.LblAreaId.TabIndex = 1;
            this.LblAreaId.Text = "地域";
            // 
            // BtnLatest
            // 
            this.BtnLatest.Location = new System.Drawing.Point(289, 36);
            this.BtnLatest.Name = "BtnLatest";
            this.BtnLatest.Size = new System.Drawing.Size(75, 37);
            this.BtnLatest.TabIndex = 2;
            this.BtnLatest.Text = "直近値";
            this.BtnLatest.UseVisualStyleBackColor = true;
            this.BtnLatest.Click += new System.EventHandler(this.BtnLatest_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(31, 115);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(44, 18);
            this.Lbl1.TabIndex = 3;
            this.Lbl1.Text = "日時";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(31, 178);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(44, 18);
            this.Lbl2.TabIndex = 4;
            this.Lbl2.Text = "状態";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(31, 247);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(44, 18);
            this.Lbl3.TabIndex = 5;
            this.Lbl3.Text = "温度";
            // 
            // LblDataDate
            // 
            this.LblDataDate.AutoSize = true;
            this.LblDataDate.Location = new System.Drawing.Point(147, 115);
            this.LblDataDate.Name = "LblDataDate";
            this.LblDataDate.Size = new System.Drawing.Size(52, 18);
            this.LblDataDate.TabIndex = 6;
            this.LblDataDate.Text = "label5";
            // 
            // LblCondition
            // 
            this.LblCondition.AutoSize = true;
            this.LblCondition.Location = new System.Drawing.Point(147, 178);
            this.LblCondition.Name = "LblCondition";
            this.LblCondition.Size = new System.Drawing.Size(52, 18);
            this.LblCondition.TabIndex = 7;
            this.LblCondition.Text = "label6";
            // 
            // LblTemperature
            // 
            this.LblTemperature.AutoSize = true;
            this.LblTemperature.Location = new System.Drawing.Point(147, 247);
            this.LblTemperature.Name = "LblTemperature";
            this.LblTemperature.Size = new System.Drawing.Size(52, 18);
            this.LblTemperature.TabIndex = 8;
            this.LblTemperature.Text = "label7";
            // 
            // WeatherLatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.LblTemperature);
            this.Controls.Add(this.LblCondition);
            this.Controls.Add(this.LblDataDate);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.BtnLatest);
            this.Controls.Add(this.LblAreaId);
            this.Controls.Add(this.TxtAreaId);
            this.Name = "WeatherLatestView";
            this.Text = "WeatherLatestView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAreaId;
        private System.Windows.Forms.Label LblAreaId;
        private System.Windows.Forms.Button BtnLatest;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label LblDataDate;
        private System.Windows.Forms.Label LblCondition;
        private System.Windows.Forms.Label LblTemperature;
    }
}

