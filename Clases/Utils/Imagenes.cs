using iTextSharp.text;

namespace CENDI_admin.Clases.Utils
{
    internal class Imagenes
    {
        /// <summary>
        /// Convierte una imagen en un arreglo de bytes
        /// </summary>
        /// <param name="img">imagen que convertiremos en un arreglo de bytes</param>
        /// <returns>un arreglo de bytes de la imagen ingresada</returns>
        public static byte[] ImagenToByteArray(System.Drawing.Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        /// <summary>
        /// Convierte un arreglo de bytes en una imagen
        /// </summary>
        /// <param name="byteImage">arreglo de bytes</param>
        /// <returns>una imagen construida de un arreglo de bytes</returns>
        public static System.Drawing.Image ByteArrayToImagen(byte[] byteImage)
        {
            using (var ms = new MemoryStream(byteImage))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Genera una imagen para colocar en un archivo PDF 
        /// </summary>
        /// <param name="img">Imagen que convertiremos a una imagen para PDF</param>
        /// <returns></returns>
        public static iTextSharp.text.Image ImgToPDF(Bitmap img)
        {
            BaseColor? color = null;
            return iTextSharp.text.Image.GetInstance(img, color);
        }
    }
}
