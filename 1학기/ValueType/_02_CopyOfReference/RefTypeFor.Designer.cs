namespace _02_CopyOfReference
{
    partial class RefTypeFor
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
            this.lblObj11 = new System.Windows.Forms.Label();
            this.lblObj12 = new System.Windows.Forms.Label();
            this.lblObj13 = new System.Windows.Forms.Label();
            this.lblObj21 = new System.Windows.Forms.Label();
            this.lblObj22 = new System.Windows.Forms.Label();
            this.lblObj23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "객체복사하기";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(61, 56);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(151, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "객체 복사하기";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "myObj1을 생성한 후...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "myObj2에 복사한 후";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "myObj2를 변경한 후";
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
            // lblObj11
            // 
            this.lblObj11.AutoSize = true;
            this.lblObj11.Location = new System.Drawing.Point(160, 124);
            this.lblObj11.Name = "lblObj11";
            this.lblObj11.Size = new System.Drawing.Size(0, 12);
            this.lblObj11.TabIndex = 7;
            // 
            // lblObj12
            // 
            this.lblObj12.AutoSize = true;
            this.lblObj12.Location = new System.Drawing.Point(160, 162);
            this.lblObj12.Name = "lblObj12";
            this.lblObj12.Size = new System.Drawing.Size(0, 12);
            this.lblObj12.TabIndex = 8;
            // 
            // lblObj13
            // 
            this.lblObj13.AutoSize = true;
            this.lblObj13.Location = new System.Drawing.Point(160, 203);
            this.lblObj13.Name = "lblObj13";
            this.lblObj13.Size = new System.Drawing.Size(0, 12);
            this.lblObj13.TabIndex = 9;
            // 
            // lblObj21
            // 
            this.lblObj21.AutoSize = true;
            this.lblObj21.Location = new System.Drawing.Point(229, 124);
            this.lblObj21.Name = "lblObj21";
            this.lblObj21.Size = new System.Drawing.Size(0, 12);
            this.lblObj21.TabIndex = 10;
            // 
            // lblObj22
            // 
            this.lblObj22.AutoSize = true;
            this.lblObj22.Location = new System.Drawing.Point(229, 162);
            this.lblObj22.Name = "lblObj22";
            this.lblObj22.Size = new System.Drawing.Size(0, 12);
            this.lblObj22.TabIndex = 11;
            // 
            // lblObj23
            // 
            this.lblObj23.AutoSize = true;
            this.lblObj23.Location = new System.Drawing.Point(229, 203);
            this.lblObj23.Name = "lblObj23";
            this.lblObj23.Size = new System.Drawing.Size(0, 12);
            this.lblObj23.TabIndex = 12;
            // 
            // RefTypeFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblObj23);
            this.Controls.Add(this.lblObj22);
            this.Controls.Add(this.lblObj21);
            this.Controls.Add(this.lblObj13);
            this.Controls.Add(this.lblObj12);
            this.Controls.Add(this.lblObj11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Name = "RefTypeFor";
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
        private System.Windows.Forms.Label lblObj11;
        private System.Windows.Forms.Label lblObj12;
        private System.Windows.Forms.Label lblObj13;
        private System.Windows.Forms.Label lblObj21;
        private System.Windows.Forms.Label lblObj22;
        private System.Windows.Forms.Label lblObj23;
    }
}

