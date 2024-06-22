using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Data.Mappings
{
    public class BlogMap : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasData
                (
                    new Blog
                    {
                        Id = 1,
                        Title = "Likit Rhinoplasti (Burun Dolgusu) Tehlikeli Mi?",
                        Content = "Dolgu ve botox ile burun şekillendirme işlemi (benim verdiğim isimle) Likit Rhinoplasti‘nin temelde üç ana hedef kitlesi vardır;\r\n\r\nBurun operasyonu için yaşı çok genç olan kişiler,\r\nBurunlarında beğenmedikleri, şikayetçi oldukları şey için ameliyat olmaya gerek duymayanlar veya operasyondan çekinenler,\r\nBir ya da birkaç kere burun operasyonu geçirmiş olup, yeni bir operasyon istenmeyenler.\r\nBurun; son derece sinirli ve ince bir damarsal ağ yapısına sahiptir. Özellikle arterlerin oldukça farklı varyasyonları göz önüne alınırsa, bu bölgede yapılacak işlemlerde anatomiye çok hakim olmak ve oldukça dikkatli ve tedbirli davranmak önemlidir.\r\n\r\nİşte, yüzlerce burun operasyonu yapmış bir plastik cerrah olmanın avantajı tam olarak burada ortaya çıkıyor.",
                        ViewCount = 15,
                        CategoryId = 1,
                        ImageId = 1,
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false,
                        UserId = 1
                    },
                    new Blog
                    {
                        Id = 2,
                        Title = "Dudaklarınız Dolgu İçin Uygun Mu?",
                        Content = "Dudak küçük bir anatomik yapı olmasına rağmen yüzün merkezinde bulunması ve duygu durumunu anlık olarak yansıtan tüm mimiklere katılması nedeniyle büyük öneme sahiptir. Dudak dolgusu tahmin edildiği kadar basit ve hızlı bir işlem değildir. Bunun başlıca iki sebebi var;\r\n\r\nDinamik bir organ olması,\r\nÇok dar ve sınırlı bir hacme sahip olması,\r\nYapılan dolgu materyalinin tamamen dokuya entegre olmasını beklemek ve bunu göz önüne alarak birkaç seans şeklinde işlemi sürdürmek gerekir.\r\n\r\nDolayısıyla dudakların alacağı hacim ve kalınlaşma aslında dolguyu yerleştireceğiniz cebi sabırla genişletmek, sonrasında belli olacaktır. Her dudak “istenildiği” ya da “beklenildiği” kadar kalınlaşmaz. Dudak dolgusunu tek seansta ve yüksek dozda uygulamaya çalışmak bu dinamik ve hassas bölgenin bütün dinamiğini geri dönüşümsüz olarak bozar.\r\nSonuç olarak dudak dolgusu zannedildiği kadar kolay, hızlı ve sonuçları memnun edici bir işlem değildir, hatta tecrübesiz ellerde çok büyük hayal kırıklığına sebep olabilir.",
                        ViewCount = 10,
                        CategoryId = 2,
                        ImageId = 1,
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false,
                        UserId = 1
                    }
                );
        }
    }
}
