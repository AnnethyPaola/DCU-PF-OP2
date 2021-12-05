using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Cuda;




namespace PF
{
    public partial class Form1 : Form
    {

        //variables
        int con = 0;
        Image<Bgr, Byte> currentFrame;
        Capture Grabar;
        CascadeClassifier face;//Rostro
        //font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TraineFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NombrePersonas = new List<string>();
        int ContTrain, numLabels, t;
        string Nombre;
        string Apellido;
        string Estado;
        DataGridView d = new DataGridView();

        private void FrameGrabar(object sender, EventArgs e)
        {
            LBCANTIDAD.Text = "0";
            NombrePersonas.Add("");

            try
            {

                gray = currentFrame.Convert<Gray, Byte>();
                using (CascadeClassifier faceCascade = new CascadeClassifier(Nombre))
                {
                    MCvAvgComp[][] RostrosDetectados = faceCascade.DetectMultiScale(gray, 1.1, 10, new Size(TraineFace.Width / 8, Imagen.Height / 8), Size.Empty);
                    foreach (MCvAvgComp R in RostrosDetectados[0])
                    {
                        t = t + 1;
                        result = currentFrame.Copy(R.Rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                        currentFrame.Draw(R.Rect, new Bgr(Color.Green), 1);

                        NombrePersonas[t - 1] = Nombre;
                        NombrePersonas.Add("");

                        LBCANTIDAD.Text = RostrosDetectados[0].Length.ToString();
                    }
                    t = 0;
                    imageBox1.Image = currentFrame;
                    Nombre = "";
                    Apellido = "";
                    Estado = "";

                    NombrePersonas.Clear();
                }
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);
            }
        }
                            

        private void reconocer()
        {
            try
            {
                Grabar = new Capture();
                Grabar.QueryFrame();
                Application.Idle += new EventHandler(FrameGrabar);
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);
            }
        }

        private void DetenerReconocer()
        {
            try
            {

                Application.Idle -= new EventHandler(FrameGrabar);
                Grabar.Dispose();
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);
            }

        }
        public Form1()
        {
            InitializeComponent();

            face = new CascadeClassifier("haarcascade_frontalface_default.xml");
            try
            {
                ConexionBD.Consultar(d);

                string[] Labels = ConexionBD.Nombre;
                numLabels = ConexionBD.TotalRostros;
                ContTrain = numLabels;

                for (int i = 0; i < numLabels; i++)
                {
                    con = i;
                    Bitmap bmp = new Bitmap(ConexionBD.ConvertBinaryToImg(con));

                    trainingImages.Add(new Image<Gray, byte>(bmp));
                    labels.Add(Labels[i]);

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error" + e);
            }
        }

        private void btncapturar_Click(object sender, EventArgs e)
        {
            try
            {
                ContTrain += ContTrain;
                gray = currentFrame.Convert<Gray, Byte>();
                using (CascadeClassifier faceCascade = new CascadeClassifier(Nombre))
                {
                    MCvAvgComp[][] RostrosDetectados = faceCascade.DetectMultiScale(gray, 1.1, 10, new Size(imagen.Width / 8, image.Height / 8), Size.Empty);
       

                    foreach (MCvAvgComp R in RostrosDetectados[0])
                    {

                        TraineFace = currentFrame.Copy(R.Rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                        break;

                    }
                    TraineFace = result.Resize(100, 100, CV_INTER_CUBIC);
                    trainingImages.Add(TraineFace);

                    imageBox2.Image = TraineFace;
                }
            }


            catch
            {

            } 
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            reconocer();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardardatos_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" && txtapellido.Text != "" && txtcorreo.Text != "" && txttelefono.Text != "" && txtvacuna.Text != "")
            {
                labels.Add(txtnombre.Text);
                labels.Add(txtapellido.Text);
                labels.Add(txtcorreo.Text);
                labels.Add(txttelefono.Text);
                labels.Add(txtvacuna.Text);
                ConexionBD.GuardarImagen(txtnombre.Text, txtapellido.Text, txtcorreo.Text, txttelefono.Text, txtvacuna.Text, ConexionBD.ConvertImgToBinary(imageBox2.Image.Bitmap));


            }

            ConexionBD.Consultar(dataGridView1);
        }

        private void frmRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetenerReconocer();
        }
        }
    }
    