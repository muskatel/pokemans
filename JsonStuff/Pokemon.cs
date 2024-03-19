using Newtonsoft.Json;

namespace JsonStuff;

public class Pokemon
{
    //must be public
    public int id;
    public name name;
    public string[] type;
    public profile profile;
    
    [JsonProperty(PropertyName = "base")]
    public stats stats;

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


public class stats
{
    public int HP;
    public int Attack;
    public int Defense;
    [JsonProperty(PropertyName = "Sp. Attack")]
    public int SpAttack;
    [JsonProperty(PropertyName = "Sp. Defense")]
    public int SpDefense;
    public int Speed;
}

public class profile
{
    public string height;
    public List<string[]> ability;
}