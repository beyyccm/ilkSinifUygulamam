# Okul Yönetim Sistemi

Bu proje, basit bir **Okul Yönetim Sistemi** simülasyonudur. C# programlama dili ile yazılmıştır ve öğrenciler ile öğretmenlerin temel bilgilerini yönetmek için bir `Person` sınıfı kullanılmıştır.

## 🧩 Proje Amacı

Bu uygulama ile;

- `Person` adında bir temel sınıf (base class) tanımlanmıştır.
- Bu sınıf aracılığıyla öğrencilerin ve öğretmenlerin isim, soyisim ve doğum tarihi bilgileri tutulur.
- Oluşturulan nesneler bir listeye eklenerek konsola yazdırılır.

## 🔧 Kullanılan Teknolojiler

- Programlama Dili: **C#**
- Platform: **.NET Console Application**
- IDE: Visual Studio, Rider veya Visual Studio Code

## 🔍 Özellikler

- `Person` sınıfı `Ad`, `Soyad`, `DogumTarihi` özelliklerini içerir.
- Yapıcı metod (constructor) ile nesneler oluşturulur.
- `BilgileriYazdir()` metodu ile kişi bilgileri ekrana yazdırılır.
- Öğrenciler ve öğretmenler `Person` sınıfından türetilmeden doğrudan nesne olarak oluşturulmuştur.
- Listeleme işlemi `List<Person>` yapısı ile sağlanır.

## 🚀 Nasıl Çalıştırılır?

1. Bu projeyi bir C# konsol projesi olarak açın.
2. Aşağıdaki gibi bir dosya yapısı oluşturun:

