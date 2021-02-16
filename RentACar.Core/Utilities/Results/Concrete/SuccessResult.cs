using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
