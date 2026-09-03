API Geliştirme ve Kullanımı – Udemy Kurs Projeleri

Bu repo, Udemy'de aldığım "API Geliştirme ve Kullanımı" kursu kapsamında C# / .NET ile geliştirdiğim 6 projeyi içermektedir. Her proje, farklı bir API konseptini uygulamalı olarak öğrenmek amacıyla hazırlanmıştır.

📁 Proje Listesi
1️⃣ API Uygulama ve Kullanımı

Sıfırdan bir Web API projesi oluşturma, endpoint tasarımı, HTTP metodları (GET, POST, PUT, DELETE) ve temel API mimarisi üzerine çalışılmıştır.

2️⃣ API Uygulamasını Consume Etme

Geliştirilen API'nin bir istemci (client) uygulama tarafından nasıl tüketileceği (consume edileceği) üzerine odaklanan proje. HttpClient kullanımı ve API'den veri çekme/gönderme işlemleri içerir.

3️⃣ Dışarıdan Harici API'ler ile Çalışmak (RapidAPI)

RapidAPI üzerinden üçüncü parti bir API'ye entegrasyon örneği. Dış kaynaklı API'lere istek atma, API anahtarı (API key) yönetimi ve gelen verileri işleme konularını kapsar.

4️⃣ OpenAI Chat Uygulaması

OpenAI API'si kullanılarak geliştirilen basit bir sohbet (chat) uygulaması. Kullanıcı girdisini OpenAI API'sine göndererek yapay zekâ destekli yanıtlar alma üzerine kuruludur.

5️⃣ Speech to Text

Ses verisini metne dönüştüren bir API entegrasyonu. Konuşma tanıma (speech recognition) servisleri ile çalışma pratiği içerir.

6️⃣ DALL·E ile Görsel Oluşturma

Kullanıcıdan alınan prompt (metin girdisi) ile DALL·E API'si üzerinden yapay zekâ destekli görsel üretimi yapan proje.

🛠️ Kullanılan Teknolojiler
C#
.NET (ASP.NET Core)
RESTful API prensipleri
HttpClient
RapidAPI
OpenAI API (Chat, Speech-to-Text, DALL·E)
📂 Proje Yapısı
├── 01-ApiGelistirme/
├── 02-ApiConsumeEtme/
├── 03-RapidApiEntegrasyonu/
├── 04-OpenAiChatUygulamasi/
├── 05-SpeechToText/
├── 06-DallEImageGeneration/
└── README.md

Her klasör kendi içinde bağımsız bir .NET projesi olup, ilgili konunun uygulamasını içerir.

🚀 Nasıl Çalıştırılır
Repoyu klonlayın:
bash
   git clone <repo-linki>
İlgili proje klasörüne gidin:
bash
   cd 04-OpenAiChatUygulamasi
Projeyi çalıştırın:
bash
   dotnet run
OpenAI / RapidAPI gerektiren projeler için kendi API anahtarınızı appsettings.json veya .env dosyasına eklemeniz gerekmektedir.

⚠️ API anahtarları güvenlik nedeniyle repoya dahil edilmemiştir. Kendi anahtarlarınızı kullanmanız gerekir.

📝 Not

Bu projeler eğitim amaçlı geliştirilmiş olup, API kullanımı, entegrasyonu ve tüketimi konularında pratik kazanmak için hazırlanmıştır.
