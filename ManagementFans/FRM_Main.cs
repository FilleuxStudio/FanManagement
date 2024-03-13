namespace ManagementFans
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void BTN_informationSystem_Click(object sender, EventArgs e)
        {
            UC_HardwareVIew.Visible = true;
        }
    }
}
