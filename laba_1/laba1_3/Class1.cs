namespace laba1_3 
{ 
    class Node
    {
        // Свойство для хранения значения узла
        public string Value { get; set; }

        // Список дочерних узлов
        public List<Node> Children { get; set; }

        // Конструктор для узла без потомков
        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
        }

        // Конструктор для узла с потомками
        public Node(string value, List<Node> children)
        {
            Value = value;
            Children = children;
        }

        // Метод для печати всех значений узла и его потомков
        public void PrintAllValues()
        {
            Console.WriteLine(Value);

            foreach (var child in Children)
            {
                child.PrintAllValues();
            }
        }
    }
}
