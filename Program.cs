namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the library management system");
            Library library = new Library();

            while (true) // Main Menu loop
            {
                Console.WriteLine("if you a regular user enter (R) , if you are librarian enter (L), to exit (E)");
                char userType = Console.ReadLine().ToUpper()[0];

                if (userType == 'L')
                {
                    Console.Write(" what is your name ? :  ");
                    string librarianName = Console.ReadLine();
                    Librarian l1 = new Librarian(librarianName);
                    Console.WriteLine($"welcome ya {l1.Name}");

                    while (true) // Librarian loop
                    {
                        Console.Write(" Add book (A) , remove book (R) , Display books (D) , to back and choose role again (B): ");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch (choice)
                        {
                            case 'A':
                                Console.WriteLine("enter book details");
                                string bookName = Console.ReadLine();
                                string author = Console.ReadLine();
                                int bookYear = Convert.ToInt32(Console.ReadLine());
                                Book b1 = new Book
                                {
                                    Title = bookName,
                                    Author = author,
                                    PublishYear = bookYear
                                };
                                l1.AddBook(b1, library);
                                break;

                            case 'R':
                                Console.WriteLine("enter book details to remove");
                                bookName = Console.ReadLine();
                                author = Console.ReadLine();
                                bookYear = Convert.ToInt32(Console.ReadLine());
                                b1 = new Book
                                {
                                    Title = bookName,
                                    Author = author,
                                    PublishYear = bookYear
                                };
                                l1.RemoveBook(b1, library);
                                break;

                            case 'D':
                                Console.WriteLine("the book list : ");
                                l1.Display(library);
                                break;

                            case 'B':
                                goto EndLibrarian;

                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }
                EndLibrarian:;
                }
                else if (userType == 'R')
                {
                    Console.Write(" what is your name ? :  ");
                    string regularname = Console.ReadLine();
                    RegularUser u1 = new RegularUser(regularname);
                    Console.WriteLine($"welcome ya {u1.Name}");

                    while (true) // RegularUser loop
                    {
                        Console.Write(" Borrow (B) , Display books (D) , to back and choose role again (K): ");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch (choice)
                        {
                            case 'B':
                                Console.WriteLine("enter book details");
                                string bookName = Console.ReadLine();
                                string author = Console.ReadLine();
                                int bookYear = Convert.ToInt32(Console.ReadLine());
                                Book b1 = new Book
                                {
                                    Title = bookName,
                                    Author = author,
                                    PublishYear = bookYear
                                };
                                u1.Borrow(b1, library);
                                break;

                            case 'D':
                                Console.WriteLine("the book list : ");
                                u1.Display(library);
                                break;

                            case 'K':
                                // هنا هنكسر اللوب بتاعت اليوزر
                                goto EndUser;

                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }
                EndUser:;
                }
                else if (userType == 'E')
                {
                    Console.WriteLine("Goodbye!");
                    break; 
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }
}
