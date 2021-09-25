using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace adbGUI
{
    class picture_Proc
    {
        public static  Image pic(string path)
        {
          
            Stream stm = File.OpenRead(path);
            BufferedStream d = new BufferedStream(stm);
    //     stm.
            Image img = Image.FromStream(stm);
            byte[] pic_arr=new byte[8192];
           for(int pos=0;pos<d.Length;pos++ )
            {

            }
            return img;
        }
    }
}
