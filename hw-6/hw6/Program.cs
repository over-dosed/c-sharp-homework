using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace hw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os1 = new OrderService();


            Guest guest1 = new Guest("aaa");
            Guest guest2 = new Guest("bbb");
            Guest guest3 = new Guest("ccc");

            Cargo notebook = new Cargo("notebook", 10.0);
            Cargo ipad = new Cargo("ipad", 4000.0);
            Cargo pencil = new Cargo("pencil", 2.0);
            Cargo juice = new Cargo("juice", 8.0);

            Dictionary<Cargo, uint> goods1 = new Dictionary<Cargo, uint>();
            Dictionary<Cargo, uint> goods2 = new Dictionary<Cargo, uint>();
            Dictionary<Cargo, uint> goods3 = new Dictionary<Cargo, uint>();

            goods1.Add(juice, 5); goods1.Add(notebook, 2500); goods1.Add(ipad, 1);
            goods2.Add(notebook, 5); goods2.Add(juice, 25); goods2.Add(ipad, 1);
            goods3.Add(notebook, 5); goods3.Add(pencil, 25); goods3.Add(juice, 1);

            Order order1 = os1.CreateAOrder(guest1, goods1, "BeiJing");
            Order order2 = os1.CreateAOrder(guest2, goods2, "ShangHai");
            Order order3 = os1.CreateAOrder(guest3, goods3, "GuangZhou");
            os1.addOrder(order1); os1.addOrder(order2); os1.addOrder(order3);

            Console.WriteLine("**********   Order    System    ************");
            while (true)
            {
                Console.WriteLine("Please Input want you want to do : ");
                Console.WriteLine(" 1: add a Order\n 2: delete a Order\n 3: modify a Order\n 4: search a Order\n 5: show all orders");
                Console.WriteLine(" 6: Export to a file\n 7: import from a file\n 8: sort\n 9: Esc");
                Console.WriteLine("**********   Order    System    ************");
                int tab = Console.Read();
                Console.ReadLine();
                if (tab == 57) { break; }
                switch (tab)
                {
                    case 49: //add
                        {
                            Dictionary<Cargo, uint> goods = new Dictionary<Cargo, uint>();  //货物
                            Console.WriteLine("Please input the guest's name:");
                            String guestName = Console.ReadLine();   //客户
                            Guest guest = new Guest(guestName);
                            Console.WriteLine("Please input the address:");
                            String address = Console.ReadLine();  //地址
                            while (true)
                            {
                                Console.WriteLine("Do you want add a cargo ？ Y or N:"); //判断是否想继续输入货物
                                String cargoInput = Console.ReadLine();
                                if (cargoInput == "N" || cargoInput == "Y")
                                {
                                    if (cargoInput == "N") { break; }
                                    else
                                    {
                                        Console.WriteLine("Please input the cargo name:");
                                        String cargoName = Console.ReadLine();
                                        Console.WriteLine("Please input the cargo Price:");
                                        double cargoPrice = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Please input the cargo Count:");
                                        uint cargoCount = uint.Parse(Console.ReadLine());
                                        Cargo cargo = new Cargo(cargoName, cargoPrice);
                                        try   //尝试添加货物进入dictionary
                                        {
                                            goods.Add(cargo, cargoCount);
                                        }
                                        catch (ArgumentException)
                                        {
                                            goods[cargo] += cargoCount;
                                        }
                                    }
                                }

                            }  //将货物输入dictionary
                            os1.addOrder(os1.CreateAOrder(guest, goods, address));
                            break;
                        }
                    case 50: //delete
                        {
                            Console.WriteLine("Please choose the type:");
                            Console.WriteLine("1: ID \t 2: Cargo's name \t 3: Guest's name \t 4: order's price");
                            String typeChoose = Console.ReadLine();
                            Console.WriteLine("please input the information:");
                            String information = Console.ReadLine();
                            switch (typeChoose)
                            {
                                case "1":
                                    {
                                        os1.deleteOrder("ID", information);
                                        break;
                                    }
                                case "2":
                                    {
                                        os1.deleteOrder("cargo_Name", information);
                                        break;
                                    }
                                case "3":
                                    {
                                        os1.deleteOrder("Guest", information);
                                        break;
                                    }
                                case "4":
                                    {
                                        os1.deleteOrder("order_Price", information);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Error type, delete dailed.");
                                        break;
                                    }
                            }  //按照方式删除订单
                            break;
                        }
                    case 51: //modify
                        {
                            Console.WriteLine("Please input the ID: ");  //获取订单id
                            String orderModifyId = Console.ReadLine();

                            //下面新建一个订单，用于替换原有的订单
                            Dictionary<Cargo, uint> goods = new Dictionary<Cargo, uint>();  //货物
                            Console.WriteLine("Please input the guest's name:");
                            String guestName = Console.ReadLine();   //客户
                            Guest guest = new Guest(guestName);
                            Console.WriteLine("Please input the address:");
                            String address = Console.ReadLine();  //地址
                            while (true)
                            {
                                Console.WriteLine("Do you want add a cargo ？ Y or N:"); //判断是否想继续输入货物
                                String cargoInput = Console.ReadLine();
                                if (cargoInput == "N" || cargoInput == "Y")
                                {
                                    if (cargoInput == "N") { break; }
                                    else
                                    {
                                        Console.WriteLine("Please input the cargo name:");
                                        String cargoName = Console.ReadLine();
                                        Console.WriteLine("Please input the cargo Price:");
                                        double cargoPrice = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Please input the cargo Count:");
                                        uint cargoCount = uint.Parse(Console.ReadLine());
                                        Cargo cargo = new Cargo(cargoName, cargoPrice);
                                        try   //尝试添加货物进入dictionary
                                        {
                                            goods.Add(cargo, cargoCount);
                                        }
                                        catch (ArgumentException)
                                        {
                                            goods[cargo] += cargoCount;
                                        }
                                    }
                                }

                            }  //将货物输入dictionary

                            os1.modifyOrder(int.Parse(orderModifyId), os1.CreateAOrder(guest, goods, address));
                            break;
                        }
                    case 52:  //search
                        {
                            Console.WriteLine("Please choose the type:");
                            Console.WriteLine("1: ID \t 2: Cargo's name \t 3: Guest's name \t 4: order's price");
                            String typeChoose = Console.ReadLine();
                            Console.WriteLine("please input the information:");
                            String information = Console.ReadLine();
                            switch (typeChoose)
                            {
                                case "1":
                                    {
                                        os1.showAllOrders(os1.searchOrder("ID", information));
                                        break;
                                    }
                                case "2":
                                    {
                                        os1.showAllOrders(os1.searchOrder("cargo_Name", information));
                                        break;
                                    }
                                case "3":
                                    {
                                        os1.showAllOrders(os1.searchOrder("Guest", information));
                                        break;
                                    }
                                case "4":
                                    {
                                        os1.showAllOrders(os1.searchOrder("order_Price", information));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Error type, search dailed.");
                                        break;
                                    }
                            }  //按照方式删除订单
                            break;
                        }
                    case 53:  //show
                        {
                            os1.showAllOrders();
                            break;
                        }
                    case 54:
                        {
                            Console.WriteLine("Input the file name: ");
                            String fileName = Console.ReadLine();
                            os1.Export(fileName);
                            break;
                        }
                    case 55:
                        {
                            Console.WriteLine("Input the file name: ");
                            String fileName = Console.ReadLine();
                            os1.Import(fileName);
                            break;
                        }
                    case 56:
                        {
                            os1.sortOrder();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            Console.WriteLine("Exit");
        }
    }
}

public class Cargo
{
    public string name { set; get; }
    public double price { set; get; }

    public Cargo()
    {

    }

    public Cargo(String name, double price)
    {
        this.name = name;
        this.price = price;
    }

    new public void ToString()
    {
        Console.WriteLine(name + ": ¥ " + price);
        return;
    }

    public override bool Equals(object obj)
    {
        return obj is Cargo cargo &&
               name == cargo.name &&
               price == cargo.price;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name, price);
    }
}// 商品

public class Guest
{
    public string name { set; get; }

    public Guest()
    {

    }

    public Guest(string name)
    {
        this.name = name;
    }
    new public void ToString()
    {
        Console.WriteLine(name);
        return;
    }

    public override bool Equals(object obj)
    {
        return obj is Guest guest &&
               name == guest.name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name);
    }
}//客户

public class OrderDetails
{
    public Cargo cargo { set; get; }  //订单明细的商品
    public uint count { set; get; }  //订单明细的商品数量
    public double orderDetailsPrice { set; get; } //订单明细的商品总价格

    public OrderDetails()
    {

    }

    public OrderDetails(Cargo cargo, uint count)
    {
        this.cargo = cargo;
        this.count = count;
    } //构造函数

    new public void ToString()
    {
        reCalculatePrice();
        Console.WriteLine(count + " " + cargo.name + " up to ¥ " + orderDetailsPrice);
    }

    public void reCalculatePrice()
    {
        orderDetailsPrice = cargo.price * count;
    }

    public override bool Equals(object obj)
    {
        OrderDetails o = obj as OrderDetails;
        return o != null && o.cargo == cargo && o.count == count && o.orderDetailsPrice == orderDetailsPrice;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(cargo, count, orderDetailsPrice);
    }
}// 订单明细
public class Order : IComparable
{
    public int orderNum { set; get; }
    public Guest guest { set; get; }
    public DateTime orderTime { set; get; }
    public double orderPrice { set; get; }
    public String orderAddress { set; get; }
    public List<OrderDetails> orderDetails { set; get; }

    public Order()
    {
        orderDetails = new List<OrderDetails>();
    }

    public override bool Equals(object obj)
    {
        return obj is Order order &&
               orderNum == order.orderNum;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(orderNum, guest, orderTime, orderPrice, orderAddress, orderDetails);
    }

    public void reCalculatePrice()
    {
        orderPrice = 0;
        foreach (OrderDetails orderDetail in orderDetails)
        {
            orderDetail.reCalculatePrice();
            orderPrice += orderDetail.orderDetailsPrice;
        }
    }

    new public void ToString()
    {
        reCalculatePrice();
        Console.WriteLine(orderNum + " ordered by " + guest.name + " ; Price up to :¥ " + orderPrice);
        foreach (OrderDetails o in orderDetails)
        {
            o.ToString();
        }
        Console.WriteLine(" order time is " + orderTime + " ; order address is : " + orderAddress);
        Console.WriteLine();
    }

    public bool hasTheCargo(string name)
    {
        foreach (OrderDetails orderDetail in orderDetails)
        {
            if (orderDetail.cargo.name == name) return true;
        }
        return false;
    }

    public int CompareTo(object obj2)
    {
        Order order2 = obj2 as Order;
        if (order2 == null) throw new System.ArgumentException();
        return this.orderPrice.CompareTo(order2.orderPrice);
    }


}  //订单

public class OrderService //订单控制
{
    public List<Order> orders { set; get; }

    public OrderService()
    {
        orders = new List<Order>();
    }

    public Order CreateAOrder(Guest guest, Dictionary<Cargo, uint> goods, string address)
    {
        Order order = new Order();
        foreach (var good in goods) //遍历字典，将所有商品及数量添加到订单中
        {
            OrderDetails orderDetails = new OrderDetails(good.Key, good.Value);
            order.orderDetails.Add(orderDetails);
        }
        order.reCalculatePrice();  //重新计算订单价格
        order.guest = guest;
        order.orderTime = System.DateTime.Now;
        order.orderAddress = address;

        Random random = new Random();  //设置订单id
        order.orderNum = int.Parse(order.orderTime.Year + "" + order.orderTime.Month + "" + order.orderTime.Day + "" + random.Next(1000));
        return order;
    } // 通过输入的信息内部生成一个订单对象

    public void addOrder(Order order)  //增加订单
    {

        orders.Add(order); //将设置好的订单添加到订单列表中
    }

    public void deleteOrder(string type, object information)  //删除订单
    {
        try
        {
            switch (type)
            {
                case "ID":
                    var orderSearchId = from x in orders where x.orderNum == int.Parse(information.ToString()) select x;
                    int countId = orderSearchId.Count();
                    if (countId == 0) { throw new Exception(); }
                    for (int i = 0; i < countId; i++)
                    {
                        orders.Remove(orderSearchId.First());
                    }
                    break;
                case "cargo_Name":
                    var orderSearchCargo = from x in orders where x.hasTheCargo((string)information) select x;
                    int countCargo = orderSearchCargo.Count();
                    if (countCargo == 0) { throw new Exception(); }
                    for (int i = 0; i < countCargo; i++)
                    {
                        orders.Remove(orderSearchCargo.First());
                    }
                    break;
                case "Guest":
                    var orderSearchGuest = from x in orders where x.guest.name == (string)information select x;
                    int countGuest = orderSearchGuest.Count();
                    if (countGuest == 0) { throw new Exception(); }
                    for (int i = 0; i < countGuest; i++)
                    {
                        orders.Remove(orderSearchGuest.First());
                    }
                    break;
                case "order_Price":
                    var orderSearchPrice = from x in orders where x.orderPrice == int.Parse(information.ToString()) select x;
                    int countPrice = orderSearchPrice.Count();
                    if (countPrice == 0) { throw new Exception(); }
                    for (int i = 0; i < countPrice; i++)
                    {
                        orders.Remove(orderSearchPrice.First());
                    }
                    break;
                default: Console.WriteLine("ERROR condition"); break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Not Find what you want delete");
        }
    }

    public void modifyOrder(int ID, Order orderModify)  //根据订单号修改订单
    {
        try
        {
            var orderSearchId = from x in orders where x.orderNum == ID select x;
            int countId = orderSearchId.Count();
            if (countId == 0) { throw new Exception(); }
            orders.Remove(orderSearchId.First());
            orders.Add(orderModify);
        }
        catch (Exception)
        {
            Console.WriteLine("Not Find what you want to delete");
        }
    }

    public List<Order> searchOrder(string type, object information)  //查询订单
    {
        List<Order> orders = new List<Order>();
        switch (type)
        {
            case "ID":
                var orderSearchId = from x in this.orders where x.orderNum == int.Parse(information.ToString()) orderby x.orderPrice select x;
                foreach (var x in orderSearchId) { orders.Add(x); }
                return orders;
            case "cargo_Name":
                var orderSearchCargo = from x in this.orders where x.hasTheCargo((string)information) orderby x.orderPrice select x;
                foreach (var x in orderSearchCargo) { orders.Add(x); }
                return orders;
            case "Guest":
                var orderSearchGuest = from x in this.orders where x.guest.name == (string)information orderby x.orderPrice select x;
                foreach (var x in orderSearchGuest) { orders.Add(x); }
                return orders;
            case "order_Price":
                var orderSearchPrice = from x in this.orders where x.orderPrice == int.Parse(information.ToString()) orderby x.orderPrice select x;
                foreach (var x in orderSearchPrice) { orders.Add(x); }
                return orders;
            default: Console.WriteLine("ERROR condition"); return orders;
        }
    }

    public void sortOrder()
    {
        orders.Sort();
    }  //默认排序
    public void sortOrder2()
    {
        orders.Sort((p1, p2) => p1.orderNum - p2.orderNum);
    }  //自定义排序

    public void showAllOrders()
    {
        foreach (Order o in orders)
        {
            o.ToString();
        }
    }   //显示所有订单
    public void showAllOrders(List<Order> orders)
    {
        if (orders.Count == 0)
        {
            Console.WriteLine("Sorry, not find!");
            return;
        }
        foreach (Order o in orders)
        {
            o.ToString();
        }
    }  //传入一个订单列表，显示该订单表所有订单

    public bool Export(String outputName)  //将所有订单序列化
    {
        try
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(outputName, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            };
            Console.WriteLine("\n******  serialized as xml:");
            Console.WriteLine(File.ReadAllText(outputName));
            return true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public void Import(String inputName)  //从XML文件中载入订单
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(inputName, FileMode.Open))
        {
            List<Order> orders2 = (List<Order>)xmlSerializer.Deserialize(fs);
            Console.WriteLine("\nDeserialized from "+ inputName);
            orders2.ForEach(p => p.ToString());
            Console.WriteLine("\nThose orders added to order list:");
            orders2.ForEach(p => {
                bool has = false;
                foreach (Order x in this.orders)
                    {
                        if (p.Equals(x))
                        {
                            has = true;
                            break;
                        }
                    }
                if(!has)
                {
                    this.orders.Add(p);
                    p.ToString();
                }
            });
        }
    }
}

