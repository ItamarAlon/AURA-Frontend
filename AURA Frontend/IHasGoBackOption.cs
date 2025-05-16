using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    internal interface IHasGoBackOption
    {
        public event Action GoToMainScreenRequested;
    }
}
