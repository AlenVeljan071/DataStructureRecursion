using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureRecursion
{
    public class Program
    {
       static void Main(string[] args)
        {

            var listChar = new List<Child>();
            listChar.Add(new Child() { Id = 1, Name = 'A', ParentId = null });
            listChar.Add(new Child() { Id = 2, Name = 'B', ParentId = 1 });
            listChar.Add(new Child() { Id = 3, Name = 'C', ParentId = 1 });
            listChar.Add(new Child() { Id = 4, Name = 'D', ParentId = 2 });
            listChar.Add(new Child() { Id = 5, Name = 'E', ParentId = 3 });
            listChar.Add(new Child() { Id = 6, Name = 'F', ParentId = 3 });
            listChar.Add(new Child() { Id = 7, Name = 'G', ParentId = 2 });
            listChar.Add(new Child() { Id = 8, Name = 'I', ParentId = 4 });
            listChar.Add(new Child() { Id = 9, Name = 'J', ParentId = 8 });

            Task3 tree = new Task3();
            Node node = tree.createTree(listChar);
            tree.preorder(node);
        }

        class Task3
        {
            public Node root;
            List<Node> nodes = new List<Node>();
            public virtual void createNode(Node created)
            {
                nodes.Add(created);
              
                if (created.parent == null)
                {
                    root = created;
                    return;
                }

                if (created.parent != null)
                {
                    Node p = nodes.Where(x => x.key == created.parent).FirstOrDefault();
                   
                    if (p.left == null)
                    {
                        p.left = created;
                    }
                    else 
                    {
                        p.right = created;
                    }
                }
             
            }
            public virtual Node createTree( List<Child> lista)
            {
                foreach (var item in lista)
                {
                    var node = new Node(item.Id, item.Name, item.ParentId);
                    createNode(node);
                }
                return root;
            }
            public virtual void preorder(Node node)
            {
                if (node != null)
                {
                    Console.WriteLine(node.name + " ");
                    preorder(node.left);
                    preorder(node.right);
                }
            }
        }
        class Node
        {
            public char name;
            public int? parent;
            public int key;
            public Node left, right;

            public Node(int key, char name, int? parent)
            {
                this.name = name;
                this.key = key;
                left = right = null;
                this.parent = parent;
            }
        }
        class Child
        {
            public int Id { get; set; }
            public char Name { get; set; }
            public int? ParentId { get; set; }
        }
    }
}

