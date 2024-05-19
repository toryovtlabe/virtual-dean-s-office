using System.IO;
using System.Windows.Media.Imaging;

namespace CourseProject.Helpers
{
    public class ImageToByteConverter
    {
        public static byte[] ImageToByteArray(BitmapImage bitmapImage)
        {
            using (MemoryStream stream = new())
            {
                PngBitmapEncoder encoder = new();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(stream);
                return stream.ToArray();
            }
        }
    }
}
