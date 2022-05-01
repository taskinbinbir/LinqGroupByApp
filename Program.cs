using LinqGroupByApp.Models;



UpdateBasketRequest data = new UpdateBasketRequest();

data.BuyerId = "1";
data.Items = new List<UpdateBasketRequestItemData> {
    new UpdateBasketRequestItemData("1", 1, 2),
    new UpdateBasketRequestItemData("1", 2, 2),
    new UpdateBasketRequestItemData("1", 3, 5),
    new UpdateBasketRequestItemData("2", 2, 5) };
                                   //Id, ProductId, Quantity




var itemsCalculated = data
               .Items
               .GroupBy(x => x.ProductId, x => x, (k, i) => new { productId = k, items = i })
               .Select(groupedItem =>
               {
                   var item = groupedItem.items.First();
                   item.Quantity = groupedItem.items.Sum(i => i.Quantity);
                   return item;
               });

foreach (var i in itemsCalculated)
{
    Console.WriteLine("product id:" + i.ProductId);
    Console.WriteLine("Quantity: " + i.Quantity);
    Console.WriteLine("*****");
}

