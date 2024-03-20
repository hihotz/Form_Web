
namespace Motion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Web_URL2 = new System.Windows.Forms.TextBox();
            this.Web_URL = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GoFront = new System.Windows.Forms.Button();
            this.GoHome = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.FindFile = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 893);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1422, 763);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 130);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1422, 44);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.Web_URL2);
            this.panel8.Controls.Add(this.Web_URL);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(205, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(976, 44);
            this.panel8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "주소 이동";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "단어 검색";
            // 
            // Web_URL2
            // 
            this.Web_URL2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Web_URL2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Web_URL2.Location = new System.Drawing.Point(0, 23);
            this.Web_URL2.Name = "Web_URL2";
            this.Web_URL2.Size = new System.Drawing.Size(976, 21);
            this.Web_URL2.TabIndex = 1;
            this.Web_URL2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Web_URL2_KeyDown);
            // 
            // Web_URL
            // 
            this.Web_URL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Web_URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Web_URL.Location = new System.Drawing.Point(0, 0);
            this.Web_URL.Name = "Web_URL";
            this.Web_URL.Size = new System.Drawing.Size(976, 21);
            this.Web_URL.TabIndex = 0;
            this.Web_URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Web_URL_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.GoFront);
            this.panel6.Controls.Add(this.GoHome);
            this.panel6.Controls.Add(this.GoBack);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 44);
            this.panel6.TabIndex = 1;
            // 
            // GoFront
            // 
            this.GoFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoFront.Location = new System.Drawing.Point(69, 0);
            this.GoFront.Name = "GoFront";
            this.GoFront.Size = new System.Drawing.Size(70, 44);
            this.GoFront.TabIndex = 2;
            this.GoFront.Text = "다음";
            this.GoFront.UseVisualStyleBackColor = true;
            this.GoFront.Click += new System.EventHandler(this.GoFront_Click);
            // 
            // GoHome
            // 
            this.GoHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.GoHome.Location = new System.Drawing.Point(139, 0);
            this.GoHome.Name = "GoHome";
            this.GoHome.Size = new System.Drawing.Size(66, 44);
            this.GoHome.TabIndex = 1;
            this.GoHome.Text = "홈";
            this.GoHome.UseVisualStyleBackColor = true;
            this.GoHome.Click += new System.EventHandler(this.GoHome_Click);
            // 
            // GoBack
            // 
            this.GoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.GoBack.Location = new System.Drawing.Point(0, 0);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(69, 44);
            this.GoBack.TabIndex = 0;
            this.GoBack.Text = "이전";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Search);
            this.panel7.Controls.Add(this.FindFile);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1181, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 44);
            this.panel7.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search.Location = new System.Drawing.Point(0, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(115, 44);
            this.Search.TabIndex = 1;
            this.Search.Text = "검색";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FindFile
            // 
            this.FindFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.FindFile.Location = new System.Drawing.Point(115, 0);
            this.FindFile.Name = "FindFile";
            this.FindFile.Size = new System.Drawing.Size(126, 44);
            this.FindFile.TabIndex = 0;
            this.FindFile.Text = "파일찾기";
            this.FindFile.UseVisualStyleBackColor = true;
            this.FindFile.Click += new System.EventHandler(this.FindFile_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btn1);
            this.panel5.Controls.Add(this.move);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1422, 130);
            this.panel5.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(25, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(222, 55);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "총 동작 횟수";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(266, 12);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(222, 55);
            this.move.TabIndex = 0;
            this.move.Text = "테스트 이동";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 893);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button GoFront;
        private System.Windows.Forms.Button GoHome;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button FindFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Web_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Web_URL2;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button btn1;
    }
}

