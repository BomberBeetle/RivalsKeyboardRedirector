using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivalsKeyboardRedirector
{
    class Keyboard
    {
        public IntPtr currentHandle;
        public string name;
        public bool vJoyEnabled;
        public Dictionary<MainWindow.ButtonEnum, string> binds;
        public bool LSAutoRun;
        public bool RSAutoRun;
        public uint vJoyId = 17;

        public int LSUP = 0;
        public int LSDOWN = 0;
        public int LSRIGHT = 0;
        public int LSLEFT = 0;
        public int LSMOD = 2;

        public int RSUP = 0;
        public int RSDOWN = 0;
        public int RSRIGHT = 0;
        public int RSLEFT = 0;
        public int RSMOD = 2;

        public int DUP = 0;
        public int DDOWN = 0;
        public int DRIGHT = 0;
        public int DLEFT = 0;

        public Keyboard(IntPtr handle, string name, bool LSAutoRun = false, bool RSAutoRun = false)
        {
            this.currentHandle = handle;
            this.name = name;
            binds = new Dictionary<MainWindow.ButtonEnum, string>();
            vJoyEnabled = false;
            this.LSAutoRun = LSAutoRun;
            this.RSAutoRun = RSAutoRun;
        }
        public Keyboard(IntPtr handle, string name, Dictionary<MainWindow.ButtonEnum, string> binds, bool LSAutoRun = false, bool RSAutoRun = false)
        {
            this.currentHandle = handle;
            this.name = name;
            this.binds = binds;
            vJoyEnabled = false;
            this.LSAutoRun = LSAutoRun;
            this.RSAutoRun = RSAutoRun;
        }

        public int GetLSY()
        {
            return (16384 + 16384 *LSDOWN/LSMOD - 16384*LSUP / LSMOD) ;
        }

        public int GetLSX()
        {
            return (16384 + 16384 * LSRIGHT / LSMOD - 16384 * LSLEFT / LSMOD) ;
        }

        public int GetRSY()
        {
            return (16384 + 16384 * RSDOWN - 16384 * RSUP ) ;
        }

        public int GetRSX()
        {
            return (16384 + 16384 * RSRIGHT - 16384 * RSLEFT );
        }

        public int GetDY()
        {
            return (16384 + 16384 * DDOWN - 16384 * DUP);
        }

        public int GetDX()
        {
            return (16384 + 16384 * DRIGHT - 16384 * DLEFT);
        }
    }
}
