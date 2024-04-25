namespace PR_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBack = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.label_channel = new System.Windows.Forms.Label();
            this.label_specialization = new System.Windows.Forms.Label();
            this.label_WhoDeveloped = new System.Windows.Forms.Label();
            this.label_Prgoram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.Location = new System.Drawing.Point(400, 187);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 38);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Назад ✔️";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Link.Location = new System.Drawing.Point(140, 131);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(49, 17);
            this.Link.TabIndex = 30;
            this.Link.TabStop = true;
            this.Link.Text = "D1sTc";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // label_channel
            // 
            this.label_channel.AutoSize = true;
            this.label_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_channel.Location = new System.Drawing.Point(13, 131);
            this.label_channel.Name = "label_channel";
            this.label_channel.Size = new System.Drawing.Size(121, 17);
            this.label_channel.TabIndex = 29;
            this.label_channel.Text = "Youtube Channel:";
            // 
            // label_specialization
            // 
            this.label_specialization.AutoSize = true;
            this.label_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_specialization.Location = new System.Drawing.Point(12, 93);
            this.label_specialization.Name = "label_specialization";
            this.label_specialization.Size = new System.Drawing.Size(443, 17);
            this.label_specialization.TabIndex = 28;
            this.label_specialization.Text = "Специальность: Информационные Системы и Программирование";
            // 
            // label_WhoDeveloped
            // 
            this.label_WhoDeveloped.AutoSize = true;
            this.label_WhoDeveloped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WhoDeveloped.Location = new System.Drawing.Point(13, 57);
            this.label_WhoDeveloped.Name = "label_WhoDeveloped";
            this.label_WhoDeveloped.Size = new System.Drawing.Size(311, 17);
            this.label_WhoDeveloped.TabIndex = 27;
            this.label_WhoDeveloped.Text = "Разработал: Филиппов Александр Сергеевич";
            // 
            // label_Prgoram
            // 
            this.label_Prgoram.AutoSize = true;
            this.label_Prgoram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Prgoram.Location = new System.Drawing.Point(12, 11);
            this.label_Prgoram.Name = "label_Prgoram";
            this.label_Prgoram.Size = new System.Drawing.Size(391, 24);
            this.label_Prgoram.TabIndex = 26;
            this.label_Prgoram.Text = "Программа \"Практическая работа №1\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 234);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label_channel);
            this.Controls.Add(this.label_specialization);
            this.Controls.Add(this.label_WhoDeveloped);
            this.Controls.Add(this.label_Prgoram);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Label label_channel;
        private System.Windows.Forms.Label label_specialization;
        private System.Windows.Forms.Label label_WhoDeveloped;
        private System.Windows.Forms.Label label_Prgoram;
    }
}