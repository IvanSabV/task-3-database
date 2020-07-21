using System;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            Console.WriteLine(userRepository.GetUserById());
            Console.WriteLine(userRepository.GetUserByName());
            Console.WriteLine(userRepository.SearchUserByName());
            Console.WriteLine(userRepository.AddUser());
            Console.WriteLine(userRepository.UpdateUser());
            Console.WriteLine(userRepository.UpdateUserState());


            MessageRepository messageRepository = new MessageRepository();

            Console.WriteLine(messageRepository.GetUserMessages());
            Console.WriteLine(messageRepository.SearchUserMessages());
            Console.WriteLine(messageRepository.AddMessage());


            ContactRepository contactRepository = new ContactRepository();

            Console.WriteLine(contactRepository.GetUserContact());
            Console.WriteLine(contactRepository.GetUserContacts());
            Console.WriteLine(contactRepository.SearchUserContacts());
            Console.WriteLine(contactRepository.AddContact());
            Console.WriteLine(contactRepository.UpdateContact());
            Console.WriteLine(contactRepository.DeleteContact());

        }
    }


}