Cafe Menu App

Proje Asp.NET MVC Core üzerinden hazırlanmıştır.
Repository Design Pattern kullanılmıştır. (n tier architecture)
4 katmandan oluşmaktadır. (Web UI Layer,Entity Layer,Data Access Layer,Business Layer)
MSSQL veritabanı kullanılmıştır.
Entity Framework kullanılarak hazırlanmıştır.

Projenin çalışması için gerekli olan database kısmında tabloların oluşturulması için 
Package Manager Console'u üzerinden Default project kısmında "TaskManager.DataAccess" i seçip Console 'a "Update-Database"
 yazıp aktif ettikten sonra uygulamayı çalıştırıp kullanabilirsiniz.

Olmaz ise migration kısımlarının silinip "add-migration init" ardından "update-database" komutu kullanılabilir.

ImageMainPath'e image adı verilirse resim gelecektir. 4 adet resim eklendi: 1.jpeg, 2.jpeg, 3.jpeg, 4.jpeg

/Home -> Kullanıcıların Gördüğü ürün listesi
/Admin -> Admin işlemleri

!NOT:"http://www.tcmb.gov.tr/kurlar/" sayfası çalışmadığı için kur bilgisi çekilip ona göre gösterilemedi.

