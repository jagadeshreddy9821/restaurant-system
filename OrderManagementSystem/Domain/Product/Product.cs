﻿namespace OrderManagementSystem.Domain.Product
{
    using Restaurant;
    using System;
    using Common;

    /// <summary>
    /// Produkt, który może zostać dodany do zamówienia
    /// </summary>
    public class Product : Entity<Guid>
    {
        /// <summary>
        /// Menu, do którego przypisany jest produkt
        /// </summary>
        public virtual Menu Menu { get; set; }

        /// <summary>
        /// Nazwa produktu
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Kategoria
        /// </summary>
        public virtual ProductCategory ProductCategory { get; set; }
        
        /// <summary>
        /// Detale
        /// </summary>
        public virtual ProductDetails ProductDetails { get; set; }

        /// <summary>
        /// Cena
        /// </summary>
        public virtual decimal Price { get; set; }

        /// <summary>
        /// Opis produktu
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Rabat od ceny w procentach
        /// </summary>
        public virtual int? PercentDiscount { get; set; }

        /// <summary>
        /// Url do zdjęcia produktu
        /// </summary>
        public virtual string PhotoUrl { get; set; }

        /// <summary>
        /// Czy aktywny
        /// </summary>
        public virtual bool Active { get; set; }
    }

}