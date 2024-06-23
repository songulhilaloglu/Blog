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
                        Title = "Adli Kontrol Tedbirlerinde Ölçülülük Şartı",
                        Content = "5271 sayılı Ceza Muhakemesi Kanunu m.109/1, m.100/1 hükümlerine göre, tutuklama ve adli kontrol tedbirleri aynı koşullara bağlı kılınmıştır. Dolayısıyla; bir şüpheli veya sanık hakkında tutuklama kararı verilebilmesi veya kişinin adli kontrol altına alınabilmesi için, kuvvetli suç şüphesini gösteren somut deliller ve en az bir tutuklama nedeni mutlaka bulunmalıdır. Bu tedbirlerin uygulanabilmesi için gerekli olan bir diğer koşul ölçülülüktür.\r\n\r\n \r\n\r\n Adli kontrol tedbirlerinin uygulanabilmesi için, kuvvetli suç şüphesini gösteren somut delillerin bulunması Kanundan kaynaklanan bir zorunluluktur. AYM; bir kararında, konutu terk etmeme yükümlülüğüne tabi tutulması nedeniyle kişi hürriyeti ve güvenliği hakkının ihlal edildiğine karar vermiştir. Yüksek Mahkeme; somut olayda, başvurucunun terör örgütüne üye olma suçundan tutuklanmasını gerektirecek mahiyette yeterli delilin bulunmadığının Sulh Ceza Hakimliği kararında açıkça belirtildiğine ve adli kontrol tedbirinin devamına ilişkin Ağır Ceza Mahkemesi kararının herhangi bir gerekçe içermediğine dikkat çekmiştir. AYM’ ye göre, bireysel başvuru kapsamında yapılan incelemede, suç şüphesinin bulunmadığı yönündeki tespitin sorgulanması ve derece mahkemesinin yerine geçilerek tedbirin devamına ilişkin kararın gerekçelendirilmesi mümkün değildir (§ 34). AYM sonuç olarak, suç işlediğine dair kuvvetli belirtiler ortaya koyulmadan başvurucunun adli kontrol altına alınması nedeniyle Anayasa m.19/3’ün ihlal edildiğine karar vermiştir.NİHAİ OLARAK; bir şüpheli veya sanık hakkında tutuklama kararı verilebilmesi veya kişinin adli kontrol altına alınabilmesi için, kuvvetli suç şüphesini gösteren somut deliller ve en az bir tutuklama nedeni mutlaka bulunmalıdır. Bu tedbirlerin uygulanabilmesi için gerekli olan bir diğer koşul ölçülülüktür. Ölçülülük ilkesi göz ardı edilmemeli süresinde uzman bir avukat tarafından itiraz edilmelidir.\r\n\r\n \r\n\r\nDavalarınızda uzman ceza avukatından yardım almak hukuki açıdan sizi koruyacaktır. Detaylı bilgi için telefon numaramızdan (05061160225) bize ulaşabilirsiniz.",
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
                        Title = "Özel Okul Öğretmenlerinin Hakları",
                        Content = "Özel okullarda görev yapan öğretmenler 5580 Sayılı “Özel Öğretim Kurumları Kanununu” kapsamında İş Kanununa tabi olarak çalışmaktadır. 5580 Sayılı Kanun’un 9. Maddesinde özel eğitim kurumlarında çalışan öğretmenlerin iş sözleşmelerinin nasıl yapılacağı ve ekonomik, sosyal haklarına ilişkin düzenlemeler yer almaktadır. İlgili Maddenin 1. Fıkrasında “Kurumlarda çalışan yönetici, öğretmen, uzman öğretici ve usta öğreticiler ile kurucu veya kurucu temsilcisi arasında yapılacak iş sözleşmesi, en az bir takvim yılı süreli olmak üzere yönetmelikle belirtilen esaslara göre yazılı olarak yapılır.” denmektedir.\r\n\r\n \r\n\r\nBelirli süreli iş sözleşmelerinin tanımı 4857 sayılı İş Kanunu’nun 11/I hükmünde; “Belirli süreli işlerde veya belli bir işin tamamlanması veya belirli bir olgunun ortaya çıkması gibi objektif koşullara bağlı olarak işveren ile işçi arasında yazılı şekilde yapılan iş sözleşmesi” şeklinde yapılmıştır. İş Kanunu’nun 11.maddesinin “İş ilişkisinin bir süreye bağlı olarak yapılmadığı halde sözleşme belirsiz süreli sayılır.” ifadesi belirli süreli iş sözleşmelerinin istisnai niteliğini göstermektedir. Bir iş sözleşmesinin türü ile ilgili tereddüt hâsıl oldu ise sözleşmenin belirsiz süreli olduğunun kabul edilmesi gereklidir. Belirli süreli iş sözleşmesi, esaslı bir neden olmadıkça, birden fazla üst üste (zincirleme) yapılamaz. Aksi halde iş sözleşmesi başlangıçtan itibaren belirsiz süreli kabul edilir.",
                        ViewCount = 10,
                        CategoryId = 2,
                        ImageId = 1,
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false,
                        UserId = 1
                    },
                     new Blog
                     {
                         Id = 3,
                         Title = "Boşanmadan Sonra Aldatıldığını Öğrenen Birisi Tazminat İsteyebilir mi?",
                         Content = "Türk Medeni Kanunu‘nun 174. maddesi gereğince, boşanmadan önce eğer bir kişi evlilik birliği içinde sadakat yükümlülüğünü ihlal etmişse ve bu durum diğer eşte manevi zarara yol açmışsa, zarar gören eş tazminat talep edebilir. Peki bu yükümlülük ihlalinin boşanma sonrasında öğrenilmesi durumunda ne olur?\r\n\r\n \r\n\r\nAldatıldığını Boşanmadan Sonra Öğrenen Birisi Hangi Hükümlere Göre Tazminat İsteyebilir?\r\nAnlaşmalı boşanma durumunda tarafların birbirlerine karşı olan yükümlülüklerinden feragat ettikleri kabul edilir. Fakat boşanma sonrasında öğrenilen ihlal durumunda Aile Hukuku kapsamında bir manevi tazminat değil, Borçlar Hukukuna dayanan bir tazminat talep edilebilecektir. Davacı burada Türk Borçlar Kanunu madde 49 ve 58 uyarınca ve ilgili Yargıtay Kararları uyarınca haksız fiile dayanarak bir manevi tazminat davası açabilecektir.\r\n\r\n“MADDE 49– Kusurlu ve hukuka aykırı bir fiille başkasına zarar veren, bu zararı gidermekle yükümlüdür. Zarar verici fiili yasaklayan bir hukuk kuralı bulunmasa bile, ahlaka aykırı bir fiille başkasına kasten zarar veren de, bu zararı gidermekle yükümlüdür.”\r\n\r\n“MADDE 58– Kişilik hakkının zedelenmesinden zarar gören, uğradığı manevi zarara karşılık manevi tazminat adı altında bir miktar para ödenmesini isteyebilir.”",
                         ViewCount = 8,
                         CategoryId = 2,
                         ImageId = 1,
                         CreatedBy = "Songül Hilaloğlu",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false,
                         UserId = 1
                     },
                     new Blog
                     {
                         Id = 4,
                         Title = "İsim ve Soyisim Değiştirme *2024",
                         Content = "İsim, kişinin kimliğinin ayrılmaz bir parçasıdır ve özgürce seçilme hakkına sahiptir. Ancak isim değişikliği talepleri, toplumsal düzenin sağlanması ve güvenliğin korunması açısından titizlikle ele alınmalıdır. Bu nedenle, isim değişikliği davalarında ismin değişmezliği ilkesi benimsenmiştir. Ancak, haklı sebeplere dayanarak isim değişikliğine izin verilmektedir.\r\n\r\n \r\n\r\nMedeni Kanunun ilgili maddesi, ismin değiştirilmesinin haklı sebeplere dayanılarak bir hakimden istenebileceğini belirtmektedir. Ancak hangi durumların haklı sebep sayılacağı belirtilmemiştir, bu da hakimin takdirine bağlıdır. Hakim, bu kararı verirken hukuka ve hakkaniyete uygun olarak hareket etmelidir.\r\n\r\n \r\n\r\nHakim, isim değişikliği talebinde bulunan kişinin sosyal durumu, aile ilişkileri ve diğer özel koşulları göz önünde bulundurarak karar vermelidir. Bu süreçte, ismin gülünç, çirkin, iğrenç veya ahlaka aykırı anlamlar taşıması, uygun olmaması veya zor telaffuz edilmesi, karışıklığa neden olması gibi durumlar dikkate alınır. Ayrıca, din veya uyruk değişikliği, ticari faaliyetleri veya kişinin ilerlemesini engelleyen durumlar da göz önünde bulundurulur.",
                         ViewCount = 25,
                         CategoryId = 2,
                         ImageId = 1,
                         CreatedBy = "Songül Hilaloğlu",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false,
                         UserId = 1
                     },
                     new Blog
                     {
                         Id = 5,
                         Title = "Nüfus kaydının düzeltilmesi davası nedir ve hangi amaçla açılır?",
                         Content = "5490 sayılı Nüfus Hizmetleri Kanununun 36. maddesinde düzenlenen nüfus kaydının düzeltilmesi davası, hatalı veya yanlış nüfus kayıtlarının düzeltilmesi amacıyla açılan bir davadır. Bu dava genellikle nüfus müdürlüklerince yapılan maddi hataların düzeltilmesi, soybağı gibi hukuki ilişkilerin düzeltilmesi için açılır ve tarafların hukuki statülerini netleştirmeyi amaçlar.\r\n\r\nNüfus kaydının düzeltilmesi davası hangi durumlarda açılabilir?\r\nNüfus kaydının düzeltilmesi davası, kişisel bilgilerdeki yanlışlıkların (isim, soyisim, doğum tarihi, anne/baba adı gibi) düzeltilmesi için açılabilir. Bu dava, kayıtlı bilgilerin gerçeği yansıtmaması durumunda, kişinin hukuki durumunu ve kimlik bilgilerini doğru bir şekilde yansıtacak şekilde düzeltilmesini sağlamak için kullanılır.\r\n\r\nNüfus kaydındaki hangi hatalar düzeltilebilir?\r\nNüfus kaydındaki hatalar arasında isim, soyisim, doğum tarihi ve anne/baba adı gibi temel kişisel bilgilerin yanlış kaydedilmiş olması yer alır. Bu tür hatalar, ilgili kişinin hukuki statüsünü doğrudan etkileyebilecek önemli yanlışlıklardır ve düzeltilmesi için dava açılabilir.\r\n\r\n",
                         ViewCount = 12,
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
