using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Data.Entity;

namespace hw6_framework
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

public class Cargo
{
    public int ID { set; get; }
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
        int hashCode = 552537344;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
        hashCode = hashCode * -1521134295 + price.GetHashCode();
        return hashCode;
    }
}// 商品

public class Guest
{
    public int ID { set; get; }
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
        return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
    }
}//客户

public class OrderDetails
{
    public int OrderDetailsId { get; set; }
    public Cargo cargo { set; get; }  //订单明细的商品
    public int count { set; get; }  //订单明细的商品数量
    public double orderDetailsPrice { set; get; } //订单明细的商品总价格
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public OrderDetails()
    {

    }

    public OrderDetails(Cargo cargo, int count)
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
        return o != null && o.cargo.name == cargo.name && o.cargo.price == cargo.price && o.count == count ;
    }

    public override int GetHashCode()
    {
        int hashCode = -346454941;
        hashCode = hashCode * -1521134295 + EqualityComparer<Cargo>.Default.GetHashCode(cargo);
        hashCode = hashCode * -1521134295 + count.GetHashCode();
        hashCode = hashCode * -1521134295 + orderDetailsPrice.GetHashCode();
        return hashCode;
    }
}// 订单明细
public class Order : IComparable
{
    public int OrderId { set; get; }
    public int  orderNumber { set; get; }
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
               orderNumber == order.orderNumber;
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
        Console.WriteLine(orderNumber + " ordered by " + guest.name + " ; Price up to :¥ " + orderPrice);
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

    public override int GetHashCode()
    {
        int hashCode = 398892434;
        hashCode = hashCode * -1521134295 + orderNumber.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<Guest>.Default.GetHashCode(guest);
        hashCode = hashCode * -1521134295 + orderTime.GetHashCode();
        hashCode = hashCode * -1521134295 + orderPrice.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(orderAddress);
        hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(orderDetails);
        return hashCode;
    }
}  //订单

public class OrderService //订单控制
{
    public List<Order> orders { set; get; }

    public OrderService()
    {
        orders = new List<Order>();
    }

    public Order CreateAOrder(Guest guest, Dictionary<Cargo, int> goods, string address)
    {
        Order order = new Order();
        Random random = new Random();  //设置订单id
        order.orderTime = System.DateTime.Now;
        order.orderNumber = int.Parse(order.orderTime.Year + "" + order.orderTime.Month + "" + order.orderTime.Day + "" + random.Next(1000));
        int i = 1;
        foreach (var good in goods) //遍历字典，将所有商品及数量添加到订单中
        {
            OrderDetails orderDetails = new OrderDetails(good.Key, good.Value);
            orderDetails.OrderId = order.orderNumber;
            orderDetails.Order = order;
            orderDetails.OrderDetailsId = int.Parse(order.orderTime.Day + "" + i++);
            order.orderDetails.Add(orderDetails);
        }
        order.reCalculatePrice();  //重新计算订单价格
        order.guest = guest;
        order.orderAddress = address;
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
                    var orderSearchId = from x in orders where x.orderNumber == int.Parse(information.ToString()) select x;
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
            var orderSearchId = from x in orders where x.orderNumber == ID select x;
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
                var orderSearchId = from x in this.orders where x.orderNumber == int.Parse(information.ToString()) orderby x.orderPrice select x;
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
        orders.Sort((p1, p2) => p1.orderNumber - p2.orderNumber);
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
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(outputName, FileMode.Create))
        {
            xmlSerializer.Serialize(fs, orders);
        };
        Console.WriteLine("\n******  serialized as xml:");
        Console.WriteLine(File.ReadAllText(outputName));
        return true;
    }

    public void Import(String inputName)  //从XML文件中载入订单
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(inputName, FileMode.Open))
        {
            List<Order> orders2 = (List<Order>)xmlSerializer.Deserialize(fs);
            Console.WriteLine("\nDeserialized from " + inputName);
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
                if (!has)
                {
                    this.orders.Add(p);
                    p.ToString();
                }
            });
        }
    }
}




