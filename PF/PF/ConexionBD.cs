using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PF
{
    class ConexionBD

    {
        //CONEXION A LA BASE DE DATOS ACCESS
        private static OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source =DCU.accdb;");

        //VARIABLES A UTILIZAR
        public static string[] Nombre;
        public static string[] Apellido;
        public static string[] Correo;
        public static string[] Telefono;
        public static string[] Estado;
        private static byte[] Imagen;
        public static List<byte[]> ListadoImagenes = new List<byte[]>();
        public static int TotalRostros;


        public static bool GuardarImagen(string Nombre, string Apellido, string Correo, string Telefono, string Estado, byte[] Imagen)
        {
            //CERRAR CONEXION
            Conexion.Close();
            //ABRIR CONEXION
            Conexion.Open();
            //COMANDO PARA INSERCTAR LOS VALORES EN LA BASE DE DATOS
            OleDbCommand comando = new OleDbCommand("INSERT INTO ROSTROS (Nombre,Apellido,Correo,Telefono,Estado Imagen) Values ('" + Nombre + "',,'" + Apellido + "','" + Correo + "', '" + Telefono + "', '" + Estado + "'?);", Conexion);
            OleDbParameter parImagen = new OleDbParameter("@Imagen", OleDbType.VarBinary, Imagen.Length);
            parImagen.Value = Imagen;
            comando.Parameters.Add(parImagen);
            int Resultado = comando.ExecuteNonQuery();
            //CERRAR CONEXION
            Conexion.Close();

            return Convert.ToBoolean(Resultado);
        }
        public static DataTable Consultar(DataGridView DATA)
        {
            //ABRIR CONEXION
            Conexion.Open();
            //COMANDO PARA MOSTRAR TODOS LOS REGISTROS QUE CONTIENE LA TABLA
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Rostros;", Conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;
            int Cont = dt.Rows.Count;
            Nombre = new string[Cont];
            Apellido = new string[Cont];
            Correo = new string[Cont];
            Telefono = new string[Cont];
            Estado = new string[Cont];
            //CERRAR CONEXION
            Conexion.Close();
            //
            for (int i = 0; i < Cont; i++)
            {
                Nombre[i] = dt.Rows[i]["Nombre"].ToString();
                Apellido[i] = dt.Rows[i]["Apellido"].ToString();
                Correo[i] = dt.Rows[i]["Correo"].ToString();
                Telefono[i] = dt.Rows[i]["Telefono"].ToString();
                Estado[i] = dt.Rows[i]["Estado"].ToString();
                Imagen = (byte[])dt.Rows[i]["Imagen"];
                ListadoImagenes.Add(Imagen);

            }


            try
            {
                //TAMA;O DE LAS COLUMANAS DE LA TABLA
                DATA.Columns[0].Width = 60;
                DATA.Columns[1].Width = 160;
                DATA.Columns[2].Width = 160;
                DATA.Columns[3].Width = 160;
                DATA.Columns[4].Width = 160;
                DATA.Columns[5].Width = 160;
                DATA.Columns[6].Width = 160;

                for (int i = 0; i < Cont; i++)
                {
                    //TAMA;O DE LAS FINAS EN LA TABLA
                    DATA.Rows[i].Height = 110;
                }
            }
            catch
            {

            }

            TotalRostros = Cont;

            return dt;

        }

        public static byte[] ConvertImgToBinary(Image img)
        {
            Bitmap bmpn = new Bitmap(img);
            MemoryStream Memoria = new MemoryStream();
            bmpn.Save(Memoria, ImageFormat.Bmp);

            byte[] imagen = Memoria.ToArray();

            return imagen;/// arreglo de Binario de la imagen

        }

        public static Image ConvertBinaryToImg(int cantidad)
        {
            Image Imagen;
            byte[] img = ListadoImagenes[cantidad];
            MemoryStream Memoria = new MemoryStream(img);
            Imagen = Image.FromStream(Memoria);
            Memoria.Close();
            return Imagen;
        }
    }
}
