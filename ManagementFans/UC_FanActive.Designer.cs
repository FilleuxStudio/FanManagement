namespace ManagementFans
{
    partial class UC_FanActive
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
            BTN_strat = new UI.RoundButton();
            LBL_score = new Label();
            BTN_menu = new Button();
            PB_status = new ProgressBar();
            SuspendLayout();
            // 
            // BTN_strat
            // 
            BTN_strat.BackColor = Color.FromArgb(74, 167, 137);
            BTN_strat.CornerRadius = 25;
            BTN_strat.FlatAppearance.BorderSize = 0;
            BTN_strat.FlatAppearance.MouseDownBackColor = Color.FromArgb(118, 201, 170);
            BTN_strat.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 214, 191);
            BTN_strat.FlatStyle = FlatStyle.Flat;
            BTN_strat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_strat.Location = new Point(117, 79);
            BTN_strat.Margin = new Padding(3, 4, 3, 4);
            BTN_strat.Name = "BTN_strat";
            BTN_strat.Size = new Size(225, 68);
            BTN_strat.TabIndex = 0;
            BTN_strat.Text = "Start";
            BTN_strat.UseVisualStyleBackColor = false;
            BTN_strat.Click += BTN_strat_Click;
            // 
            // LBL_score
            // 
            LBL_score.AutoSize = true;
            LBL_score.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_score.ForeColor = Color.Black;
            LBL_score.Location = new Point(7, 298);
            LBL_score.Name = "LBL_score";
            LBL_score.Size = new Size(121, 30);
            LBL_score.TabIndex = 1;
            LBL_score.Text = "Score : 000";
            // 
            // BTN_menu
            // 
            BTN_menu.BackColor = Color.White;
            BTN_menu.Image = Properties.Resources.retour;
            BTN_menu.Location = new Point(3, 4);
            BTN_menu.Margin = new Padding(3, 4, 3, 4);
            BTN_menu.Name = "BTN_menu";
            BTN_menu.Size = new Size(33, 37);
            BTN_menu.TabIndex = 3;
            BTN_menu.UseVisualStyleBackColor = false;
            BTN_menu.Click += BTN_menu_Click;
            // 
            // PB_status
            // 
            PB_status.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PB_status.Location = new Point(7, 429);
            PB_status.Name = "PB_status";
            PB_status.Size = new Size(446, 34);
            PB_status.TabIndex = 4;
            // 
            // UC_FanActive
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 243);
            Controls.Add(PB_status);
            Controls.Add(BTN_menu);
            Controls.Add(LBL_score);
            Controls.Add(BTN_strat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_FanActive";
            Size = new Size(463, 556);
            KeyDown += UC_FanActive_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UI.RoundButton BTN_strat;
        private Label LBL_score;
        private Button BTN_menu;
        private ProgressBar PB_status;
    }
}
