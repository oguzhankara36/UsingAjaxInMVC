using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //ajax ile sayfalar yenilenmeden komple sunucuya gidip sayfayı yenilemeden sadece istenilen kısmın gönderilip istenilen miktarda datanın alındığı yapıları sağlamış oluyoruz.
        //Neden ihtiyaç duyarız
        //daha az veri gidip geliyor
        //performansı arttırdığı için kod dostudur.
        //sayfa yenilenmediği için sadece ilgili sayfanın parçası yenilendiği için kullanıcı sanki masaüstünde kolaylıkla pencere uygulaması mantığıyla işlemlerini yapar.
        //MVC ile ajax helper'daiki tane metot vardır. bu metotlar bizee javascript kodu yazmadan işlemleri yapmamızı sağlar.
        //ajax.BeginForm() ----> verileri sunucuya gönderme
        //ajax.actionlink()----> bir link yada buton koyup tıklanınca ajax ile verileri çekebiliriz 
        //ajax jquery olmadan çalışmaz..
        //ajax asenkron javascript and xml
        public ActionResult Index()
        {
            return View();
        }
        private List<string> datas = new List<string>() { "oğuzhan", "tayip", "muhammed" };
        public PartialViewResult GetData()
        {
            System.Threading.Thread.Sleep(3000);
            return PartialView("_DataItemParticialView", datas);
        }
    }
}