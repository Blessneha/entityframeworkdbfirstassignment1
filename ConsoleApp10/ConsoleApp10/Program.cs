using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductRepository productrepos = new ProductRepository();
            do
            {
                Console.WriteLine("1.GetAllproducts\n2.Getproductbyname\n3.GetproductById\n4.Addproduct\n5.DeleteProduct\n6.EditProduct");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            List<product> pro = productrepos.GetAllProducts();
                            foreach (var p in pro)
                            {
                                Console.WriteLine($"ID:{p.pid} Name:{p.pname} price:{p.pprice}");
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter product Name");
                            string name = Console.ReadLine();
                            List<product> pro = productrepos.GetproductBypname(name);
                            foreach (var p in pro)
                            {
                                Console.WriteLine($"ID:{p.pid} Name:{p.pname} price:{p.pprice}");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter productId");
                            int proId = int.Parse(Console.ReadLine());
                            product pro = productrepos.GetproductBypid(proId);
                            
                            if (pro != null)
                            {
                                Console.WriteLine($"ID:{pro.pid} Name:{pro.pname} price:{pro.pprice}");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;

                    case 4:
                        {
                            product pro = new product();
                            Console.WriteLine("Enter productId");
                            pro.pid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter product name");
                            pro.pname = Console.ReadLine();

                            Console.WriteLine("Enter price");
                            pro.pprice = int.Parse(Console.ReadLine());
                            productrepos.AddProduct(pro);

                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter Id");
                            int Id = int.Parse(Console.ReadLine());
                            productrepos.DeletProduct(Id);
                        }
                        break;
                    case 6:
                        {
                            product pro = new product();
                            Console.WriteLine("Enter productId");
                            pro.pid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter product name");
                            pro.pname = Console.ReadLine();
                            
                            Console.WriteLine("Enter price");
                            pro.pprice = int.Parse(Console.ReadLine());

                            productrepos.EditProduct(pro);

                        }
                        break;

                }
            } while (true);
        }
    }
}
