using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasData
                 (
                     new About
                     {
                         Id = 1,
                         Title = "Avukat Melda Özkara",
                         Content = "Melda ÖZKARA Hukuk & Danışmanlık olarak, hukukun çeşitli alanlarında hizmet vermektedir. Kurucumuz Avukat Melda ÖZKARA ile hukuk alanındaki akademik ve profesyonel temellerimizi atmış bulunmaktayız. Ceza hukuku, idare hukuku, sigorta hukuku, aile hukuku ve miras hukuku olmak üzere geniş bir yelpazede hizmet sunuyoruz. Ankara, İzmir, Denizli, Balıkesir, Van, Eskişehir, İstanbul gibi Türkiyenin değişik birçok illerinde çeşitli dosyalarda çalışmakta, davalarda avukatlık hizmeti verilmektedir. \r\n\r\nMisyonumuz, müvekkillerimizin hukuki süreçlerde karşılaştıkları zorluklar karşısında güvenilir ve etkin çözümler üretmek, onların haklarını en üst düzeyde temsil etmektir. Adaletin temsil edildiği her alanda, müvekkillerimizin yanında olmayı ilke edinmiş bir hukuk bürosuyuz. Her bir dava ve müvekkilimizle özel olarak ilgilenir, onların ihtiyaç ve beklentilerine göre şekillenen hukuki stratejiler geliştiririz.\r\n\r\nVizyonumuz, hukukun sunduğu imkanları en doğru ve etkili şekilde kullanarak müvekkillerimizin yaşam kalitesini artırmak ve hukuki süreçlerini olabildiğince sorunsuz bir şekilde yönetmektir. Melda ÖZKARA Hukuk & Danışmanlık olarak, sürekli eğitim ve gelişim içinde olan bir ekip olarak, yasal mevzuatlardaki güncellemeleri takip eder, bu bilgiler ışığında müvekkillerimize en güncel ve doğru bilgiyi sunmayı hedefleriz.\r\n\r\nHukuk büromuz, etik değerlere sıkı sıkıya bağlı kalarak, her zaman şeffaflık ve dürüstlük ilkeleri üzerine kurulu bir hizmet anlayışı benimsemiştir. Melda ÖZKARA Hukuk & Danışmanlık, sizin ve sevdiklerinizin haklarını koruyacak, adaletli çözümler sunacak güvenilir bir ortağınızdır.",
                         CreatedBy = "Songül Hilaloğlu",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false 
                     }
                 );
        }
    }
}
