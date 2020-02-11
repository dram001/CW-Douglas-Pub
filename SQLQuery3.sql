CREATE VIEW Sales
AS SELECT Orders.OrderID, 
          SUM(OrderDetails.Quantity * Items.Price) AS TotalSales
   FROM OrderDetails, 
        Items, 
        Orders
   WHERE Orders.OrderID = OrderDetails.OrderID AND 
         OrderDetails.ItemId = Items.ID
   GROUP BY Orders.OrderID;
GO