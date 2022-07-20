namespace Play.Catalog.Contracts
{
    public record CatalogItemAdded(Guid ItemId, string Name, string Description);
    public record CatalogItemModified(Guid ItemId, string Name, string Description);
    public record CatalogItemDeleted(Guid ItemId);
}