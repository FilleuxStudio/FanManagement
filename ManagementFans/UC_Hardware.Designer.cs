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
            LB_InfoHardware = new ListBox();
            SuspendLayout();
            // 
            // LB_InfoHardware
            // 
            LB_InfoHardware.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_InfoHardware.BackColor = Color.White;
            LB_InfoHardware.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_InfoHardware.FormattingEnabled = true;
            LB_InfoHardware.ItemHeight = 15;
            LB_InfoHardware.Location = new Point(13, 5);
            LB_InfoHardware.Name = "LB_InfoHardware";
            LB_InfoHardware.ScrollAlwaysVisible = true;
            LB_InfoHardware.SelectionMode = SelectionMode.MultiExtended;
            LB_InfoHardware.Size = new Size(378, 424);
            LB_InfoHardware.TabIndex = 0;
            LB_InfoHardware.KeyDown += LB_InfoHardware_KeyDown;
            // 
            // UC_Hardware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 243);
            Controls.Add(LB_InfoHardware);
            Name = "UC_Hardware";
            Size = new Size(405, 439);
            VisibleChanged += UC_Hardware_VisibleChanged;
            ResumeLayout(false);
        }

        #endregion

        private ListBox LB_InfoHardware;
    }
}
