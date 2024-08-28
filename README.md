BlogProject

LC Waikiki'de DevOps stajım sırasında ASP.NET Core MVC kullanarak bir blog platformu oluşturmak amacıyla geliştirildi. Docker ile konteynerleştirilerek, uygulama her ortamda tutarlı bir şekilde çalışabilir hale getirildi. Ayrıca, Azure DevOps üzerinde deployment-test.yaml dosyası oluşturarak CI/CD süreçlerini otomatikleştirdim. Pipeline üzerinden gerçekleştirilen build işlemleri sorunsuz bir şekilde tamamlandı ve projenin her yeni versiyonu başarıyla deploy edildi.  

Özellikler
Blog gönderisi oluşturma
Blog gönderisi düzenleme
Blog gönderisi silme
Blog gönderisi görüntüleme
Kategori yönetimi
Yorum yapabilme


Gereksinimler
.NET 6 SDK
Docker (opsiyonel)
Git


Kurulum
Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları takip edin:

Depoyu klonlayın:
git clone https://github.com/alperckrva/BlogProject.git
cd BlogProject

Bağımlılıkları yükleyin:
.NET SDK'yı kullanarak bağımlılıkları yüklemek için:
dotnet restore

Projeyi çalıştırın:
dotnet run

Docker ile Çalıştırma
Projeyi Docker ile çalıştırmak için aşağıdaki adımları izleyin:

Docker imajını oluşturun:
docker build -t blogproject .

Docker konteynerini çalıştırın:
docker run -d -p 8080:80 blogproject
Tarayıcınızı açın ve http://localhost:8080 adresine gidin.

Katkıda Bulunma
Katkılarınızı memnuniyetle karşılıyoruz! Lütfen katkıda bulunmak için bir Pull Request gönderin.

Depoyu forklayın.
Yeni bir özellik üzerinde çalışın (git checkout -b feature/yeniozellik).
Değişikliklerinizi commit edin (git commit -m 'Yeni özellik ekle').
Dalı gönderin (git push origin feature/yeniozellik).
Bir Pull Request açın.

İletişim
Herhangi bir sorunuz veya öneriniz varsa lütfen alpcukurova@gmail.com adresine e-posta gönderin.
