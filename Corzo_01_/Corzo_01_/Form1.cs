namespace Corzo_01_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cPostulante cpostulante = new cPostulante();
        List<cPostulante> list = new List<cPostulante>();

        //bin
        string ruta = "Datos.txt";


        public void ccapturarPostulante()
        {
            for (int cestudiante = 1; cestudiante <= int.Parse(ctxtNumPostulantes.Text); cestudiante = cestudiante + 1)
            {
                cpostulante.nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del Postulante " + cestudiante, "Nombre");
                cpostulante.estatura = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Estatura del Postulante " + cestudiante, "Estatura"));
                cpostulante.peso = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el peso del Postulante " + cestudiante, "Peso"));
                cpostulante.edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el edad del Postulante " + cestudiante, "Edad"));
                cpostulante.género = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el género del Postulante " + cestudiante, "Genero: Escribe M: Masculino o F: Femenino");

                dgvListaPostulantes.Rows.Add(cpostulante.nombre, cpostulante.estatura, cpostulante.peso, cpostulante.edad, cpostulante.género);

                list.Add(cpostulante);

                try
                {

                    if (File.Exists(ruta))
                    {
                        StreamWriter cescribir = new StreamWriter(ruta, append: true);

                        cescribir.WriteLine(cpostulante.nombre + " | " +
                        cpostulante.estatura + " | " +
                        cpostulante.peso + " | " +
                        cpostulante.edad + " | " +
                        cpostulante.género);

                        cescribir.Close();
                    }
                    else
                    {
                        cCrearArchivo();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en los datos: " + ex.Message);
                }

            }

        }

        public void cCrearArchivo()
        {
            try
            {
                StreamWriter cescribir = File.CreateText(ruta);

                foreach (cPostulante dato in list)
                {
                    cescribir.WriteLine(dato.nombre + " | " +
                    dato.estatura + " | " +
                    dato.peso + " | " +
                    dato.edad + " | " +
                    dato.género);

                    cescribir.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        public void cDatosRegistrados()
        {
            if (File.Exists(ruta))
            {

                string[] cdatos = new string[4];
                string cregistro = "";

                StreamReader leer = File.OpenText(ruta);

                dgvListaPostulantes.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    cregistro = leer.ReadLine();
                    cdatos = cregistro.Split('|');

                    dgvListaPostulantes.Rows.Add(cdatos[0].Trim(),
                                           cdatos[1].Trim(),
                                           cdatos[2].Trim(),
                                           cdatos[3].Trim(),
                                           cdatos[4].Trim());
                }

                leer.Close();
            }
        }

        private void cbtnRegistrar_Click(object sender, EventArgs e)
        {
            bool flag = true;

            errorProvider1.SetError(ctxtNumPostulantes, "");

            try
            {
                if (int.Parse(ctxtNumPostulantes.Text) <= 0 || int.Parse(ctxtNumPostulantes.Text) > 99)
                {
                    throw new Exception("No se aceptan valores negativos ni que excedan de 2 dígitos");
                }

                foreach (char c in ctxtNumPostulantes.Text)
                {
                    if (Char.IsLetter(c))
                    {
                        throw new Exception("Solo numeros");
                    }
                }

                if (ctxtNumPostulantes.Text == null || ctxtNumPostulantes.Text == "" || ctxtNumPostulantes.Text.Trim().Length == 0)
                {
                    throw new Exception("No vacio");
                }
                MessageBox.Show("Cantidad registrada con ÉXITO!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(ctxtNumPostulantes, ex.Message);
                flag = false;
            }


            if (flag)
            {
                ccapturarPostulante();
            }
          
        }

        private void cbtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro ? ", "Salir", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbtnLimpiar_Click(object sender, EventArgs e)
        {
            if (ctxtNumPostulantes.Text != "")
            {
                if (MessageBox.Show("¿Seguro?", "Responda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ctxtNumPostulantes.Text = "";

                    MessageBox.Show("Se ha Limpiado con ÉXITO!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay ningun dato por limpiar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cArchivo_Masculino(string[] cdatos)
        {
            cdatos = new string[4];
            string cregistro = "";

            StreamReader leer = File.OpenText(ruta);
            //bin
            StreamWriter cActual1 = new StreamWriter("AptosMasculino_Basquetbol.txt");
   

            while (!leer.EndOfStream)
            {
                cregistro = leer.ReadLine();
                cdatos = cregistro.Split('|');

                //masc
                if (cdatos[4].Trim().Equals("M") &&
                    int.Parse(cdatos[2].Trim()) > 70 &&
                    float.Parse(cdatos[1].Trim()) > 1.7f)
                {
                    cActual1.WriteLine(cdatos[0].Trim() + " | " +
                                       cdatos[1].Trim() + " | " +
                                       cdatos[2].Trim() + " | " +
                                       cdatos[3].Trim() + " | " +
                                       cdatos[4].Trim());
                }
               
            }

            cActual1.Close();

            leer.Close();
        }
        public void cArchivo_Femenino(string[] cdatos)
        {
            cdatos = new string[4];
            string cregistro = "";

            StreamReader leer = File.OpenText(ruta);

            //bin
            StreamWriter cActual2 = new StreamWriter("AptosFemenino_Basquetbol.txt");

            while (!leer.EndOfStream)
            {
                cregistro = leer.ReadLine();
                cdatos = cregistro.Split('|');

               //femi
                 if (cdatos[4].Trim().Equals("F") &&
                    int.Parse(cdatos[2].Trim()) > 60 &&
                    float.Parse(cdatos[1].Trim()) > 1.6f)
                {
                    cActual2.WriteLine(cdatos[0].Trim() + " | " +
                                       cdatos[1].Trim() + " | " +
                                       cdatos[2].Trim() + " | " +
                                       cdatos[3].Trim() + " | " +
                                       cdatos[4].Trim());
                }

            }

            cActual2.Close();

            leer.Close();
        }
        string[] listaM;
        string[] listaF;

        public void cAptos_Masculino(string[] cdatos)
        {
            cdatos = new string[4];
            string cregistro = "";

            StreamReader leer = File.OpenText(ruta);

            clstbVarones.Items.Clear();
           

            while (!leer.EndOfStream)
            {
                cregistro = leer.ReadLine();
                cdatos = cregistro.Split('|');

                
                if (cdatos[4].Trim().Equals("M") &&
                    int.Parse(cdatos[2].Trim()) > 70 &&
                    float.Parse(cdatos[1].Trim()) > 1.7f)
                {
                    clstbVarones.Items.Add(cdatos[0].Trim());
                }
               
            }

            leer.Close();
        }
        public void cAptos_Femenino(string[] cdatos)
        {


            cdatos = new string[4];
            string cregistro = "";

            StreamReader leer = File.OpenText(ruta);

          
            clstbMujeres.Items.Clear();

            while (!leer.EndOfStream)
            {
                cregistro = leer.ReadLine();
                cdatos = cregistro.Split('|');

               
                if (cdatos[4].Trim().Equals("F") &&
                    int.Parse(cdatos[2].Trim()) > 60 &&
                    float.Parse(cdatos[1].Trim()) > 1.6f)
                {
                    clstbMujeres.Items.Add(cdatos[0].Trim());
                }

            }

            leer.Close();
        }
        private void cbtnProcesarMas_Click(object sender, EventArgs e)
        {
            
            
            if (File.Exists(ruta))
            {
                string[] cdatos = new string[4];
                string cregistro = "";
                bool cencontrado = false;

                clstbVarones.Items.Clear();

                StreamReader leer = File.OpenText(ruta);

                while (!leer.EndOfStream)
                {
                    cregistro = leer.ReadLine();
                    cdatos = cregistro.Split('|');

                    cArchivo_Masculino(cdatos);
                    cAptos_Masculino(cdatos);
                }

                leer.Close();
            }
          
        }

        private void cbtnProcesarFem_Click(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                string[] cdatos = new string[4];
                string cregistro = "";
                bool cencontrado = false;

                clstbMujeres.Items.Clear();

                StreamReader leer = File.OpenText(ruta);

                while (!leer.EndOfStream)
                {
                    cregistro = leer.ReadLine();
                    cdatos = cregistro.Split('|');

                    cArchivo_Femenino(cdatos);
                    cAptos_Femenino(cdatos);
                }

                leer.Close();

            }
        }

        private void cbtnOrdenarMas_Click(object sender, EventArgs e)
        {
            listaM = new string[clstbVarones.Items.Count];

            for (int i = 0; i < clstbVarones.Items.Count; i++)
            {
                listaM[i] = clstbVarones.Items[i].ToString();
            }

            Comparison<string> cComparador = new Comparison<string>((ccadena1, ccadena2) => ccadena1.CompareTo(ccadena2));

            Array.Sort<string>(listaM, cComparador);

            cVaronesOrdenado.Items.Clear();

            foreach (string cnombre in listaM)
            {
                cVaronesOrdenado.Items.Add(cnombre);
            }
        }

        private void cbtnOrdenarFem_Click(object sender, EventArgs e)
        {

            listaF = new string[clstbMujeres.Items.Count];

            for (int i = 0; i < clstbMujeres.Items.Count; i++)
            {
                listaF[i] = clstbMujeres.Items[i].ToString();
            }

            Comparison<string> cComparador = new Comparison<string>((ccadena1, ccadena2) => ccadena1.CompareTo(ccadena2));

            Array.Sort<string>(listaF, cComparador);

            cMujeresOrdenado.Items.Clear();

            foreach (string cnombre in listaF)
            {
                cMujeresOrdenado.Items.Add(cnombre);
            }
        }

        public int cbusquedaBinaria(String[] carreglo, String cbusqueda)
        {
            int cizquierda = 0, cderecha = carreglo.Length - 1;

            while (cizquierda <= cderecha)
            {
                int cMedio = (int)Math.Floor((cizquierda + cderecha) / 2.0);
                String elementoDelMedio = carreglo[cMedio];

                int cComparacion = cbusqueda.CompareTo(elementoDelMedio);

                if (cComparacion == 0)
                {
                    return cMedio;
                }

                if (cComparacion < 0)
                {
                    cderecha = cMedio - 1;
                }
                else
                {
                    cizquierda = cMedio + 1;
                }
            }
            return -1;
        }

        private void cbtnBuscarMas_Click(object sender, EventArgs e)
        {

            int celem_posicion = cbusquedaBinaria(listaM, ctxtMasBuscar.Text);

            if (celem_posicion < 0)
            {
                MessageBox.Show("El elemento buscado no existe.", "Resultado");
            }
            else
            {
                MessageBox.Show("El elemento buscado se encuentra en la posición "
                     + celem_posicion, "Resultado");
            }

        }

        private void cbtnBuscarFem_Click(object sender, EventArgs e)
        {
            int celem_posicion = cbusquedaBinaria(listaF, ctxtFemBuscar.Text);

            if (celem_posicion < 0)
            {
                MessageBox.Show("El elemento buscado no existe.", "Resultado");
            }
            else
            {
                MessageBox.Show("El elemento buscado se encuentra en la posición  "
                     + celem_posicion, "Resultado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cValores_Masculino;
            cValores_Masculino = new string[4];
            string cRegistro1 = "";
            double cMayor_Masculino = 0;
            string cCapitan_Masculino = "";
            StreamReader cCapitan1 = new StreamReader("AptosMasculino_Basquetbol.txt");
            while (!cCapitan1.EndOfStream)
            {
                cRegistro1 = cCapitan1.ReadLine();
                cValores_Masculino = cRegistro1.Split('|');
                if (cMayor_Masculino < double.Parse(cValores_Masculino[1].Trim()))
                {
                    cMayor_Masculino = double.Parse(cValores_Masculino[1].Trim());
                    cCapitan_Masculino = cValores_Masculino[0].Trim();
                }
            }
            MessageBox.Show("Mayor estatura:" + cMayor_Masculino + "\n Pertenece a:" + cCapitan_Masculino + "", "CAPITAN DEL EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string[] cValoresFem;
            cValoresFem = new string[4];
            string cRegistro2 = "";
            double cMayor_Femenino = 0;
            string cCapitana_Femenino = "";
            StreamReader cCapitan2 = new StreamReader("AptosFemenino_Basquetbol.txt");
            while (!cCapitan2.EndOfStream)
            {
                cRegistro2 = cCapitan2.ReadLine();
                cValoresFem = cRegistro2.Split('|');
                if (cMayor_Femenino < double.Parse(cValoresFem[1].Trim()))
                {
                    cMayor_Femenino = double.Parse(cValoresFem[1].Trim());
                    cCapitana_Femenino = cValoresFem[0].Trim();
                }
            }

            MessageBox.Show("Mayor estatura:" + cMayor_Femenino + "\n Pertenece a:" + cCapitana_Femenino + "", "CAPITANA DEL EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}