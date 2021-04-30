using System;

namespace LibraryClassConstructor
{
    public class User{
        private string id;
        private string name;
        private string surname;
        private int YearofSubscription;

        public User (string id, string name, string surname, int YearofSubscription){
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.YearofSubscription = YearofSubscription;
        }
        public string FullName(){
            return this.name + " " + this.surname;
        }
    }

    public class Book{
        private string id;
        private string title;
        private string author;
        private User user;

        public Book (string id, string title, string author){
            this.id = id;
            this.title = title;
            this.author = author;
            this.user = null;
            
        }
        public string Description(){
            return this.title + " " + this.author;

        }
        public void Prestito(User user){
            if (this.user != null){
                Console.WriteLine($"Mi spiace, il libro da lei richiesto è già in prestito a {this.user .FullName()}");
                return;
            }
            this.user =user;
            Console.WriteLine($"Titolo prestato a {this.user.FullName()}");
        }

        public void BookBack(){
            Console.WriteLine($"{this.user.FullName()} ha eseguito la restituzione con successo.");
            this.user = null;
        }
        
    }

    public class Library {

        public static void Main(string[] args){
            User user1 = new User ("00001", "Birillo", "Impennato", 2017);
            Console.WriteLine(user1.FullName());
            User user2 = new User("00002", "Barilla", "Scotta", 2014);
            Console.WriteLine(user2.FullName());
            User user3 = new User("00001", "Bio", "Parco", 2010);
            Console.WriteLine(user3.FullName());

            Book book = new Book ("B001", "Harry Potter Il Prigioniero di Azkaban", "Alex Caviglia");
            Console.WriteLine(book.Description());

            book.Prestito(user1);
            book.Prestito(user2);
            book.Prestito(user3);
            book.BookBack();
            book.Prestito(user2);
    }
}
}
