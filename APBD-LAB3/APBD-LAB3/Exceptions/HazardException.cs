using System;

namespace APBD_LAB3.Exceptions;

public class HazardException : Exception
{
    public HazardException()
    {
    }

    public HazardException(string? message) : base(message)
    {
    }

    public HazardException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}