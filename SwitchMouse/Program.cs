using System;
using System.Runtime.InteropServices;

namespace SwitchMouse
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        static void Main(string[] args)
        {
            // Setting to True (1) will make the the left button generate right-button messages.
            int buttonstate = SwapMouseButton(1);

            //If SwapMouseButton returned nonzero, then left was already swapped, so swap it back.
            if (buttonstate != 0)
            {
                _ = SwapMouseButton(0);
            }
            /*
             https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-swapmousebutton
             BOOL SwapMouseButton(BOOL fSwap);
             
             Parameter fSwap Type: BOOL
              If this parameter is TRUE, the left button generates right - button messages and the right button generates left - button messages. If this parameter is FALSE, the buttons are restored to their original meanings.
             
             Return Value Type: BOOL
              If the meaning of the mouse buttons was reversed previously, before the function was called, the return value is nonzero.

             If the meaning of the mouse buttons was not reversed, the return value is zero.
            */
        }
    }
}

