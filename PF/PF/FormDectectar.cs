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
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Emgu.CV.UI;
using Emgu.CV.Util;



namespace PF
{
    public partial class FormDectectar : Form
    {

        //VARIABLES
        int con = 0;
        Image<Bgr, Byte> currentFrame;
        Capture Grabar;
        HaarCascade face;//Rostro
        MCvFont font = new MCvFont(CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX 1.0, 1.0);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NombrePersonas = new List<string>();
        int ContTrain, numLabels, t;
        string Nombre;
        DataGridView d = new DataGridView();
        public FormDectectar()
        {
            InitializeComponent();

            face = new HaarCascade(@"C:\Users\Annethy\OneDrive\Escritorio\ITLA\Cuarto cuatrimestre\DCU\INTENTO DE PROYECTO FINAL\INTENGO 1 PF\PF\PF\haarcascade_frontalface_alt.xml");
            try
            {
                ConexionBD.Consultar(d);
                //
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

                MessageBox.Show("NO HAY ROSTROS REGISTRADO" + e);
            }
        }

        private void FrameGrabar(object sender, EventArgs e)
        {
            LBCANTIDAD.Text = "0";
            NombrePersonas.Add("");

            try
            {
                using (CascadeClassifier faceCascade = new CascadeClassifier(Nombre)) ;
                    currentFrame = Grabar.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);
                using (Image<Gray, Byte> grayImage = currentFrame.Convert<Gray, Byte>())
                 gray = currentFrame.Convert<Gray, Byte>();

                MCvAvgComp[][] RostrosDetectados = DetectMultiScale(grayImage, 1.1, 10, new Size(currentFrame.Width / 8, currentFrame.Height / 8), Size.Empty);

                foreach (MCvAvgComp R in RostrosDetectados[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(R.Rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    currentFrame.Draw(R.Rect, new Bgr(Color.Green), 1);

                    if (trainingImages.ToArray().Length != 0)
                    {
                        MCvTermCriteria Criterio = new MCvTermCriteria(ContTrain, 0.66);

                        EigenObjectRecognizer recogida = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), ref Criterio);
                        var fa = new Image<Gray, byte>[trainingImages.Count];

                        Nombre = recogida.Recognize(result);

                        currentFrame.Draw(Nombre, ref font, new Point(R.Rect.X - 2, R.Rect.Y - 2), new Bgr(Color.Green));
                    }

                    NombrePersonas[t - 1] = Nombre;
                    NombrePersonas.Add("");

                    LBCANTIDAD.Text = RostrosDetectados[0].Length.ToString();
                }
                t = 0;
                imageBox1.Image = currentFrame;
                Nombre = "";
                NombrePersonas.Clear();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            DetenerReconocer();
            this.Hide();
            f.ShowDialog();
            this.Visible = true;
            reconocer();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDectectar_Load(object sender, EventArgs e)
        {

        }
    }
}
