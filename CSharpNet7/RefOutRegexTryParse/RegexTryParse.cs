
namespace RefOutRegexTryParse
{
    internal class RegexTryParse
    {
        public void CheckNumberByRegex()
        {
            string? str = null;
            Console.WriteLine("Vui lòng nhập số: ");
            str = Console.ReadLine();
            //@("\d{+3}")
            if (new Regex("^[0-9]+$").IsMatch(str))
            {
                int result = int.Parse(str);
                Console.WriteLine($"{nameof(result)}={result}");
            }
            else
            {
                Console.WriteLine("Please Integer");
            }
        }
        public void CheckStringByTryParse() 
        {
            string? str = null;
            Console.WriteLine("Vui lòng nhập double: ");
            str = Console.ReadLine();

            if(double.TryParse(str, out double i)) 
            {
                Console.WriteLine($"{nameof(i)}={i}");
            }
            else
            {
                Console.WriteLine("Please Integer");
            }
        }
        public void TryCatchBug()
        {
            Console.WriteLine("Vui lòng nhập số lượng: ");
            string? amount = Console.ReadLine();
            try
            {
                int total = int.Parse(amount);
                if(total <= 0)
                {
                    throw new Exception("Phải lớn hơn 0");
                }
            }
            catch (Exception) when (amount.Contains("$"))
            {
                Console.WriteLine("amount ko được có dấu $");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType()} : {e.Message}");
                            }
        }
    }
}
