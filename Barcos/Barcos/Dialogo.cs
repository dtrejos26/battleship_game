using System.Collections.Generic;
using System.Drawing;


namespace Barcos
{
    public class Dialogo
    {

        public Image emocion { get; set; }
        public List<string> dialogos { get; set; }


        public Dialogo()
        {

            emocion = null;
            dialogos = new List<string>();

        }

        public Dialogo(List<string> listaD, Image img)
        {

            dialogos = listaD;
            emocion = img;

        }

    }
}
