﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Application.Services.Authentication
{
    public record AuthenticationResult(
        Guid Id,
        string Login,
        string Email,
        string Token
    );
}
