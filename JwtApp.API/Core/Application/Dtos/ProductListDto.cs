﻿namespace JwtApp.API.Core.Application.Dtos
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CayegoryId { get; set; }
    }
}