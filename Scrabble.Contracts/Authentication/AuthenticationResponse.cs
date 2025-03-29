using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Contracts.Authentication
{
    public record AuthenticationResponse(
        Guid Id,
        string Login,
        string Email,
        string Token
    );
}
