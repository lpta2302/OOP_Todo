using System.Text.RegularExpressions;

public class Generator
{
    public static int count = 0;
    public static string GenerateId(){
        return (count++).ToString();
        return Regex.Replace(DateTime.Now.ToString(), @"\D", "");
    }
}
