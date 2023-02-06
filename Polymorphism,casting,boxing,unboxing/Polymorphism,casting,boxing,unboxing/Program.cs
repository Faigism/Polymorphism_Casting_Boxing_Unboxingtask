using StoreClass;
using System;

namespace Polymorphism_casting_boxing_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araz product= new Araz();
            string pr;
            do
            {
                Console.WriteLine("\n============Araz Supermarket============");
                Console.WriteLine("\n1. Drink product elave et");
                Console.WriteLine("2. Dairy product əlavə et");
                Console.WriteLine("3. Butun productlara bax");
                Console.WriteLine("4. Verilmis nomreli producta bax");
                Console.WriteLine("5. Drink productlara bax");
                Console.WriteLine("6. Dairy productlara bax");
                Console.WriteLine("7. Ada görə axtarış et");
                Console.WriteLine("8. Qiymət aralığına görə axtarış et");
                Console.WriteLine("9. Siyahıdan məhsul sil");
                Console.WriteLine("0. Menudan cix");
                Console.WriteLine("\n===========Seciminizi edin==============");
                pr=Console.ReadLine();

                switch (pr)
                {
                    case "1":
                        
                        Console.WriteLine("Ickinin adini elave edin:");
                        string name=Console.ReadLine();
                        
                        Console.WriteLine("Ickinin qiymetini elave edin:");
                        string priceStr=Console.ReadLine();
                        double price=Convert.ToDouble(priceStr);

                        Console.WriteLine("Ickinin Alcohol faizini elave edin:");
                        string alcoholStr=Console.ReadLine();
                        double alcohol=Convert.ToDouble(alcoholStr);

                        Drink DrProduct = new Drink()
                        {
                            Name = name,
                            Price = price,
                            AlcoholPercent = alcohol,
                        };
                        var newDrink = DrProduct;
                        try
                        {
                            if (!product.HasProductByNo(newDrink.No))
                            {
                                product.AddProduct(newDrink);
                            }
                        }
                        catch (Exception)
                        {

                            throw new Exception("Xeta bas verdi");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Sud mehsulunun adini elave edin:");
                        string name1 = Console.ReadLine();

                        Console.WriteLine("Sud mehsulunun qiymetini elave edin:");
                        string priceStr1 = Console.ReadLine();
                        double price1 = Convert.ToDouble(priceStr1);

                        Console.WriteLine("Sud mehsulunun yagliliq faizini elave edin:");
                        string fatPercentStr = Console.ReadLine();
                        double fatPercent = Convert.ToDouble(fatPercentStr);

                        Dairy DaProduct = new Dairy()
                        {
                            Name = name1,
                            Price = price1,
                            FatPercent = fatPercent,
                        };
                        var newDairy = DaProduct;
                        try
                        {
                            if (!product.HasProductByNo(newDairy.No))
                            {
                                product.AddProduct(newDairy);
                            }
                        }
                        catch (Exception)
                        {

                            throw new Exception("Xeta bas verdi");
                        }
                        break;
                    case "3":
                        foreach (Product item in product.Products)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("Nomreni daxil edin:");
                            string Str = Console.ReadLine();
                            int No = Convert.ToInt32(Str);
                            Product product1=product.GetProductByNo(No);
                            product1.ShowInfo();
                        }
                        catch (Exception)
                        {
                            throw new Exception();
                        }
                        break;
                    case "5":
                        foreach (Product item in product.Products)
                        {
                            if(item is Drink)
                            {
                                item.ShowInfo();
                            }
                        }
                        break;
                    case "6":
                        foreach (Product item in product.Products)
                        {
                            if(item is Dairy)
                            {
                                item.ShowInfo();
                            }
                        }
                        break;
                    case "7":
                        Console.WriteLine("Axtardiginiz mehsulun adini daxil edin");
                        string wantedProduct=Console.ReadLine();
                        foreach (Product item in product.Products)
                        {
                            if (item.Name.Contains(wantedProduct))
                            {
                                item.ShowInfo();
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("Minimum qiymet:");
                        string minStr=Console.ReadLine();
                        double min=Convert.ToDouble(minStr);

                        Console.WriteLine("Maksimum qiymet:");
                        string maxStr=Console.ReadLine();
                        double max=Convert.ToDouble(maxStr);
                        foreach (Product item in product.Products)
                        {
                            if (item.Price >= min && item.Price <= max)
                            {
                                item.ShowInfo();
                            }
                        }
                        break;
                    case "9":
                        Console.WriteLine("Silmek istediyiniz mehsulun nomresini secin");
                        string no2=Console.ReadLine();
                        int no3=Convert.ToInt32(no2);
                        product.RemoveProduct(no3);
                        break;
                    case "0":
                        Console.WriteLine("\nCixmaq istediyinizden eminsinizmi? Y/N");
                        if (Console.ReadLine() == "Y")
                        {
                            pr= "0";
                        }
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir.Zehmet olmasa yeniden secin");
                        break;
                }
            } while (pr!="0");
            

        }
    }
}
