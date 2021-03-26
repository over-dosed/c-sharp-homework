using System;
using System.Linq;
using System.Collections.Generic;

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
            goods1.Add(juice, 5); goods1.Add(pencil, 25); goods1.Add(ipad, 1);
            goods2.Add(notebook, 5); goods2.Add(juice, 25); goods2.Add(ipad, 1);
            goods3.Add(notebook, 5); goods3.Add(pencil, 25); goods3.Add(juice, 1);
            os1.addOrder(guest1, goods1, "BeiJing");
            os1.addOrder(guest2, goods2, "ShangHai");
            os1.addOrder(guest3, goods3, "GuangZhou");
            os1.searchOrder("ID", 7878);
            os1.searchOrder("cargo_Name", "pencil");
            os1.searchOrder("Guest", "aaa");
            os1.searchOrder("order_Price", 7878);
            os1.deleteOrder("cargo_Name", "pencil");
            os1.searchOrder("cargo_Name", "pencil");
        }
    }
}

class Cargo
{
    public string name { set; get; }
    public double price { set; get; }

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
}// 商品

class Guest
{
    public string name { set; get; }

    public Guest(string name)
    {
        this.name = name;
    }
    new public void ToString()
    {
        Console.WriteLine(name);
        return;
    }
}//客户


class OrderDetails
{
    public Cargo cargo { set; get; }  //订单明细的商品
    public uint count { set; get; }  //订单明细的商品数量
    public double orderDetailsPrice { set; get; } //订单明细的商品总价格

    public OrderDetails(Cargo cargo,uint count)
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
        return o!= null && o.cargo == cargo && o.count == count && o.orderDetailsPrice == orderDetailsPrice;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(cargo, count, orderDetailsPrice);
    }
}// 订单明细
class Order
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
               orderNum == order.orderNum &&
               EqualityComparer<Guest>.Default.Equals(guest, order.guest) &&
               orderTime == order.orderTime &&
               orderPrice == order.orderPrice &&
               orderAddress == order.orderAddress &&
               EqualityComparer<List<OrderDetails>>.Default.Equals(orderDetails, order.orderDetails);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(orderNum, guest, orderTime, orderPrice, orderAddress, orderDetails);
    }

    public void reCalculatePrice()
    {
        orderPrice = 0;
        foreach(OrderDetails orderDetail in orderDetails)
        {
            orderDetail.reCalculatePrice();
            orderPrice += orderDetail.orderDetailsPrice;
        }
    }

    new public void ToString()
    {
        reCalculatePrice();
        Console.WriteLine(orderNum + " ordered by " + guest.name + " ; Price up to :¥ " + orderPrice);
        foreach(OrderDetails o in orderDetails)
        {
            o.ToString();
        }
        Console.WriteLine(" order time is " + orderTime + " ; order address is : " + orderAddress);
        Console.WriteLine();
    }

    public bool hasTheCargo(string name)
    {
        foreach(OrderDetails orderDetail in orderDetails)
        {
            if (orderDetail.cargo.name == name) return true;
        }
        return false;
    }


}  //订单

class OrderService
{
    public List<Order> orders { set; get; }

    public OrderService()
    {
        orders = new List<Order>();
    }
        
    public void addOrder(Guest guest,Dictionary<Cargo,uint> goods ,string address)  //增加订单
    {
        Order order = new Order();
        foreach(var good in goods) //遍历字典，将所有商品及数量添加到订单中
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
                    for(int i = 0;i< countGuest; i++)
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
        catch(Exception)
        {
            Console.WriteLine("Not Find what you want delete");
        }
    }

    public void modifyOrder()  //修改订单
    {  
        
    }

    public void searchOrder(string type,object information)  //查询订单
    {
        switch(type)
        {
            case "ID":
                var orderSearchId = from x in orders where x.orderNum == int.Parse(information.ToString()) orderby x.orderPrice select x;
                if(orderSearchId.Count() == 0) { Console.WriteLine("Error: Not Find"); Console.WriteLine(); return ; }
                foreach(var x in orderSearchId) { x.ToString(); }
                break;
            case "cargo_Name":
                var orderSearchCargo = from x in orders where x.hasTheCargo((string)information) orderby x.orderPrice select x;
                if (orderSearchCargo.Count() == 0) { Console.WriteLine("Error: Not Find"); Console.WriteLine(); return; }
                foreach (var x in orderSearchCargo) { x.ToString(); }
                break;
            case "Guest":
                var orderSearchGuest = from x in orders where x.guest.name == (string)information orderby x.orderPrice select x;
                if (orderSearchGuest.Count() == 0) { Console.WriteLine("Error: Not Find"); Console.WriteLine(); return; }
                foreach (var x in orderSearchGuest) { x.ToString(); }
                break;
            case "order_Price":
                var orderSearchPrice = from x in orders where x.orderPrice == int.Parse(information.ToString()) orderby x.orderPrice select x;
                if (orderSearchPrice.Count() == 0) { Console.WriteLine("Error: Not Find"); Console.WriteLine(); return; }
                foreach (var x in orderSearchPrice) { x.ToString(); }
                break;
            default: Console.WriteLine("ERROR condition");break;
        }
    }

    public void sortOrder()
}

