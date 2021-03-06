﻿using System.Collections;
using System.Windows.Forms;
using System;
using System.Collections.Generic;


namespace Snake
{
   public class KeysInput
    {
        private static Hashtable keyTable = new Hashtable();
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}

