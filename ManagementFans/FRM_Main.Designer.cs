namespace ManagementFans
{
    partial class FRM_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            BT_managementFans = new UI.RoundButton();
            BTN_informationSystem = new UI.RoundButton();
            BTN_info = new Button();
            UC_HardwareVIew = new UC_Hardware();
            SuspendLayout();
            // 
            // BT_managementFans
            // 
            BT_managementFans.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BT_managementFans.BackColor = Color.White;
            BT_managementFans.CornerRadius = 25;
            BT_managementFans.FlatAppearance.BorderSize = 0;
            BT_managementFans.FlatAppearance.MouseDownBackColor = Color.FromArgb(206, 225, 240);
            BT_managementFans.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 249, 252);
            BT_managementFans.FlatStyle = FlatStyle.Flat;
            BT_managementFans.Font = new Font("Carlito", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_managementFans.Image = Properties.Resources.fans;
            BT_managementFans.Location = new Point(108, 25);
            BT_managementFans.Name = "BT_managementFans";
            BT_managementFans.Size = new Size(190, 190);
            BT_managementFans.TabIndex = 0;
            BT_managementFans.Text = "Temperature Ventilation\r\n";
            BT_managementFans.TextAlign = ContentAlignment.BottomCenter;
            BT_managementFans.TextImageRelation = TextImageRelation.ImageAboveText;
            BT_managementFans.UseVisualStyleBackColor = false;
            // 
            // BTN_informationSystem
            // 
            BTN_informationSystem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BTN_informationSystem.BackColor = Color.White;
            BTN_informationSystem.CornerRadius = 25;
            BTN_informationSystem.FlatAppearance.BorderSize = 0;
            BTN_informationSystem.FlatAppearance.MouseDownBackColor = Color.FromArgb(225, 240, 206);
            BTN_informationSystem.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 252, 245);
            BTN_informationSystem.FlatStyle = FlatStyle.Flat;
            BTN_informationSystem.Font = new Font("Carlito", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_informationSystem.Image = (Image)resources.GetObject("BTN_informationSystem.Image");
            BTN_informationSystem.Location = new Point(108, 237);
            BTN_informationSystem.Name = "BTN_informationSystem";
            BTN_informationSystem.Size = new Size(190, 190);
            BTN_informationSystem.TabIndex = 0;
            BTN_informationSystem.Text = "Information hardware";
            BTN_informationSystem.TextAlign = ContentAlignment.BottomCenter;
            BTN_informationSystem.TextImageRelation = TextImageRelation.ImageAboveText;
            BTN_informationSystem.UseVisualStyleBackColor = false;
            // 
            // BTN_info
            // 
            BTN_info.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_info.Image = Properties.Resources.info;
            BTN_info.Location = new Point(1, 405);
            BTN_info.Name = "BTN_info";
            BTN_info.Size = new Size(34, 34);
            BTN_info.TabIndex = 1;
            BTN_info.UseVisualStyleBackColor = true;
            // 
            // UC_HardwareVIew
            // 
            UC_HardwareVIew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UC_HardwareVIew.BackColor = Color.FromArgb(238, 237, 243);
            UC_HardwareVIew.Location = new Point(0, 0);
            UC_HardwareVIew.Name = "UC_HardwareVIew";
            UC_HardwareVIew.Size = new Size(405, 439);
            UC_HardwareVIew.TabIndex = 2;
            // 
            // FRM_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 243);
            ClientSize = new Size(409, 441);
            Controls.Add(UC_HardwareVIew);
            Controls.Add(BTN_info);
            Controls.Add(BTN_informationSystem);
            Controls.Add(BT_managementFans);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management Fans";
            ResumeLayout(false);
        }

        #endregion

        private UI.RoundButton BT_managementFans;
        private UI.RoundButton BTN_informationSystem;
        private Button BTN_info;
        private UC_Hardware UC_HardwareVIew;
    }
}
