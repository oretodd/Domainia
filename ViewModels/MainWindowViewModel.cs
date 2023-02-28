using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainia
{
  public class MainWindowViewModel
  {
    public static ObservableCollection<Domain> DesignDomains = new()
    {
      new Domain {Name="astrodisk.com" },
      new Domain {Name="kwerius.com" },
      new Domain {Name="robertson.systems" },
      new Domain {Name="toddrobertson.com" }
    };

    public ObservableCollection<Domain> Domains { get; set; } = new()
    {
      new Domain {Name="astrodisk.com" },
      new Domain {Name="kwerius.com" },
      new Domain {Name="robertson.systems" },
      new Domain {Name="toddrobertson.com" }
    };
  }
}
