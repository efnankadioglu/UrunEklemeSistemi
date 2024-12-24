﻿namespace UrunEklemeSistemi
{
    public class Urun
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public decimal Fiyat { get; set; }
        public int Stok { get; set; }

        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; }



    }
}