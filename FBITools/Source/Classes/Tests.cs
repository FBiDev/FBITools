using System;

public class Hello
{
    public dynamic asa;
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool Asa()
    {
        Console.WriteLine("hello, world" + "");
        asa = string.Empty.Trim().ToUpper();
        try
        {
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}