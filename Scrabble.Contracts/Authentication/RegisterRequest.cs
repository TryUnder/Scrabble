using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Contracts.Authentication
{
    public record RegisterRequest(
        string Login,
        string Email,
        string Password
    );
}
