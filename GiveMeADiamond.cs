using System;
using System.Text;

public class Diamond
{
    public static string print(int n)
    {
        if (n < 0 || (n%2 == 0)) 
            return null;
        var builder = new StringBuilder();
        var si = -(n/2);
        var ei = (n/2);
    
        for (var i = si; i <= ei; i++)
        {
            var spaces = Math.Abs(i);
            var stars = n - (spaces*2);
            builder.Append(new String(' ', spaces));
            builder.Append(new String('*', stars));
            builder.Append('\n');
        }
        
        return builder.ToString();
    }
}
