using RadioJavan.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Interfaces
{
    public interface IResult<out T>
    {
        bool Succeeded { get; }
        T Value { get; }
        ResultInfo Info { get; }
    }
}
