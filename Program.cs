namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library Management System");
            Library library = new Library();

            while (true) // Main Menu loop
            {
                Console.WriteLine("If you are a regular user enter (R), if you are librarian enter (L), to exit (E)");
                char userType = Console.ReadLine().ToUpper()[0];

                if (userType == 'L')
                {
                    Console.Write("What is your name? : ");
                    string librarianName = Console.ReadLine();
                    Librarian librarian = new Librarian(librarianName);
                    Console.WriteLine($"Welcome, {librarian.Name}");

                    while (true) // Librarian loop
                    {
                        Console.Write("Add book (A), Remove book (R), Display books (D), Back (B): ");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch (choice)
                        {
                            case 'A':
                                Console.WriteLine("Enter book details (Title, Author, Year):");
                                string bookName = Console.ReadLine();
                                string author = Console.ReadLine();
                                int bookYear = Convert.ToInt32(Console.ReadLine());
                                Book newBook = new Book
                                {
                                    Title = bookName,
                                    Author = author,
                                    PublishYear = bookYear
                                };
                                librarian.AddBook(newBook, library);
                                break;

                            case 'R':
                                Console.WriteLine("Enter book details to remove (Title, Author, Year):");
                                bookName = Console.ReadLine();
                                author = Console.ReadLine();
                                bookYear = Convert.ToInt32(Console.ReadLine());
                                Book bookToRemove = new Book
                                {
                                    Title = bookName,
                                    Author = author,
                                    PublishYear = bookYear
                                };
                                librarian.RemoveBook(bookToRemove, library);
                                break;

                            case 'D':
                                Console.WriteLine("The book list:");
                                librarian.Display(library);
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
                    Console.Write("What is your name? : ");
                    string regularName = Console.ReadLine();
                    RegularUser user = new RegularUser(regularName);
                    Console.WriteLine($"Welcome, {user.Name}");

                    while (true) // RegularUser loop
                    {
                        Console.Write("Borrow (B), Display books (D), Back (K): ");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch (choice)
                        {
                            case 'B':
                                Console.WriteLine("Enter book details (Title, Author, Year):");
                                string bookName = Console.ReadLine();
                                string author = Console.ReadLine();
                                int bookYear = Convert.ToInt32(Console.ReadLine());
                                Book bookToBorrow = new Book
                                {
                                    Title = bookName,
                                    Author = author,
                                    PublishYear = bookYear
                                };
                                user.Borrow(bookToBorrow, library);
                                break;

                            case 'D':
                                Console.WriteLine("The book list:");
                                user.Display(library);
                                break;

                            case 'K':
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
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
