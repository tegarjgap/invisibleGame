using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class MakersException : Exception
    {
        public MakersException(string message) : base(message)
        {

        }
    }

    class OutofBoundException : Exception
    {
        public OutofBoundException(string message) : base(message)
        {

        }
    }
}
