﻿namespace PetStoreBackend.Models
{
    public class ClothingAndAccessories
    {
        public int ClothingAndAccessoriesID { get; set; }
        public int ProductID { get; set; }
        public string CategoryType { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageURL { get; set; }

        public Product Product { get; set; }
    }
}
