namespace Corzo_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnImagen1_Click(object sender, EventArgs e)
        {
            try
            {
   
                ctxtResultado1.Clear();
                int ci, cj, cfilas;
                do
                {
                    cfilas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Numero de filas: "));
                }
                while (cfilas < 4 || cfilas > 10);

               

                    for (ci = 0; ci <= cfilas; ci++)
                {
                    for (cj = cfilas - ci; cj > 0; cj--)
                    {
                        ctxtResultado1.Text += "     ";
                    }
                    for (cj = 0; cj < ci; cj++)
                    {
                        ctxtResultado1.Text += "  *       ";

                    }
                    ctxtResultado1.Text += Environment.NewLine;
                }

                for (ci = 0; ci <= cfilas; ci++)
                {
                    for (cj = 0; cj <= ci; cj++)
                    {
                        ctxtResultado1.Text += "     ";
                    }
                    for (cj = cfilas - ci - 1; cj > 0; cj--)
                    {
                        ctxtResultado1.Text += "  *       ";

                    }
                    ctxtResultado1.Text += Environment.NewLine;
                }
               
            }
            catch (Exception)

            {

                MessageBox.Show("No hay ningun dato ingresado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImagen2_Click(object sender, EventArgs e)
        {
            
                ctxtResultado2.Clear();
                int cFilas;
                do
                {
                    cFilas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Numero de filas: "));
                }
                while (cFilas < 4 || cFilas > 10);
                int con = cFilas;
                for (int ci = 1; ci <= cFilas; ci++)
                {
                    for (int cj = 1; cj <= cFilas; cj++)
                    {
                        if (cj >= con)
                        {
                            ctxtResultado2.Text += "*\t";
                            if (cj == cFilas) ctxtResultado2.Text += "\t";
                        }
                        else ctxtResultado2.Text += "\t";

                    }
                    con--;

                    for (int cj = 1; cj <= ci; cj++)
                    {

                        ctxtResultado2.Text += "*\t";
                    }
                    ctxtResultado2.Text += Environment.NewLine;
                }
                cFilas = 0;
            
        
        }

        private void cbtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro ? ", "Salir", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}