namespace CarProject
{
    public partial class Form1 : Form
    {
        bool isGasOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void fren_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
        }

        private void gaz_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGasOpen)
            {
                car.Location = new Point(car.Location.X, car.Location.Y - 3);
            }
        }

        private void gaz_Paint(object sender, PaintEventArgs e)
        {
            isGasOpen = true;
        }
    }
}
