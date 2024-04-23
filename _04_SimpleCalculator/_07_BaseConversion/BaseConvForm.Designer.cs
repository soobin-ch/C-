namespace _07_BaseConversion
{
    partial class BaseConvForm
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
            this.lblBase = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(75, 44);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(17, 12);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "10";
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Location = new System.Drawing.Point(162, 33);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 23);
            this.txtValue.TabIndex = 1;
            this.txtValue.Text = "100";
            this.txtValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(61, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(122, 95);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 23);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(183, 95);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(47, 23);
            this.btn10.TabIndex = 4;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(236, 95);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(51, 23);
            this.btn16.TabIndex = 5;
            this.btn16.Text = "16";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "진수로 변환";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "진수";
            // 
            // BaseConvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn16);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblBase);
            this.Name = "BaseConvForm";
            this.Text = "정수형 자료의 진법변환";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label txtValue;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

