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
            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?",
                                               "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FILE ofile = new FILE();
                GV.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }

            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();

            red.ShowDialog(this);
            red.Dispose();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            FILE file = new FILE();
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            file.Dispose();
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }
    }
}