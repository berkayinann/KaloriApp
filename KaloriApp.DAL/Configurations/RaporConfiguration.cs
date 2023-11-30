using KaloriApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.DAL.Configurations
{
    public class RaporConfiguration : IEntityTypeConfiguration<Rapor>
    {
        public void Configure(EntityTypeBuilder<Rapor> builder)
        {
            builder.HasIndex(a => a.KullaniciId).IsUnique();
            builder.HasData
                (
                   new Tarif { ID = 1, YemekAdi = "Kumpir", KaloriMiktari = 800, YapilisTarifi = "Patatesleri haşlayın, içine peynir ve garnitür ekleyin" },
                   new Tarif { ID = 2, YemekAdi = "Omlet", KaloriMiktari = 300, YapilisTarifi = "Yumurtaları çırpın, tavada pişirin, tuz ekleyin" },
                   new Tarif { ID = 3, YemekAdi = "Sebzeli Pilav", KaloriMiktari = 400, YapilisTarifi = "Bulguru kavurun, sebzeleri ekleyin, su ekleyin" },
                   new Tarif { ID = 4, YemekAdi = "Tavuk Izgara", KaloriMiktari = 600, YapilisTarifi = "Tavukları marine edin, ızgarada pişirin" },
                   new Tarif { ID = 5, YemekAdi = "Kahvaltı Tabağı", KaloriMiktari = 500, YapilisTarifi = "Peynir, zeytin, salatalık gibi malzemeleri tabağa yerleştirin" },
                   new Tarif { ID = 6, YemekAdi = "Spagetti Bolognese", KaloriMiktari = 700, YapilisTarifi = "Kıyma ve domates sosu ile spagetti hazırlayın" },
                   new Tarif { ID = 7, YemekAdi = "Mercimek Çorbası", KaloriMiktari = 250, YapilisTarifi = "Mercimeği haşlayın, sebzelerle birlikte kaynatın" },
                   new Tarif { ID = 8, YemekAdi = "Balık Tava", KaloriMiktari = 450, YapilisTarifi = "Balıkları una bulayın, tavada pişirin" },
                   new Tarif { ID = 9, YemekAdi = "Quinoa Salatası", KaloriMiktari = 350, YapilisTarifi = "Quinoa, sebze, ve sos karışımını hazırlayın" },
                   new Tarif { ID = 10, YemekAdi = "Kısır", KaloriMiktari = 320, YapilisTarifi = "Bulgur, yeşillik, ve baharatları karıştırın" },
                   new Tarif { ID = 11, YemekAdi = "Karnabahar Kızartması", KaloriMiktari = 200, YapilisTarifi = "Karnabaharı doğrayın, kızartın" },
                   new Tarif { ID = 12, YemekAdi = "Fırın Tavuk", KaloriMiktari = 550, YapilisTarifi = "Tavukları baharatlayın, fırında pişirin" },
                   new Tarif { ID = 13, YemekAdi = "Domates Çorbası", KaloriMiktari = 180, YapilisTarifi = "Domatesleri rendeleyin, tencerede kaynatın" },
                   new Tarif { ID = 14, YemekAdi = "Ispanak Yemeği", KaloriMiktari = 120, YapilisTarifi = "Ispanakları soteleyin, sarımsak ekleyin" },
                   new Tarif { ID = 15, YemekAdi = "Manti", KaloriMiktari = 480, YapilisTarifi = "Mantıları haşlayın, yoğurt ve sos ekleyin" },
                   new Tarif { ID = 16, YemekAdi = "Çıtır Tavuk", KaloriMiktari = 650, YapilisTarifi = "Tavukları çıtır olana kadar kızartın" },
                   new Tarif { ID = 17, YemekAdi = "Lahmacun", KaloriMiktari = 400, YapilisTarifi = "Kıyma ve baharatları karıştırın, hamura sürün, fırında pişirin" },
                   new Tarif { ID = 18, YemekAdi = "Barbunya Pilaki", KaloriMiktari = 300, YapilisTarifi = "Barbunyaları haşlayın, zeytinyağında pişirin" },
                   new Tarif { ID = 19, YemekAdi = "Kuzu Tandır", KaloriMiktari = 750, YapilisTarifi = "Kuzu etini baharatlayın, fırında uzun süre pişirin" },
                   new Tarif { ID = 20, YemekAdi = "Fasulye Pilaki", KaloriMiktari = 280, YapilisTarifi = "Fasulyeleri haşlayın, zeytinyağında pişirin" }
                );
        }
    }
}
