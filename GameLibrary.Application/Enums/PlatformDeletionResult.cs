using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Enums
{
    public enum PlatformDeletionResult
    {
        Deleted,
        NotFound,
        HasLinkedGames
    }
}