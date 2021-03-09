using RadioJavan.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Interfaces
{
    public interface IRadioJavanApi
    {
        Task<IResult<RadioJavanLogin>> LoginAsync(string email, string password);

    }
}
