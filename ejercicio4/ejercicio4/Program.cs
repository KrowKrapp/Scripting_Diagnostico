using System;

abstract class AbstractSample
{
    private string message;

    public AbstractSample(string message)
    {
        this.message = message;
    }

    public abstract void PrintMessage();

    public virtual void InvertMessage()
    {
        char[] charArray = message.ToCharArray();
        Array.Reverse(charArray);
        message = new string(charArray);
    }

    protected string GetMessage() => message;
}

// Primera subclase
class StandardMessage : AbstractSample
{
    public StandardMessage(string message) : base(message) { }

    public override void PrintMessage()
    {
        Console.WriteLine(GetMessage());
    }
}

// Segunda subclase
class AlternatingCaseMessage : AbstractSample
{
    public AlternatingCaseMessage(string message) : base(message) { }

    public override void PrintMessage()
    {
        string invertedCaseMessage = "";
        foreach (char c in GetMessage())
        {
            if (char.IsUpper(c))
                invertedCaseMessage += char.ToLower(c);
            else if (char.IsLower(c))
                invertedCaseMessage += char.ToUpper(c);
            else
                invertedCaseMessage += c;
        }
        Console.WriteLine(invertedCaseMessage);
    }
}

class CustomInvertMessage : AbstractSample
{
    public CustomInvertMessage(string message) : base(message) { }

    public override void PrintMessage()
    {
        Console.WriteLine(GetMessage());
    }

    public override void InvertMessage()
    {
        base.InvertMessage();
        string modifiedMessage = "";
        foreach (char c in GetMessage())
        {
            if (char.IsUpper(c))
                modifiedMessage += char.ToLower(c);
            else if (char.IsLower(c))
                modifiedMessage += char.ToUpper(c);
            else
                modifiedMessage += c;
        }
        Console.WriteLine(modifiedMessage);
    }
}

class MessageManager
{
    public static void Main()
    {
        AbstractSample message1 = new StandardMessage("Hello World");
        AbstractSample message2 = new AlternatingCaseMessage("Hello World");
        AbstractSample message3 = new CustomInvertMessage("Hello World");

        message1.PrintMessage();
        message2.PrintMessage();
        message3.InvertMessage();
    }
}
