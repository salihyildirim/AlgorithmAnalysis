using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortized_Cost
{
    public class dinamik_dizi
    {
        public int elemansayisi = 0;
            
        public void diziye_ekle(ArrayList d,int eklenen)
        {
            if (d.Capacity == elemansayisi)
            {
                resize(d); /* resize olmuş array'in kapasitesi 2 katına çıkarken,
                            mevcut elemanlar da resize olmuş array'e kopyalanıyor.
                            * yani 2n eleman eklenmesi için 2n işlem + n adet kopyalama = 3n işlem var.
                            * bundan dolayı karmaşıklık O(3N/2N)= O(1) olur.
                            */
                Console.WriteLine("Amortized Cost\n");
            }
            elemansayisi += 1;             
            d.Add(eklenen);
                                             
        }

        public void sil(ArrayList d)
        {
            
            d.RemoveAt(elemansayisi-1);
            elemansayisi -= 1;
        }
        public ArrayList resize(ArrayList a)
        {
            a.Capacity *= 2;
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dinamik_dizi dy = new dinamik_dizi();
            
            ArrayList dizi=new ArrayList(1);       

            dizi.Capacity=1;
            Console.WriteLine("Kapasite = {0} ", dizi.Capacity);
            Console.WriteLine("Eleman Sayisi= {0} \n", dy.elemansayisi);

            dy.diziye_ekle(dizi, 5);
            dy.diziye_ekle(dizi, 6);
            dy.diziye_ekle(dizi, 7);
            dy.diziye_ekle(dizi, 8);
            dy.diziye_ekle(dizi, 9);
            
            foreach (int x in dizi)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Kapasite = {0} ", dizi.Capacity);
            Console.WriteLine("Eleman Sayisi= {0} \n", dy.elemansayisi);
            Console.WriteLine("\n---------------------- \n");
            
            dy.sil(dizi);
            
            dy.sil(dizi);
            
            dy.sil(dizi);
            
            dy.sil(dizi);
            
            dy.sil(dizi);
                   

            foreach (int x in dizi)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Kapasite = {0} ",dizi.Capacity);
            Console.WriteLine("Eleman Sayisi= {0} ",dy.elemansayisi);
            Console.ReadKey();
        }
    }
}
