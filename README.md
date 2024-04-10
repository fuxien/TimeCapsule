Temelde 2 Tane Windows Formdan oluşan Uygulamazın amacı Geleceğe not bırakmaktır.<br>
Notlar <b>ADD</b> sekmesinden eklenmektedir.<br>
Geleceğe bırakılmış olan notlardan okuma zamanı gelmiş olanlar ana pencerede <b>NOW</b> sekmesinde okuma zamanı geçmiş olanlar <b>PAST</b> sekmesinde ve okuma zamanı gelmemiş olanlar <b>FUTURE</b> sekmesinde datagridview içersinde görüntülenmektedir.<br>
TimeCapsule isimli uygulamanın veri tabanı ismi de aynıdır.<br>
Veri Tabanında tek tablo vardır. Tablonun adı note isimindedir.<br>
Note tablosunda id, note, display_date ve created_at ve unread alanları vardır.<br>
Veriler günümüz tarihine göre geçenler,zamanı gelenler ve gelecektekiler olarak yarı ayrı çekilip datagridview içerinde gösterilmektedir.<br>
Zamanı gelen ve geçen notlar açılıp okunabilmektedir. Listelerde sadece okunmamış olanlar görüntülenebilmektedir. Bir not zamanı gelmiş ve açılmışsa bir daha uygulama içerisinde görünmeyecektir.<br>
Bu işlem için veritabanı tablomuzda unread alanı oluşturulmuş bu alandaki veri 1 ise okunmamış 0 ise okunmuş demektir.<br>
2. Formumuz ise zamanı gelmiş veya geçmiş notları okuduğumuz bir formdur. Bu form kapatıldığında bir uyarı ile bu notun bir daha okunamayacağı uyarı şeklinde verilemktedir.<br>
Uygulamanın veri tabanı ayarları App.config isimli dosyada bulunan connectionStrings alanındaki MyConnectionString isimli bölümden değiştirilebilir.<br>
