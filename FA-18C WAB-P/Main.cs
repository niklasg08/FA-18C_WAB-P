namespace FA_18C_WAB_P
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            textBox_Ammo.Text = "578";
            textBox_Fuel.Text = "100";
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar_Fuel_ValueChanged()
        {
            label_Fuel.Text = trackBar_Fuel.Value.ToString();
        }

        private void textBox_Fuel_TextChanged()
        {
            if (int.TryParse(textBox_Fuel.Text, out int value))
            {
                if (value >= trackBar_Fuel.Minimum && value <= trackBar_Fuel.Maximum)
                {
                    trackBar_Fuel.Value = value;
                }
            }
        }
    }
}
