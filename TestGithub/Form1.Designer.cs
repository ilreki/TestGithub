﻿namespace TestGithub
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegiste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegiste
            // 
            this.buttonRegiste.Location = new System.Drawing.Point(345, 366);
            this.buttonRegiste.Name = "buttonRegiste";
            this.buttonRegiste.Size = new System.Drawing.Size(75, 30);
            this.buttonRegiste.TabIndex = 0;
            this.buttonRegiste.Text = "注册";
            this.buttonRegiste.UseVisualStyleBackColor = true;
            this.buttonRegiste.Click += new System.EventHandler(this.buttonRegiste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegiste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegiste;
    }
}

