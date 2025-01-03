# BasicCommerce  
Bu proje, **N-Tier mimarisi** ve **Entity Framework Code First** yaklaşımı kullanılarak geliştirilmiş temel bir e-ticaret uygulamasıdır. Proje, çok katmanlı mimari prensiplerini takip eder ve geliştiricilere e-ticaret uygulamalarının temel yapı taşlarını öğretmeyi amaçlar.

## 📂 Proje Yapısı
Proje, N-Tier mimarisine uygun olarak aşağıdaki katmanlardan oluşur:
1. **Entities Layer**:  
   - Veri modellemeleri (Entity sınıfları) bu katmanda tanımlanmıştır.  
   - Örnek sınıflar: `Category`, `Product`, `AppUser`, `AppUserProfile`, `Order`, `OrderDetail`.
     
2. **Configuration Layer (CONF)**:  
   - Entitylerimizin yapılandırma ayarlarının yapıldığı katmandır.
     
3. **Data Access Layer (DAL)**:  
   - Veritabanı işlemleri ve Entity Framework Code First ile ilişkisel veri modelleme işlemleri burada gerçekleştirilir.  

4. **Business Logic Layer (BLL)**:  
   - İş kuralları ve veri yönetim mantığı bu katmanda yer alır.  

5. **UI/Presentation Layer (UI/PL)**:  
   - Kullanıcı arayüzü ve uygulama ekranları bu katmanda geliştirilmiştir (ör. Windows Forms veya ASP.NET MVC).  

---

## 🚀 Teknolojiler ve Araçlar
Projede kullanılan başlıca teknolojiler ve araçlar:  
- **.NET Framework / .NET Core**  
- **Entity Framework (Code First)**  
- **N-Tier Architecture**
- **Singleton Design Pattern**
- **Generic Repository Design Pattern**
- **Visual Studio**  
- **MS SQL Server**  

---

## 🛠️ Kullanılan Entity'ler
Projede kullanılan temel Entity sınıfları şunlardır:  
1. **Category**: Ürün kategorilerini temsil eder.  
2. **Product**: Kategorilere bağlı olarak tanımlanan ürünleri temsil eder.  
3. **AppUser**: Uygulama kullanıcılarını temsil eder (müşteri ya da yönetici).  
4. **AppUserProfile**: Kullanıcıların detaylı profil bilgilerini içerir.  
5. **Order**: Sipariş bilgilerini temsil eder.  
6. **OrderDetail**: Siparişe ait detaylı bilgileri içerir (ürün, miktar, fiyat, vb.).

---

## 📑 Özellikler
- **Kategorilere bağlı ürün yönetimi.**  
- **Kullanıcı ve profil bilgileri yönetimi.**  
- **Sipariş ve sipariş detayları yönetimi.**  
- **Entity Framework Code First ile veritabanı modellemesi ve oluşturulması.**  
- **N-Tier mimari ile temiz kod ve katmanlı yapı.**  

---

## 🔧 Kurulum Adımları  
Projeyi çalıştırmak için aşağıdaki adımları takip edin:  

1. **Visual Studio'da projeyi açın.**  
2. **`Project.WinFormUI projesinde App.config`** dosyasını açarak veritabanı bağlantı stringini düzenleyin.
3. Solution'ı **'Built'** edin.
4. Veritabanını oluşturmak için **Entity Framework Code First Migrations** komutlarını çalıştırın:  
   enable-migrations -enableautomaticmigrations
   update-database


## 📚 Öğrenim Hedefleri  
Bu proje, aşağıdaki kavramların öğrenilmesini ve uygulanmasını hedefler:  

- **N-Tier mimarinin temel prensipleri.**  
- **Entity Framework Code First** yaklaşımıyla veritabanı tasarımı.  
- **İş kuralları ve veri erişim katmanlarının ayrıştırılması.**  
- **Temiz kod yazımı ve katmanlı mimarinin avantajları.**  

## 📬 İletişim  
Eğer bu proje hakkında herhangi bir sorunuz varsa, [Hakan Akınsu](https://github.com/hakanakinsu0) ile iletişime geçebilirsiniz.  


