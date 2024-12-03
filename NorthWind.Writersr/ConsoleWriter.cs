using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writersr;

public class ConsoleWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
            action.CreatedDateTime, action.User, action.Description);
    }
}

