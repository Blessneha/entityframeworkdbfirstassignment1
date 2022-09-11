using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class ProductRepository
    {
        public assign2Entities1 assign2;

        public ProductRepository()
        {
            assign2 = new assign2Entities1();
        }


        public List<product> GetAllProducts()
        {
            try
            {
                List<product> products = assign2.products.ToList(); 
                return products;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<product>GetproductBypname(string name1)
        {
            try
            {
                List<product> pro = assign2.products.Where(p => p.pname == name1).ToList();
                return pro;

            }
            catch (Exception)
            {

                throw;
            }
        }


        public product GetproductBypid(int id)
        {
            try
            {
                product p = assign2.products.Find(id);
                return p;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddProduct(product p)
        {
            try
            {
                assign2.products.Add(p); //Add Employee to EMployee table
                assign2.SaveChanges(); //to save to record into the EMployee table



            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletProduct(int Id)
        {
            try
            {
                product pro = assign2.products.Find(Id);
                assign2.products.Remove(pro); //Delete Employee from the table
                assign2.SaveChanges(); //to save to record into the EMployee table



            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditProduct(product newProduct)
        {
            try
            {
                product Oldpro = assign2.products.Find(newProduct.pid);
                Oldpro.pprice=newProduct.pprice;
                Oldpro.pname=newProduct.pname;
                
                assign2.SaveChanges(); //to save to record into the EMployee table
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
