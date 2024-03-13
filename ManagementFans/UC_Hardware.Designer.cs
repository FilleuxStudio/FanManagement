namespace ManagementFans
{
    partial class UC_Hardware
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            LV_InfoHardware = new ListView();
            BTN_menu = new Button();
            SuspendLayout();
            // 
            // LV_InfoHardware
            // 
            LV_InfoHardware.BackColor = Color.White;
            LV_InfoHardware.Font = new Font("Consolas", 9.75F);
            LV_InfoHardware.ForeColor = Color.Black;
            LV_InfoHardware.Location = new Point(38, 3);
            LV_InfoHardware.Name = "LV_InfoHardware";
            LV_InfoHardware.Size = new Size(364, 433);
            LV_InfoHardware.TabIndex = 1;
            LV_InfoHardware.UseCompatibleStateImageBehavior = false;
            // 
            // BTN_menu
            // 
            BTN_menu.BackColor = Color.White;
            BTN_menu.Image = Properties.Resources.retour;
            BTN_menu.Location = new Point(3, 3);
            BTN_menu.Name = "BTN_menu";
            BTN_menu.Size = new Size(29, 29);
            BTN_menu.TabIndex = 2;
            BTN_menu.UseVisualStyleBackColor = false;
            BTN_menu.Click += BTN_menu_Click;
            // 
            // UC_Hardware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 243);
            Controls.Add(BTN_menu);
            Controls.Add(LV_InfoHardware);
            Name = "UC_Hardware";
            Size = new Size(405, 439);
            VisibleChanged += UC_Hardware_VisibleChanged;
            KeyDown += UC_Hardware_KeyDown;
            ResumeLayout(false);
        }

        #endregion
        private ListView LV_InfoHardware;
        private Button BTN_menu;
    }
}
