//This is a program that guess a animal by using recursive method.
//Jesus Sunuc
//11/11/2022

using System;
using System.Security.Cryptography.X509Certificates;
namespace LearningTree
{
    class Program
    {
        
        static void Main(string[] args) //This method is the driver that allows the user interacts with the game. 
        {
            Console.WriteLine("Welcome to the animal game. Think of an animal and I will try to guess it. Press yes to conitinute or no to quit.");
            Console.WriteLine(" ");
            BinaryTree<string> tree = new BinaryTree<string>("Your animal has legs?"); //Create a new tree passing your animial has a leg has a root. 
            tree.attachLeft("Cat"); //Attach a left node to the root.
            tree.attachRight("Snake"); //Attach a right node to the root.

            string input = "yes";//check if the user wwants to continued.
            while (input == "yes") 
            {
                Console.WriteLine(" ");
                Console.WriteLine("You wanna to continued? "); //Ask the user if they want to continued.
                Console.WriteLine(" ");
                input = Console.ReadLine();
                if (input == "yes" || input == "Yes")
                {
                    Learn(tree); // Called for the recursive method and passed the value of the tree
                }
                else
                {
                    input = "false";
                }
            }
        }
        
        public static void Learn(BinaryTree<string> tree) //This is a recursive method that takes the base case and check if is a leaf or not.
        {
            BinaryTree<string> sub = tree.detachLeftSubtree(); //Creates a temporary variable to store the value of detached value from the left
            if (sub.isEmpty())
            {
                Console.Write($"Is it a {tree.getRootItem()}? "); //If the tree is empty then it will print the root item.
                string input = Console.ReadLine(); //Ask the user if the guess is correct.
                if (input == "yes")
                {
                    Console.WriteLine("+------------------------------------+");
                    Console.WriteLine("I win. Tha's great! "); //If the user input is yes then the program will print this message.
                    Console.WriteLine("+------------------------------------+");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("I give up. What is it? "); //If the user input is no then the program will print this message.
                    Console.WriteLine(" ");
                    string newItem = Console.ReadLine(); //This will store the new item that the user input.
                    Console.WriteLine(" ");
                    Console.WriteLine($"please type a question whose answer is yes for a {newItem} and no for a {tree.getRootItem()}");
                    Console.WriteLine(" ");
                    string question = Console.ReadLine(); //Ask the user to type a question.
                    tree.attachLeft(newItem); //Attach the new item to the left.
                    tree.attachRight(tree.getRootItem()); //Attach the root item to the right.
                    tree.setRootItem(question); //Set the question as the root item.
                }
            }
            else
            {
                tree.attachLeftSubtree(sub); //If the tree is not empty then it will attach the left subtree to the tree.
                Console.Write(tree.getRootItem()); //Print the root item.
                string response = Console.ReadLine(); //Ask the user if the question is yes or no.
                if (response == "yes" || response == "Yes") 
                {
                    sub = tree.detachLeftSubtree(); //If the user input is yes then it will detach the left subtree.
                    Learn(sub); //Call the recursive method and pass the value of the subtree.
                    tree.attachLeftSubtree(sub); //Attach the left subtree to the tree.
                }
                else
                {
                    sub = tree.detachRightSubtree(); //If the user input is no then it will detach the right subtree.
                    Learn(sub); //Call the recursive method and pass the value of the subtree.
                    tree.attachRightSubtree(sub); //Attach the right subtree to the tree.
                }
            }
        }
    }
}