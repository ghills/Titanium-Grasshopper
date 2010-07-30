using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TG.UI
{
    class PictureFactory
    {

        /// <summary>
        /// Different pictures that can be displayed
        /// </summary>
        public enum PicTypes
        {
            SAD_PIC,
            VUV_PIC
        }

        /// <summary>
        /// Get the desired picture object to display
        /// </summary>
        /// <param name="type">Enum type that defines which picture to return</param>
        /// <returns>Bitmap object bound to given picture</returns>
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
