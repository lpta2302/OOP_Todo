using System.Text.RegularExpressions;

public class Generator
{
    public static string GenerateId(){
        return Regex.Replace(DateTime.Now.ToString(), @"\D", "");
    }
}
