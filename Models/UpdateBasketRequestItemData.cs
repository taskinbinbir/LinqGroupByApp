namespace LinqGroupByApp.Models;

public class UpdateBasketRequestItemData
{
    public string Id { get; set; }          // Basket id
    public int ProductId { get; set; }      // Catalog item id
    public int Quantity { get; set; }       // Quantity

    public UpdateBasketRequestItemData(string Id, int ProductId, int Quantity)
    {
        this.Id = Id;
        this.ProductId = ProductId;
        this.Quantity = Quantity;
    }

}
