using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class SqlFactory : IFactory {
        dynamic product;
        public dynamic Make(Product product) {
            try {
                var name = GetType().Namespace + ".Sql" + product.ToString();
                this.product = Activator.CreateInstance(Type.GetType(name));
            }catch(TypeLoadException e) {
                Console.WriteLine($"{e.GetType().Name}: Unable to load type.");
            }
            return this.product;
        }
    }
}
