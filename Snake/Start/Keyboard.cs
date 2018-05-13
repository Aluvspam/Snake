using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    public class Keyboard
    {

        private static Hashtable keyTable = new Hashtable();
        public static bool KeyPressed(Keys key)//verifica daca s-a apasat tasta
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
        public static void ChangeState(Keys key, bool state)//verifica tasta apasata
        {
            keyTable[key] = state;
        }

    }

}

