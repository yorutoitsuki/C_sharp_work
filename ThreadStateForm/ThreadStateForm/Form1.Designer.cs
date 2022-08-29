namespace ThreadStateForm
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
            this.btnThreadState = new System.Windows.Forms.Button();
            this.tbThreadState = new System.Windows.Forms.TextBox();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThreadState
            // 
            this.btnThreadState.Location = new System.Drawing.Point(58, 264);
            this.btnThreadState.Name = "btnThreadState";
            this.btnThreadState.Size = new System.Drawing.Size(134, 75);
            this.btnThreadState.TabIndex = 0;
            this.btnThreadState.Text = "스레드 시작";
            this.btnThreadState.UseVisualStyleBackColor = true;
            this.btnThreadState.Click += new System.EventHandler(this.btnThreadState_Click);
            // 
            // tbThreadState
            // 
            this.tbThreadState.Location = new System.Drawing.Point(58, 12);
            this.tbThreadState.Multiline = true;
            this.tbThreadState.Name = "tbThreadState";
            this.tbThreadState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbThreadState.Size = new System.Drawing.Size(437, 246);
            this.tbThreadState.TabIndex = 1;
            // 
            // btnSuspend
            // 
            this.btnSuspend.Location = new System.Drawing.Point(207, 264);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(134, 75);
            this.btnSuspend.TabIndex = 2;
            this.btnSuspend.Text = "일시정지";
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(361, 264);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(134, 75);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "다시 시작";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnSuspend);
            this.Controls.Add(this.tbThreadState);
            this.Controls.Add(this.btnThreadState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThreadState;
        private System.Windows.Forms.TextBox tbThreadState;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnResume;
    }
}

