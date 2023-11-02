namespace AbstractFactory {
    public class Client {
        dynamic factory;
        dynamic connection;
        dynamic adapter;
        dynamic command;
        public Client(Factory factory) {
            try {
                var name = GetType().Namespace + "." + factory.ToString();
                this.factory = Activator.CreateInstance(Type.GetType(name));
                connection = this.factory.Make(Product.Connection);
                adapter = this.factory.Make(Product.Adapter);
                command = this.factory.Make(Product.Command);
            }
            catch(TypeLoadException e) {
                Console.WriteLine($"{e.GetType().Name}: Unable to load type.");
            }
        }
        public void Run() {
            connection.Interact();
            adapter.Interact();
            command.Interact(adapter);
        }

    }
}
