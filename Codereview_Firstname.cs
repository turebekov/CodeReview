namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           object o = 123;
            string[] s = { "hello ", "and ", "welcome ", "to ",
                        "this ", "demo! " };
            string[] a = null;
            var CodeReview = new CodeReview();
            // CodeReview.Parse(o);
            
            CodeReview.Concat(s);
            Console.ReadKey();
        }
        
    }

    class CodeReview
    {
        public int Parse(object o)

        {
            
            

            if (o != null )
            {
                string a = o.ToString();
                int num;

                if (int.TryParse(a, out num))
                {
                    Console.WriteLine(o);
                    return int.Parse(o.ToString());
                    
                }
                else
                {
                    Console.WriteLine("0");
                    return 0;
                    
                }

            }
            else
            {
                
                Console.WriteLine("0");
                return 0;
            }
            
        }


        public string Concat(string[] lines)

        {

            if (lines == null)
            {
                return null;
            }
            string result = string.Empty;
                //string result;
            
                for (int i = 0; i < lines.Length; i++)

                {

                    result += lines[i];

                }
                Console.WriteLine(result);
                return result;
            
            
            

        }
    }

}