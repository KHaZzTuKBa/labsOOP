using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("Корень", new List<Node>
            {
                new Node("Ребенок 1", new List<Node>
                {
                    new Node("Внук 11"),
                    new Node("Внук 12")
                }),
                new Node("Ребенок 2", new List<Node>
                {
                    new Node("Внук 21", new List<Node>
                    {
                        new Node("Правнук 211")
                    })
                }),
                new Node("Ребенок 3")
            });

            root.PrintAllValues();
        }
    }
}