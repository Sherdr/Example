using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class SqlAdapter : IAdapter {
        public void Interact() {
            Console.WriteLine($"Адаптер {GetType().Name} подключен.");
        }
    }
}
