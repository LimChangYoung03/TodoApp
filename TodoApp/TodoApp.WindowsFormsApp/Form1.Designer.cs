namespace TodoApp.WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.bIsDone = new System.Windows.Forms.CheckBox();
            this.lblIsDone = new System.Windows.Forms.Label();
            this.BTNADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(29, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "할 일 :";
            // 
            // txtTittle
            // 
            this.txtTittle.Location = new System.Drawing.Point(72, 28);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(282, 21);
            this.txtTittle.TabIndex = 1;
            // 
            // bIsDone
            // 
            this.bIsDone.AutoSize = true;
            this.bIsDone.Location = new System.Drawing.Point(85, 59);
            this.bIsDone.Name = "bIsDone";
            this.bIsDone.Size = new System.Drawing.Size(48, 16);
            this.bIsDone.TabIndex = 2;
            this.bIsDone.Text = "완료";
            this.bIsDone.UseVisualStyleBackColor = true;
            // 
            // lblIsDone
            // 
            this.lblIsDone.AutoSize = true;
            this.lblIsDone.Location = new System.Drawing.Point(29, 59);
            this.lblIsDone.Name = "lblIsDone";
            this.lblIsDone.Size = new System.Drawing.Size(41, 12);
            this.lblIsDone.TabIndex = 3;
            this.lblIsDone.Text = "완 료 :";
            // 
            // BTNADD
            // 
            this.BTNADD.Location = new System.Drawing.Point(377, 29);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(86, 45);
            this.BTNADD.TabIndex = 4;
            this.BTNADD.Text = "등록";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(432, 194);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.lblIsDone);
            this.Controls.Add(this.bIsDone);
            this.Controls.Add(this.txtTittle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "할 일 목록";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.CheckBox bIsDone;
        private System.Windows.Forms.Label lblIsDone;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

