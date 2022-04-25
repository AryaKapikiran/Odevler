using LSP_Example.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir oyunumuz var bu oyunda ortacagdaki gibi bir feodal sistem var, kahramanlar hiyerarsiye göre yetki verme vs ozelliklere sahip olacaklar ve dolayısıyla her kahramanın classı olacak ayrıca bu kahramanların level altlayıp üst hiyerarsiye gecmek icin puanları da olacak bu puanlar yaptıkları gorevlerin simdilik 20 ile carpılmasıyla elde edilecek ve bu LSP kuralına göre 
            Kral kral = new Kral();
            kral.Name = "Napolyon";
            kral.PuanHesapla(45);
            
          
            
            Soylu soylu = new Soylu();
            soylu.Name = "Louis";
            soylu.PuanHesapla(30);
            soylu.AssignHero(kral);

            Şövalye şövalye = new Şövalye();
            şövalye.Name = "Larry";
            şövalye.PuanHesapla(10);
            şövalye.AssignProtectedHero(soylu);


            Serf serf = new Serf();
            serf.Name = "Gary";
            serf.PuanHesapla(3);
            serf.AssignHero(şövalye);
        }
    }
}
