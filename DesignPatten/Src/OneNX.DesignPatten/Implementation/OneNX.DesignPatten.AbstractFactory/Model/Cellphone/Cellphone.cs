using OneNX.DesignPatten.AbstractFactory.Enum;
using OneNX.DesignPatten.AbstractFactory.Model.OIUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.Cellphone
{
    public abstract class Cellphone
    {
      public virtual CellphoneBrandEnum Brand { get; set; }

      public virtual void Boot()
      {
         Console.WriteLine($"Cellphone booting...");
      }

      public virtual void WrapUI(UI ui)
      {
         Console.WriteLine($"Wrap {Brand} with {ui.Name} - Version: {ui.Version}, Score: {ui.Score}");
      }
    }
}
