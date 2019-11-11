using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //MM
        public Node root;

        //CTOR
        public BinarySearchTree()
        {
            root = null;
        }

        //MM
        
        public void AddNode(int data)
        {
            //see if there is a root node
            //if no root node, set new node as root node
            Node newNode = new Node(data);
            newNode.data = data;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                //create parent???
                Node parentNode;
                while (true)
                {
                    parentNode = currentNode;
                    //determine if > root node or < root node
                    //if > root node create leftChild
                    if (data < currentNode.data)
                    {
                        currentNode = currentNode.leftChild;
                        if(currentNode == null)
                        {
                            parentNode.leftChild = newNode;
                            //break out of fn
                            break;
                        }
                    }
                    //if < root node create rightChild
                    else
                    {
                        currentNode = currentNode.rightChild;
                        //create parent???
                        if (currentNode == null)
                        {
                            parentNode.rightChild = newNode;
                            break;
                        }
                    }
                }
            }
        }

        //public void RemoveNode()
        //{
        //    //logic
        //}

        public bool Search(int num)
        {
            Node current = root;
            while(true)
            {
                if (num == current.data)
                {
                    return true;
                }
                else if (num < current.data && current.leftChild != null)
                {
                    current = current.leftChild;
                }
                else if (current.rightChild != null)
                {
                    current = current.rightChild;
                }

                else
                {
                    return false;
                }
        }

        public void Menu()
        {
            //be able to choose to AddNode or Search
        }
    }
}
