using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace F3TailGoodsList
{
    internal class ImgLoader
    {
        
        private string LocalFolder;
        public ImgLoader ()
        {
             LocalFolder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public bool GetImgFromDisk (string image_id)
        {

            string filename = Path.Combine(LocalFolder,"images", image_id);

            if (!File.Exists(filename))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
