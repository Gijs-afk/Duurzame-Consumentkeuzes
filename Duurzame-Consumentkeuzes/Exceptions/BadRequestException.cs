using Microsoft.VisualBasic;

namespace Duurzame_Consumentkeuzes.Exceptions;

    public class BadRequestException : Exception
    {
        public BadRequestException(string msg) : base(msg)
        { }

    }

