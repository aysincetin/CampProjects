using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSystem
{
    //base sınıf: ebeveyn snıf
    // interface classında'n inherit olan sınıflar da interface classıyla aynı metodları içermek zorundadır.
    // bu örnek için IKrediManager 'den miras alan kredi çeşitleri de Hesapla() ve BiseyYap() metodlarını içermek zorunda
    interface ICreditManager   // interface 
    {
        void Calculate();
        void DoSomething();

    }
}
