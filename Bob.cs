using System;

public static class Bob
{
    public static string Response(string statement)
    {
        bool isQuestion = false;
        bool isYelling = false;
        //Total five answers !
        //He says 'Fine. Be that way!' if you address him without actually saying anything.
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        //Bob answers 'Sure.' if you ask him a question.
        if (statement.Trim().EndsWith("?"))
            isQuestion = true;

        //He answers 'Whoa, chill out!' if you yell at him.
        //All the letters in the string are capital
        foreach (char ch in statement)
        {
            if (!char.IsUpper(ch) && char.IsLetter(ch))
            {
                isYelling = false;
                break;
            }
            if (char.IsUpper(ch) && char.IsLetter(ch))
            {
                isYelling = true;
            }
        }
        
        //He answers 'Calm down, I know what I'm doing!' if you yell a question at him.
        if (isYelling == true && isQuestion == true)
            return "Calm down, I know what I'm doing!";

        //Bob answers 'Sure.' if you ask him a question.
        if (isQuestion)
            return "Sure.";

        //He answers 'Whoa, chill out!' if you yell at him.
        if (isYelling)
            return "Whoa, chill out!";
        
        
        //He answers 'Whatever.' to anything else.
        return "Whatever.";

    }

}