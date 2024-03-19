namespace JsonStuff;

public class Pokemon
{
    //must be public
    public int id;
    public name name;
    public string[] type;

    public override string ToString()
    {
        string output = name.english + ": ";
        foreach (string s in type)
        {
            output += $"{s} ";
        }

        return output;
    }
}

public class name
{
    public string english;
    public string japanese;
}


// public class base
// {
//     public int HP;
//     public int Attack;
//     public int Defense;
//     public int Sp.Attack;
//     public int Sp.Defense;
//     public int Speed;
//     }