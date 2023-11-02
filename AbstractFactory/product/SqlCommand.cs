using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class SqlCommand : ICommand {
        public void Interact(IAdapter adapter) {
            Console.WriteLine($"{GetType().Name} взаимодействоует с {adapter.GetType().Name}.");
        }
    }
}
