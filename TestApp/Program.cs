using CatalogLib;
using OrderProcessingLib;
using CRMLib;

//Dotnet CLI
//dotnet new console -o testapp

// Entry Point logic:Main function logic
int number=45;
number++;

Console.WriteLine("Number= "+number);
Console.WriteLine("hello,world!");


Product p1 = new Product();
p1.Id=12;
p1.Title="Rose";
p1.Description="Valentine Flower";
p1.UnitPrice=25;
p1.StockAvailable=6000;
p1.ImageUrl="http://akashajab";


Order o1=new Order();
o1.OrderId=45;
o1.OrderDate=new DateTime(2022,12,8);  //yyyy-mm-dd
o1.Customer ="Microsoft";
o1.TotalAmount=67000;
o1.Status="approved";


Customer c1 =new Customer();
c1.Id=550;
c1.FirstName="Akash";
c1.LastName="Ajab";
c1.Email="akashajab1234@gamil.com";
c1.ContactNumber="9881571268";



Console.WriteLine(c1.FirstName +" "+c1.LastName);
Console.WriteLine(p1.Title+" "+p1.Description+" "+p1.StockAvailable+" "+p1.ImageUrl);
Console.WriteLine(o1.Customer +" "+ o1.OrderDate +" "+o1.TotalAmount+" "+o1.Status);