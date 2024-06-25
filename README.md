Merhaba,

Bu proje avukatlık hizmeti sunan bir kurum için hazırlanmıştır.

Proje beş farklı katmandan oluşmaktadır. Core, Data, Entity, Service, WEB katmanları.
Core katmanında bütün entityler için kalıtım sağlanabilecek base class ve içerisine standart propertyler eklenmiştir.
Data katmanında database işlemleri için context sınıfı, database bağlantısı için extensions, data seeding için mapping, 
migrationlar için migratios, veritabanı ekleme silme, veri getirme, kaydetme vb işlemler için repository ve unitofwork tasarım deseni kullanılmıştır.
Entity katmanında entityler, dtolar ve enumlar oluşturulmuştur.
Servis katmanında automapper klasörü altında gerekli tüm entity dto eşleştirme işlemleri için classlar oluşturulmuştur.
Kullanıcı işlemleri için Identity kütüphanesi kullanılmıştır, describers klasörü altında ıdentity mesajlarını türkçeye çeviren hazır kodlar kullanılmıştır.
Extensions klasörü altında oturumu açık olan kullanıcıyı yakalayabilmel için sınıf oluşturulmuştur. 
Bağımlılıklar ve konfigürasyonlar için ayrı extension oluşturulmuştur.
Validasyonlar için fluent validation kullanılmıştır.
Resim yükleme ve silme işlemi için helpers klasörü oluşturulmuştur.
Her entity özelinde servisler oluşturulmuştur.
WEB katmanında admin area eklenmiştir, admin için plusadmin isimli template kullanılmıştır. Web sitesi için star-master-law isimli template kullanılmıştır.
Admin panelinde kullanıcıya işlemle ilgili bildirimleri göstermek için Install-Package NToastNotify kullanılmıştır.
Blog eklerken textarea alanı için CK Editör kullanılmıştır.

Bu projede geliştirmesi gereken en önemli alan blog resim ekleme ve güncelleme alanıdır. One-to-One, One-to-Many, Many-to-Many Relationships kullanılmıştır, database diagramı görsel olarak eklenmiştir.

Admin Panel Kullanıcı Bilgileri:
Kullanıcı: superadmin@hotmail.com 
Şifre: 123456
Rolü: Superadmin

![web](https://github.com/songulhilaloglu/Blog/assets/103853967/22b334df-d617-4b10-80bd-f9fd18ff49e8)

![admin](https://github.com/songulhilaloglu/Blog/assets/103853967/648144f5-0b9e-4582-b775-0f2541ad590e)

![diagram](https://github.com/songulhilaloglu/Blog/assets/103853967/9d792496-2388-4b27-8980-d785eeae72d5)



