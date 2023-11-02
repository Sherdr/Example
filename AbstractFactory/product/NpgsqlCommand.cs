using System;
namespace AbstractFactory {
    class NpgsqlCommand : ICommand {
        public void Interact(IAdapter adapter) {
            Console.WriteLine($"{GetType().Name} взаимодействоует с {adapter.GetType().Name}.");
        }
    }
}
