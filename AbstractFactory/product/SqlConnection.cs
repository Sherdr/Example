namespace AbstractFactory {
    class SqlConnection : IAdapter {
        public void Interact() {
            Console.WriteLine($"Соединение {GetType().Name} подключено.");
        }
    }
}
