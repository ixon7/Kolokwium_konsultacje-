using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    class Panel
    {
        public event EventHandler UP;
        public event EventHandler DOWN;
        public event EventHandler LEFT;
        public event EventHandler RIGHT;

        public void Up()
        {
            UP.Invoke(this, EventArgs.Empty);
        }
        public void Down()
        {
            DOWN.Invoke(this, EventArgs.Empty);
        }
        public void Right()
        {
            RIGHT.Invoke(this, EventArgs.Empty);
        }
        public void Left()
        {
            LEFT.Invoke(this, EventArgs.Empty);
        }
    }
}
