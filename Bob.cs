using System;

public class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        //He says 'Fine. Be that way!' if you address him without actually saying anything.
        if (IsSilence(statement))
            return "Fine. Be that way!";
        if (IsYelling(statement) == true)
        {
            if (IsQuestion(statement) == true)
                //He answers 'Calm down, I know what I'm doing!' if you yell a question at him.
                return "Calm down, I know what I'm doing!";
            else
                //He answers 'Whoa, chill out!' if you yell at him.
                return "Whoa, chill out!";
        }
        //Bob answers 'Sure.' if you ask him a question.
        if (IsQuestion(statement))
            return "Sure.";
        //He answers 'Whatever.' to anything else.
        return "Whatever.";

    }
    static bool IsSilence(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
            return true;
        return false;
    }

    static bool IsQuestion(string statement)
    {
        if (statement.EndsWith("?"))
            return true;
        return false;
    }

    static bool IsYelling(string statement)
    {
        bool isYelling = false;
        foreach (char ch in statement)
        {
            if (char.IsLetter(ch))
            {
                if (!char.IsUpper(ch))
                {
                    isYelling = false;
                    break;
                }
                else
                {
                    isYelling = true;
                }
            }
        }
        return isYelling;
    }

}