using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class NpgsqlFactory : IFactory {
        dynamic product;
        public dynamic Make(Product product) {
            try {
                var name = GetType().Namespace + ".Npgsql" + product.ToString();
                this.product = Activator.CreateInstance(Type.GetType(name));
            }
            catch (TypeLoadException e) {
                Console.WriteLine($"{e.GetType().Name}: Unable to load type.");
            }
            return this.product;
        }
    }
}
