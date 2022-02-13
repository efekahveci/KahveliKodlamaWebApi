using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Domain.Enum
{
    
    
    public enum ResponseCode
    {
        #region 100 ile başlayan Bilgi Mesajları
        Continue = 100, //Devam -> İstek Başarılı 
        Switching_Protocols = 101, //Anahtarlama Protokolü -> Sunucu, istemciden aldığı protokol değiştirme isteğine uyacağını belirtmektedir 
        Processing = 102, //İşlem 
        #endregion
        #region 200 ile başlayan Başarı Mesajları
        OK = 200, //Tamam -> İstek Başarılı ve cevap başarılı
        Created = 201, //Oluşturuldu -> İstek başarılı ve sunucuda yeni kaynak oluşturuldu.
        Accepted = 202, //Onaylandı -> Sunucu isteği kabul etti ama henüz işlemedi. 
        Non_Authoritative_Information = 203, //Yetersiz bilgi -> Sunucu isteği başarılı işledi, ancak başka kaynakta olabilecek bilgi döndürmektedir. 
        No_Content = 204, //İçerik yok -> İstek başarılı alınmış ancak geri içerik döndürülmemektedir
        Reset_Content = 205, //İçeriği Baştan al -> İstek başarılı alınmış ancak geri içerik döndürülmemektedir. Ancak içerik temizlenecektir 
        Partial_Content = 206, //Kısmi İçerik -> GET için kısmi içerik (içeriğin bir belirli bir parçası) başarılıyla döndürülmüştür.
        Multi_Status = 207, //Çok-Statü
        Content_Different = 210, //Farklı İçerik 
        #endregion
        #region 300 ile başlayan Yönlendirme Mesajları
        Multiple_Choices = 300,//Çok Seçenek -> Sunucuda isteğe göre birden fazla seçenek olduğunu bildirir. Sunucu seçeneği kendisi seçebilir veya seçenek listesini görüntüleyebilir.
        Moved_Permanently = 301, //Kalıcı Taşındı -> Bir kaynağın (veya sayfanın) kalıcı olarak başka bir yere taşındığını bildirir ve o yere yönlendirme sağlar.
        Moved_Temporarily = 302, //Geçici Taşındı -> Bir kaynağın (veya sayfanın) kalıcı değil geçici olarak başka bir kaynağa yönlendirir. Kaynağın ana adresi değişmemiştir.
        See_Other = 303, //Diğerlerine Bak -> Farklı bir kayanağa GET yapılması gerektiğini belirtir. 
        Not_Modified = 304, //Güncellenmedi-> İstenilen kaynakta daha önce yapılan istekten beri herhangi bir değişikliğin olmadı belirtilir ve içerik gönderilmez.
        Use_Proxy = 305, //Proxy Kullan-> Sunucu tarafından döndürülen proxy'in kullanılması gerektiği belirtilir.
        Temporary_Redirect = 307, //Geçici olarak yeniden gönder->Bir kaynağın (veya sayfanın) kalıcı değil geçici olarak başka bir kaynağa yönlendirir.
        #endregion
        #region 400 ile başlayan İstemci hatası Mesajları
        Bad_Request = 400,//Kötü İstek -> İstek hatalı (isteğin yapısı hatalı) olduğu belirtilir.
        Unauthorized = 401, //Yetkisiz -> İstek için kimlik doğrulaması gerekiyor.
        Payment_Required = 402, //Ödeme Gerekli-> Ödeme gerekiyor.
        Forbidden = 403, //Yasaklandı -> Kaynağın yasaklandığını belirtir. 
        Not_Found = 404, //Sayfa Bulunamadı-> İstek yapılan kaynağın (veya sayfanın) bulunamadığını belirtir.
        Method_Not_Allowed = 405, //İzin verilmeyen Metod-> Sunucu , HTTP Method'u kabul etmiyor..
        Not_Acceptable = 406, //Kabul Edilemez -> İstemcinin Accept header'ında verilen özellik karşılanamıyor.
        TimeOut = 408, //İstek zaman aşamına uğradı -> İstek zaman aşımına uğradı (belirli bir sürede istek tamamlanamadı.
        #endregion
        #region 500 ile başlayan Sunucu hatası Mesajları
        Internal_Server_Error = 500,// -> Sunucuda bir hata oluştu ve istek karşılanamadı..
        No_Service = 503, //-> Sunucu şu anda hizmet vermiyor (kapalı veya erişilemiyor).
        Gateway_Timeout = 504, // -> Gateway veya Proxy sunucusu, kaynağın bulunduğu sunucudan (upstream sunucusu) belirli bir zaman içinde cevap alamadı.
        HTTP_Version_not_supported = 505, // -> HTTP Protokol versiyonu desteklenmiyor. 
        #endregion
    }

}
