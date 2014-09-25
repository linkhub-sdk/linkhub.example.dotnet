namespace Linkhub.example.csharp
{
    partial class frmExample
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(354, 39);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(151, 83);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "파트너 잔액확인";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(197, 39);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(151, 83);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "회원 잔액확인";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 83);
            this.button4.TabIndex = 4;
            this.button4.Text = "토큰발급";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(40, 12);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(465, 21);
            this.TextBox1.TabIndex = 7;
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 145);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.button4);
            this.Name = "frmExample";
            this.Text = "링크허브 SDK 예제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.TextBox TextBox1;
    }
}

