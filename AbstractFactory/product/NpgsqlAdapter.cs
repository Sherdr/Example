namespace AbstractFactory {
    class NpgsqlAdapter : IAdapter {
        public void Interact() {
            Console.WriteLine($"Адаптер {GetType().Name} подключен.");
        }
    }
}
