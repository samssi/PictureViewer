using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureViewer {
    public class Pictures {
        private List<string> fileNames = new List<string>();
        private int indexPosition = 0;

        public Pictures()
        {

        }

        public Pictures(string[] fileNames) 
        {
            this.fileNames = fileNames.OfType<string>().ToList();
        }

        public String nextImage() {
            if (fileNames.Count > indexPosition+1)
            {
                indexPosition += 1;
                return fileNames[indexPosition];
            }
            indexPosition = 0;
            return fileNames[indexPosition];
            
        }

        public String previousImage()
        {
            if (indexPosition > 0)
            {
                indexPosition -= 1;
                return fileNames[indexPosition];
            }
            indexPosition = fileNames.Count() - 1;
            return fileNames[indexPosition];
            
        }
        public String firstImage()
        {
            indexPosition = 0;
            return fileNames[0];
        }
    }

}
