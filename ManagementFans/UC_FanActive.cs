namespace ManagementFans
{
    public partial class UC_FanActive : UserControl
    {
        private Thread calculationThread;
        private bool activeButton = true;
        public UC_FanActive()
        {
            InitializeComponent();
        }

        private void BTN_strat_Click(object sender, EventArgs e)
        {
            if (BTN_strat.Enabled == true)
            {
                BTN_strat.Enabled = false;
                activeButton = false;
                BTN_strat.Cursor = Cursors.WaitCursor;
                this.Cursor = Cursors.WaitCursor;
            }

            // Démarrer le calcul intensif dans un thread séparé pour éviter de bloquer l'interface utilisateur
            calculationThread = new Thread(new ThreadStart(PerformIntensiveCalculations));
            calculationThread.Start();
        }

        private void PerformIntensiveCalculations()
        {
            // Effectuer des calculs intensifs pour obtenir un score de résultat
            double score = CalculateScore();

            // Mettre à jour le label avec le score obtenu
            UpdateScoreLabel(score);

            // Arrêter le thread une fois que le calcul est terminé

            Invoke(new MethodInvoker(delegate ()
            {
                BTN_strat.Enabled = true;
                BTN_strat.Cursor = Cursors.Default;
                this.Cursor = Cursors.Default;
            }));

            activeButton = true;
        }

        private double CalculateScore()
        {
            // Algorithme intensif pour calculer un score de résultat
            double result = 0;

            for (int i = 0; i < 4501999; i++)
            {
                result += Math.Pow(Math.Sqrt(i), Math.Log(i + 1));

                double progressPercentage = (double)i / 4501999 * 100;

                UpdateProgressBar((int)progressPercentage);
            }

            // Vous pouvez ajuster la formule pour calculer le score selon vos besoins
            return result;
        }

        private void UpdateProgressBar(int percentage)
        {
            if (PB_status.InvokeRequired)
            {
                // Si l'appel provient d'un thread différent, invoquer la mise à jour de la barre de progression sur le thread principal
                Invoke(new MethodInvoker(delegate ()
                {
                    PB_status.Value = percentage;
                }));
            }
            else
            {
                // Mettre à jour directement la barre de progression si l'appel provient du thread principal
                PB_status.Value = percentage;
            }
        }

        private void UpdateScoreLabel(double score)
        {
            // Mettre à jour le label avec le score obtenu
            if (LBL_score.InvokeRequired)
            {
                // Si l'appel provient d'un thread différent, invoquer la mise à jour du label sur le thread principal
                Invoke(new MethodInvoker(delegate ()
                {
                    LBL_score.Text = "Score de résultat : " + score.ToString();
                }));
            }
            else
            {
                // Mettre à jour directement le label si l'appel provient du thread principal
                LBL_score.Text = "Score de résultat : " + score.ToString();
            }
        }

        private void BTN_menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UC_FanActive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Visible = false;
            }
        }
    }
}
