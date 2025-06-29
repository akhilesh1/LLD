using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    class ClickOpen : IOpenCloseMechanism
    {
        public void Open()
        {
            Console.WriteLine("Open by Click (Tichuk Tichuk)");
        
        }

        public void Close()
        {
            Console.WriteLine("Close by Click (Tichuk Tichuk)");
    
        }
    }

    class RotateOpen : IOpenCloseMechanism
    {
        public void Open()
        {
            Console.WriteLine("Open by Rotate");
    
        }

        public void Close()
        {
            Console.WriteLine("Close by Rotate");
    
        }
    }


    class CapOpen : IOpenCloseMechanism
    {
        public void Open()
        {
            Console.WriteLine("Open by Cap remove");
    
        }

        public void Close()
        {
            Console.WriteLine("Close by Cap close");
    
        }
    }
}
