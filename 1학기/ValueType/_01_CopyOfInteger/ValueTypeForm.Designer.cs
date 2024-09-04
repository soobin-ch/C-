namespace _01_CopyOfInteger
{
    partial class ValueTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIx1 = new System.Windows.Forms.Label();
            this.lblIx2 = new System.Windows.Forms.Label();
            this.lblIx3 = new System.Windows.Forms.Label();
            this.lblIy1 = new System.Windows.Forms.Label();
            this.lblIy2 = new System.Windows.Forms.Label();
            this.lblIy3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "정수형 숫자를 읽어 복사하기";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(61, 56);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(151, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "정수 자료복사하기";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "x에 값을 입력받은 후";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x를 y에 복사한후..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "y값을 변경한 후";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "ix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "iy";
            // 
            // lblIx1
            // 
            this.lblIx1.AutoSize = true;
            this.lblIx1.Location = new System.Drawing.Point(160, 124);
            this.lblIx1.Name = "lblIx1";
            this.lblIx1.Size = new System.Drawing.Size(0, 12);
            this.lblIx1.TabIndex = 7;
            // 
            // lblIx2
            // 
            this.lblIx2.AutoSize = true;
            this.lblIx2.Location = new System.Drawing.Point(160, 162);
            this.lblIx2.Name = "lblIx2";
            this.lblIx2.Size = new System.Drawing.Size(0, 12);
            this.lblIx2.TabIndex = 8;
            // 
            // lblIx3
            // 
            this.lblIx3.AutoSize = true;
            this.lblIx3.Location = new System.Drawing.Point(160, 203);
            this.lblIx3.Name = "lblIx3";
            this.lblIx3.Size = new System.Drawing.Size(0, 12);
            this.lblIx3.TabIndex = 9;
            // 
            // lblIy1
            // 
            this.lblIy1.AutoSize = true;
            this.lblIy1.Location = new System.Drawing.Point(229, 124);
            this.lblIy1.Name = "lblIy1";
            this.lblIy1.Size = new System.Drawing.Size(0, 12);
            this.lblIy1.TabIndex = 10;
            // 
            // lblIy2
            // 
            this.lblIy2.AutoSize = true;
            this.lblIy2.Location = new System.Drawing.Point(229, 162);
            this.lblIy2.Name = "lblIy2";
            this.lblIy2.Size = new System.Drawing.Size(0, 12);
            this.lblIy2.TabIndex = 11;
            // 
            // lblIy3
            // 
            this.lblIy3.AutoSize = true;
            this.lblIy3.Location = new System.Drawing.Point(229, 203);
            this.lblIy3.Name = "lblIy3";
            this.lblIy3.Size = new System.Drawing.Size(0, 12);
            this.lblIy3.TabIndex = 12;
            // 
            // ValueTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIy3);
            this.Controls.Add(this.lblIy2);
            this.Controls.Add(this.lblIy1);
            this.Controls.Add(this.lblIx3);
            this.Controls.Add(this.lblIx2);
            this.Controls.Add(this.lblIx1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Name = "ValueTypeForm";
            this.Text = "값형 변수 복사하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIx1;
        private System.Windows.Forms.Label lblIx2;
        private System.Windows.Forms.Label lblIx3;
        private System.Windows.Forms.Label lblIy1;
        private System.Windows.Forms.Label lblIy2;
        private System.Windows.Forms.Label lblIy3;
    }
}

