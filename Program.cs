namespace Assiment_Linq_01
{
    public class Program
    {
        static void Main()
        {
            #region Question_01
            var result01 = Sourse.ProductList
                     .Where(s => s.Category == "Seafood")
                     .Select(s => new { s.ProductName, s.UnitPrice });

            foreach (var item in result01)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Question_02
            var result02 = new List<string>(Sourse.ProductList.Select(s => s.ProductName));
            foreach (var item in result02)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question_03
            var result03 = Sourse.ProductList
                    .OrderBy(s => s.UnitPrice)
                    .Select(s => new { s.ProductName, s.UnitPrice });
            foreach (var item in result03)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question_04
            var result04 = Sourse.ProductList
                        .Where(s => s.UnitPrice >= 10 && s.UnitPrice <= 30)
                        .Select(s => s);
            foreach (var item in result04)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question_05
            var result05 = Sourse.ProductList
                            .Where(s => s.UnitsInStock > 0 && s.Category == "Condiments")
                            .Select(s => s);
            foreach (var item in result05)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question06
            var result06 = Sourse.ProductList.Select(s => new
            {
                Name = s.ProductName,
                Price = s.UnitPrice,
                StockStatus = s.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });
            foreach (var item in result06)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock Status: {item.StockStatus}");
            }
            #endregion

            #region Question07
            int count = 1;
            var result07 = Sourse.ProductList
                .Select(s => s.ProductName);
            foreach (var item in result07)
            {
                Console.WriteLine($"{count++}. {item}");
            }
            #endregion

            #region Question08
            var result08 = Sourse.ProductList
                    .OrderBy(S => S.Category)
                    .ThenByDescending(S => S.UnitPrice);
            foreach (var item in result08)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question09
            var result09 = Sourse.ProductList
                    .Where(s => s.Category == "Beverages")
                    .OrderByDescending(s => s.UnitsInStock)
                    .Select(s => new { s.ProductName, s.UnitsInStock });
            foreach (var item in result09)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question10
            var result10 = from Customer in Sourse.CustomerList
                           from Order in Customer.Orders
                           where Order.OrderDate >= new DateTime(1997, 1, 1)
                           select new { Customer.CustomerID, Order.OrderDate };
            foreach (var item in result10)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question11
            var result11 = Sourse.CustomerList
                    .Select((Name, index) => new { Name.CustomerName, Index = index + 1 });
            foreach (var item in result11)
            {
                Console.WriteLine($"{item.Index}. {item.CustomerName}");
            }
            #endregion

            #region Question12
            var result12 = new List<string> { "Ahmed", "ali", "Mohamed", "mahmod", "Hassan", "hamada", "Omar", "osama" };
            result12 = result12.OrderBy(s => s, StringComparer.Ordinal).ToList();
            foreach (var item in result12)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question13
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result13 = digits
                .Where(s => s[1] == 'i')
                .Reverse();
            foreach (var item in result13)
            {
                Console.WriteLine(item);
            } 
            #endregion



        }
    }
}
