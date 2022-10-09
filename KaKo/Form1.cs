namespace KaKo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            SIZE size = new SIZE();
            size.ShowDialog(this);
            size.Dispose();
            //операторы вызова диалоговой панели R
            if (GV.nr > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            //операторы вызова диалоговой панели C
            if (GV.nc > 0)
            {
                C ic = new C();
                ic.ShowDialog(this);
                ic.Dispose();
            }
            //операторы вызова диалоговой панели L
            if (GV.nl > 0)
            {
                L il = new L();
                il.ShowDialog(this);
                il.Dispose();
            }
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();

            red.ShowDialog(this);
            red.Dispose();
        }
    }
}