using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IStorage
    {
        int MaxCountCharacter { get;  } //максимальное количество символов на странице - зависит от формата листа

    }
}
