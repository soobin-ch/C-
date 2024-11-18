﻿namespace _03_PolymoephismWindowsApp
{
    partial class PolymorphismForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolymorphismForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnTankMode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCreateUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(329, 264);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "실행결과";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(7, 196);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(315, 42);
            this.lblResult.TabIndex = 1;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(97, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(257, 134);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(86, 29);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "공격";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(135, 134);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(86, 29);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnTankMode
            // 
            this.btnTankMode.Location = new System.Drawing.Point(14, 134);
            this.btnTankMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTankMode.Name = "btnTankMode";
            this.btnTankMode.Size = new System.Drawing.Size(86, 29);
            this.btnTankMode.TabIndex = 5;
            this.btnTankMode.Text = "시즈모드로";
            this.btnTankMode.UseVisualStyleBackColor = true;
            this.btnTankMode.Click += new System.EventHandler(this.btnTankMode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCreateUnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(329, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "객체생성";
            // 
            // cbCreateUnit
            // 
            this.cbCreateUnit.FormattingEnabled = true;
            this.cbCreateUnit.Items.AddRange(new object[] {
            "SCV",
            "Marine",
            "Tank"});
            this.cbCreateUnit.Location = new System.Drawing.Point(107, 41);
            this.cbCreateUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCreateUnit.Name = "cbCreateUnit";
            this.cbCreateUnit.Size = new System.Drawing.Size(185, 23);
            this.cbCreateUnit.TabIndex = 1;
            this.cbCreateUnit.Text = "Unit을 선택해 주세요.";
            this.cbCreateUnit.SelectedIndexChanged += new System.EventHandler(this.cbCreateUnit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit 생성 : ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "scv.bmp");
            this.imageList1.Images.SetKeyName(1, "Marine.bmp");
            this.imageList1.Images.SetKeyName(2, "Tank-normal.bmp");
            this.imageList1.Images.SetKeyName(3, "tank-siege.bmp");
            // 
            // PolymorphismForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnTankMode);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PolymorphismForm";
            this.Text = "다형성 활용 예제";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnTankMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCreateUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

