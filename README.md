# Hava Durumu Uygulaması

Bu konsol uygulaması, [GoWeather API](https://goweather.herokuapp.com/) üzerinden üç şehir (İstanbul, İzmir ve Ankara) için hava durumu verilerini çeker ve her bir şehir için mevcut hava durumu ile 3 günlük tahminleri görüntüler.

## Nasıl Kullanılır

1. Depoyu yerel makinenize klonlayın:

    ```bash
    git clone https://github.com/kullanici-adiniz/HavaDurumuUygulamasi.git
    ```

2. Çözümü tercih ettiğiniz C# IDE'nizde açın (örneğin, Visual Studio).

3. Uygulamayı çalıştırın.

4. Konsolda İstanbul, İzmir ve Ankara için hava durumu bilgilerini görüntüleyin.

## Bağımlılıklar

- [Newtonsoft.Json](https://www.newtonsoft.com/json): JSON nesnelerini çözmek için kullanılır.

## Kod Yapısı

- **Program.cs**: Ana uygulama mantığını içerir, `Main` metodunu ve hava durumu bilgilerini alıp görüntülemek için kullanılan asenkron metodları içerir.

- **WeatherData.cs**: API'den alınan JSON verisinin yapısını temsil eden sınıfları tanımlar (WeatherData ve ForecastData).

## İstisna İşleme

Uygulama, şehir bulunamadığı veya veri alımı sırasında genel hatalar gibi sorunlarda uygun hata mesajlarını görüntüler.

## Notlar

- Hava durumu verilerini GoWeather API'den alabilmek için aktif bir internet bağlantınızın olması gerekmektedir.

- Bir şehir bulunamazsa, "Şehir bulunamadı" hatası mesajı görüntülenir.

- Kodu istediğiniz gibi keşfetmekte ve değiştirmekte özgürsünüz.

## Lisans

Bu proje, ayrıntılar için [LICENSE](LICENSE) dosyasına bakınız, MIT Lisansı altında lisanslanmıştır.

---

Katkıda bulunmaktan, sorun bildirmekten veya geliştirmeler önermekten çekinmeyin. İyi kodlamalar!
