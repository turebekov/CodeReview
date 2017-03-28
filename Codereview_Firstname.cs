
public class CodeReview 
{
 public int Parse(object o)
    {
        try 
        {
            return int.Parse(o.ToString());
            }
            catch()
            {
                return 0;
                }
     }
     
     public string Concat(string[] lines)

{



if(lines == null) 
{
return string.Empty;
}
string result;
for(int i = 0; i < lines.Length; i++)

{

result += lines[i];

}


return result;

}
}