    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace WindowsFormsApplication6
    {
        public partial class Form1 : Form
        {
            int R, G, B;
            int muR, muG, muB;
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                openFileDialog1.Filter = "Archivos bmp|*.bmp|Archivos jpg|*.jpg|Archivos png|*.png|Todos los demas|*.*";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = bmp;
                    pictureBox2.Image = bmp;
                }
            }

            private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color c = new Color();
                c = bmp.GetPixel(e.X, e.Y);
                textBox1.Text = c.R.ToString();
                textBox2.Text = c.G.ToString();
                textBox3.Text = c.B.ToString();
                R = c.R;
                G = c.G;
                B = c.B;
                muR = 0; muG = 0; muB = 0;
                for (int i=e.X-5; i<e.X; i++)
                {
                    for (int j = e.Y - 5; j < e.Y; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        muR = muR + c.R;
                        muG = muG + c.G;
                        muB = muB + c.B;
                    }
                }
                muR = muR / 100;
                muG = muG / 100;
                muB = muB / 100;
                textBox4.Text = muR.ToString();
                textBox5.Text = muG.ToString();
                textBox6.Text = muB.ToString();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp2 = new Bitmap(bmp.Width,bmp.Height);
                Color c = new Color();
                for (int i = 0;i<bmp.Width;i++)
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                    }
            
                pictureBox2.Image = bmp2;
            }

            private void button3_Click(object sender, EventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
                Color c = new Color();
            
                for (int i = 0; i < bmp.Width; i++)
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        bmp2.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                    }
            
                pictureBox2.Image = bmp2;
            }

            private void button4_Click(object sender, EventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
                Color c = new Color();
            
                for (int i = 0; i < bmp.Width; i++)
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        bmp2.SetPixel(i, j, Color.FromArgb(0, 0, c.B));
                    }
                pictureBox2.Image = bmp2;
            }

            private void button5_Click(object sender, EventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
                Color c = new Color();
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        if ((R-10 <= c.R && c.R <= R+10) && 
                            (G-10 <= c.G && c.G <= G+10) &&
                            (B-10 <= c.B && c.B <= B+10))
                            bmp2.SetPixel(i, j, Color.Black);
                        else
                            bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
                pictureBox1.Image = bmp2;

            }

            private void button6_Click(object sender, EventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
                Color c = new Color();
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        if ((R - 10 <= c.R && c.R <= R + 10) &&
                            (G - 10 <= c.G && c.G <= G + 10) &&
                            (B - 10 <= c.B && c.B <= B + 10))
                            bmp2.SetPixel(i, j, Color.Black);
                        else
                            bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    


                    }
                }
                pictureBox1.Image = bmp2;
            }

            private void button6_Click_1(object sender, EventArgs e)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
                int mR=0, mG=0, mB=0;
                Color c = new Color();
                for (int i = 0; i < bmp.Width-10; i=i+10)
                {
                    for (int j = 0; j < bmp.Height-10; j=j+10)
                    {
                        mR = 0; mG = 0; mB = 0;
                        for (int p = i; p < i + 10; p++)
                            for (int q = j; q < j + 10; q++) 
                            {
                                c = bmp.GetPixel(i, j);
                                mR = mR + c.R;
                                mG = mG + c.G;
                                mB = mB + c.B;
                            }
                        mR = mR / 100;
                        mG = mG / 100;
                        mB = mB / 100;
                        if ((muR - 10 <= mR && mR <= muR + 10) &&
                            (muG - 10 <= mG && mG <= muG + 10) &&
                            (muB - 10 <= mB && mB <= muB + 10))
                        {
                            for (int p = i; p < i + 10; p++)
                                for (int q = j; q < j + 10; q++)
                                {
                                    bmp2.SetPixel(p, q, Color.Black);
                                }
                        }
                        else
                        {
                            for (int p = i; p < i + 10; p++)
                                for (int q = j; q < j + 10; q++)
                                {
                                    c = bmp.GetPixel(p, q);
                                    bmp2.SetPixel(p, q, Color.FromArgb(c.R, c.G, c.B));
                                }
                        }
                        //bmp2.SetPixel(i, j, Color.FromArgb(mR,mG,mB));
                    }
                }

                pictureBox1.Image = bmp2;
                //textBox4.Text = mR.ToString();
            }

            private void textBox8_TextChanged(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                /*comboBox1.Items.Add("Rojo");
                comboBox1.Items.Add("Negro");
                comboBox1.Items.Add("Celeste");
               
                SqlConnection con = new SqlConnection();
                
                
                con.ConnectionString = "server=(local);user=multi;pwd=admin;database=imagenes";
                

                SqlDataAdapter ada = new SqlDataAdapter();
                ada.SelectCommand = new SqlCommand();
                ada.SelectCommand.CommandText = "select * from texturas";
                ada.SelectCommand.Connection = con;
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];*/
            }
            private void Form1_Load(object sender, EventArgs e)
            {
                comboBox1.Items.Add("Rojo");
                comboBox1.Items.Add("Negro");
                comboBox1.Items.Add("Celeste");

                SqlConnection con = new SqlConnection();


                con.ConnectionString = "server=(local);user=multi;pwd=admin;database=imagenes";


                SqlDataAdapter ada = new SqlDataAdapter();
                ada.SelectCommand = new SqlCommand();
                ada.SelectCommand.CommandText = "select * from texturas";
                ada.SelectCommand.Connection = con;
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            private void CalcularPromedioColor()
            {
                if (pictureBox1.Image == null) return;

                Bitmap bmp = new Bitmap(pictureBox1.Image);
                muR = muG = muB = 0;

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color c = bmp.GetPixel(i, j);
                        muR += c.R;
                        muG += c.G;
                        muB += c.B;
                    }
                }

                int total = bmp.Width * bmp.Height;
                muR /= total;
                muG /= total;
                muB /= total;

                textBox4.Text = muR.ToString();
                textBox5.Text = muG.ToString();
                textBox6.Text = muB.ToString();
            }
            private void button7_Click(object sender, EventArgs e)
            {
                int Rc=0,Gc=0,Bc=0;
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                string sql = string.Empty;
                con.ConnectionString = "server=(local);user=multi;pwd=admin;database=imagenes";
                cmd.Connection = con;
                if (comboBox1.Text.Trim() == "Rojo")
                {
                    Rc=237; Gc=28; Bc=36;
                }
                if (comboBox1.Text.Trim() == "Celeste")
                {
                    Rc=0; Gc=255; Bc=255;
                }
                sql = "insert into texturas(descripcion,red,green,blue,redcambio,greencambio,bluecambio)";
                sql = sql+"values('"+textBox8.Text+"',"+textBox4.Text+","+textBox5.Text+","+textBox6.Text+","+Rc+","+Gc+","+Bc+")";
                cmd.CommandText = sql;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlDataAdapter ada = new SqlDataAdapter();
                ada.SelectCommand = new SqlCommand();
                ada.SelectCommand.CommandText = "select * from texturas";
                ada.SelectCommand.Connection = con;
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }



            
            /// Convierte una imagen a escala de grises.
            
            private Bitmap ConvertirAGris(Bitmap imagenOriginal)
            {
                Bitmap gris = new Bitmap(imagenOriginal.Width, imagenOriginal.Height);
                for (int i = 0; i < imagenOriginal.Width; i++)
                {
                    for (int j = 0; j < imagenOriginal.Height; j++)
                    {
                        Color pixel = imagenOriginal.GetPixel(i, j);
                        // Fórmula de luminancia para escala de grises
                        int valorGris = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                        gris.SetPixel(i, j, Color.FromArgb(valorGris, valorGris, valorGris));
                    }
                }
                return gris;
            }

            
            private Bitmap DetectarBordesSobel(Bitmap imagenOriginal)
            {
                if (imagenOriginal == null) return null;

                // 1. Convertir la imagen a escala de grises
                Bitmap imagenGris = ConvertirAGris(imagenOriginal);
                int ancho = imagenGris.Width;
                int alto = imagenGris.Height;
                Bitmap imagenBordes = new Bitmap(ancho, alto);

                // Matriz para almacenar los valores de intensidad de los píxeles grises.
                // Usaremos este array para calcular el gradiente.
                int[,] matrizGris = new int[ancho, alto];

                for (int i = 0; i < ancho; i++)
                {
                    for (int j = 0; j < alto; j++)
                    {
                        matrizGris[i, j] = imagenGris.GetPixel(i, j).R; // R, G, o B son iguales en gris
                    }
                }

                // Kernels de Sobel
                // Gx (Detección de bordes verticales)
                int[,] Gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
                // Gy (Detección de bordes horizontales)
                int[,] Gy = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

                // Umbral de sensibilidad para el borde. Ajusta si los bordes son muy débiles.
                int umbral = 100;

                // 2. Aplicar la convolución (Sobel)
                // Iteramos sobre todos los píxeles, excluyendo un borde de 1 píxel (por el kernel 3x3)
                for (int x = 1; x < ancho - 1; x++)
                {
                    for (int y = 1; y < alto - 1; y++)
                    {
                        int sumaX = 0; // Gradiente en dirección X
                        int sumaY = 0; // Gradiente en dirección Y

                        // Recorrer el kernel 3x3
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int pX = x + i;
                                int pY = y + j;
                                int valorPixel = matrizGris[pX, pY];

                                // Convolución con Gx y Gy
                                sumaX += valorPixel * Gx[i + 1, j + 1];
                                sumaY += valorPixel * Gy[i + 1, j + 1];
                            }
                        }

                        // 3. Calcular la magnitud del gradiente
                        // La magnitud del borde se calcula con la norma euclidiana o, 
                        // para simplificar y acelerar, con la suma de valores absolutos.
                        int magnitud = (int)Math.Sqrt(sumaX * sumaX + sumaY * sumaY);
                        // int magnitud = Math.Abs(sumaX) + Math.Abs(sumaY); // Opción más rápida

                        // Asegurarse de que el valor no exceda 255
                        if (magnitud > 255) magnitud = 255;
                        if (magnitud < 0) magnitud = 0;

                        // 4. Aplicar umbral y dibujar el borde
                        int colorBorde;
                        if (magnitud > umbral)
                        {
                            // Si la magnitud supera el umbral, es un borde (color blanco)
                            colorBorde = 255;
                        }
                        else
                        {
                            // Si no, no es un borde (color negro)
                            colorBorde = 0;
                        }

                        imagenBordes.SetPixel(x, y, Color.FromArgb(colorBorde, colorBorde, colorBorde));
                    }
                }

                // Rellenar los bordes de 1 píxel que excluimos con negro
                for (int i = 0; i < ancho; i++)
                {
                    imagenBordes.SetPixel(i, 0, Color.Black);
                    imagenBordes.SetPixel(i, alto - 1, Color.Black);
                }
                for (int j = 0; j < alto; j++)
                {
                    imagenBordes.SetPixel(0, j, Color.Black);
                    imagenBordes.SetPixel(ancho - 1, j, Color.Black);
                }

                return imagenBordes;
            }

            private void button8_Click(object sender, EventArgs e)
            {
                if (pictureBox1.Image != null)
                {
                    // Asegúrate de que estás trabajando con una copia mutable del Bitmap
                    Bitmap bmpOriginal = new Bitmap(pictureBox1.Image);
                    Bitmap bmpBordes = DetectarBordesSobel(bmpOriginal);

                    // Muestra la imagen resultante en el PictureBox2
                    pictureBox2.Image = bmpBordes;
                }
                else
                {
                    MessageBox.Show("Primero carga una imagen con el Botón 1.", "Error");
                }
            }

        }
    }
