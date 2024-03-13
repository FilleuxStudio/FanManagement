using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementFans
{
    public partial class UC_FanActive : UserControl
    {
        public UC_FanActive()
        {
            InitializeComponent();
        }

        private void BTN_strat_Click(object sender, EventArgs e)
        {
            // Démarrer le calcul intensif dans un thread séparé pour éviter de bloquer l'interface utilisateur
            Thread calculationThread = new Thread(new ThreadStart(PerformIntensiveCalculations));
            calculationThread.Start();
        }

        private void PerformIntensiveCalculations()
        {
            // Effectuer des calculs intensifs pour obtenir un score de résultat
            double score = CalculateScore();

            // Mettre à jour le label avec le score obtenu
            UpdateScoreLabel(score);
        }

        private double CalculateScore()
        {
            // Algorithme intensif pour calculer un score de résultat
            double result = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                result += Math.Pow(Math.Sqrt(i), Math.Log(i + 1));
            }

            // Vous pouvez ajuster la formule pour calculer le score selon vos besoins
            return result;
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
            if(e.KeyCode == Keys.Escape)
            {
                this.Visible = false;
            }
        }
    }
}
