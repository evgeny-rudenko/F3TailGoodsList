using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace F3TailGoodsList
{
    internal class ImagesListFromDir
    {

        public List<string> images = new List<string>();

        /// <summary>
        /// Конструктор 
        /// </summary>
     public   ImagesListFromDir ()
        {

            
            string LocalFolder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string imagesFolder = Path.Combine(LocalFolder, "images");

            if (!Directory.Exists(imagesFolder))
                return;

            string[] imageFiles = Directory.GetFiles(imagesFolder);

            foreach (string image in imageFiles)
            {

                images.Add(Path.GetFileNameWithoutExtension(image));
            }

        }
    
    }
}
