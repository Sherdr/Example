namespace AbstractFactory {
    class NpgsqlConnection : IConnection {
        public void Interact() {
            Console.WriteLine($"Соединение {GetType().Name} подключено.");
        }
    }
}
