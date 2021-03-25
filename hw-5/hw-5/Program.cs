using System;
using System.Collections.Generic;

namespace hw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

class Cargo
{
    public string name { set; get; }
    public double price { set; get; }

    public Cargo(String name, double price, uint count)
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
        Console.WriteLine(" order time is " + orderTime + " ; order address is : " + orderAddress);
    }


}  //订单

class OrderService
{
    public List<Order> orders { set; get; }

    public void addOrder()  //增加订单
    {

    }

    public void deleteOrder()  //删除订单
    { 
    
    }

    public void modifyOrder()  //修改订单
    {  
    
    }

    public void searchOrder()  //查询订单
    {

    }
}

