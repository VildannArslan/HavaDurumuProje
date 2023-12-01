# WeatherApp

<p align="left">Öncelikle 3 ilin hava durumu bilgilerini alabileceğim URL'leri bir dictionary içerisine ekledim. <br><br>Elimizde 3 tane il olduğu için her bir il'in bilgileri alabilmek için bir for döngüsü oluşturdum.<br><br>HttpClient kütüphanesi ile sırası gelen ilin bağlantılı olduğu URL'ye istek gönderdim.<br><br>Başarılı bir istek dönmesi durumunda  NEWTONSOFT kütüphanesi aracılığıyla Deseriliaze işlemi yaptım ve JSON formatındaki verileri bir objeye dönüştürdüm.<br><br>Elimdeki objeden gelen bilgileri ise yine foreach döngüsü yardımıyla console'a yazdırdım.</p>

###

###
