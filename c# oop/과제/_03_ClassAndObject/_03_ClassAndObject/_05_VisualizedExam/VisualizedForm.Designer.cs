namespace _05_VisualizedExam
{
    partial class VisualizedForm
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
            this.gbObject = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TrackBar();
            this.tbX = new System.Windows.Forms.TrackBar();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.tbnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).BeginInit();
            this.SuspendLayout();
            // 
            // gbObject
            // 
            this.gbObject.Location = new System.Drawing.Point(12, 154);
            this.gbObject.Name = "gbObject";
            this.gbObject.Size = new System.Drawing.Size(500, 160);
            this.gbObject.TabIndex = 7;
            this.gbObject.TabStop = false;
            this.gbObject.Text = "생성된 객체";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.tbnCreate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력 정보";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(294, 46);
            this.tbY.Maximum = 150;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(121, 45);
            this.tbY.TabIndex = 12;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(67, 46);
            this.tbX.Maximum = 480;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(126, 45);
            this.tbX.TabIndex = 11;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "승용차",
            "버스"});
            this.cbType.Location = new System.Drawing.Point(72, 20);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 20);
            this.cbType.TabIndex = 8;
            this.cbType.Text = "승용차";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "빨간색",
            "노랑색",
            "녹색",
            "파랑색"});
            this.cbColor.Location = new System.Drawing.Point(294, 20);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 20);
            this.cbColor.TabIndex = 7;
            this.cbColor.Text = "빨간색";
            // 
            // tbnCreate
            // 
            this.tbnCreate.Location = new System.Drawing.Point(199, 81);
            this.tbnCreate.Name = "tbnCreate";
            this.tbnCreate.Size = new System.Drawing.Size(75, 23);
            this.tbnCreate.TabIndex = 4;
            this.tbnCreate.Text = "객체 생성";
            this.tbnCreate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y 좌표 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "X 좌표:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "색깔 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "차종 :";
            // 
            // VisualizedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 326);
            this.Controls.Add(this.gbObject);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisualizedForm";
            this.Text = "생성된 객체와 컨트롤 연동";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbY;
        private System.Windows.Forms.TrackBar tbX;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button tbnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

