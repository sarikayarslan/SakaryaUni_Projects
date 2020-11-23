<?php

$ad= $_POST['ad'];
$soyad=$_POST['soyad'];
$cinsiyet=$_POST['cinsiyet'];
$yas=$_POST['yas'];
$email=$_POST['mail'];
$ovgu=$_POST['ovgu'];
$mesaj=$_POST['mesaj'];
if( $ad!="" &&$soyad!="" &&$cinsiyet!=null &&$yas!="" &&$email!="" &&$ovgu!="" &&$mesaj!=""){
echo"Adı: $_POST[ad] <br>";
echo"Soyadı: $_POST[soyad] <br>";
echo"Cinsiyet: $_POST[cinsiyet] <br>";
echo"Yaşı: $_POST[yas] <br>";
echo"E-Mail Adresi: $_POST[mail] <br>";
echo"Hakkındaki Görüşü: $_POST[ovgu] <br>";
echo"Yorumu: $_POST[mesaj] <br>";
}
else{
    echo "Eksik veya Hatalı Tuşlama Yaptınız.. <br> İletişim Sayfasına Yönlendiriliyorsunuz";
    header("Refresh:2; url=iletisim.html");
}
?>