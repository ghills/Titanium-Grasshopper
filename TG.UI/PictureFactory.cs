using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TG.UI
{
    class PictureFactory
    {
        public enum PicTypes
        {
            SAD_PIC,
            VUV_PIC
        }
        public static Image GetPicture(PicTypes type)
        {
            String filename;
            switch (type)
            {
                case PicTypes.SAD_PIC:
                    filename = "Resources\\Pictures\\lonely.jpg";
                    break;
                default:
                    filename = "Resources\\Pictures\\vuvuzela_red.jpg";
                    break;
            }
            return ( new Bitmap(filename) );
        }
    }
}
