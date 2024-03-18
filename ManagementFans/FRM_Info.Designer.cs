namespace ManagementFans
{
    partial class FRM_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Info));
            LBL_1 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LBL_1
            // 
            LBL_1.AutoSize = true;
            LBL_1.Location = new Point(65, 44);
            LBL_1.Name = "LBL_1";
            LBL_1.Size = new Size(115, 15);
            LBL_1.TabIndex = 0;
            LBL_1.Text = "Editor : FilleuxStudio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 81);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Version : 0.2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 118);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 0;
            label2.Text = "WebSite : https://filleuxstudio.fr/";
            // 
            // FRM_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 168);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LBL_1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_1;
        private Label label1;
        private Label label2;
    }
}