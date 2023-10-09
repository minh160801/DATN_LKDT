﻿using shop.Domain.Entities.Base;

namespace shop.Domain.Entities;
public class ProductImage : BaseEntity
{
    public Guid Id { get; set; }
    public string ImagePath { get; set; }
    public string Caption { get; set; }
    public bool IsDefault { get; set; }
    public DateTime CreatedDate { get; set; }
    public int SortOrder { get; set; }
    public Guid ProductId { get; set; }
    public virtual ProductDetail? ProductDetail { get; set; }
}
