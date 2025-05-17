namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string FileFormat { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Ebook in {FileFormat} format)";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Textbook on {Subject}) by {Author}";
            }
        }

        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public double Duration { get; set; } 
            public override string GetInfo()
            {
                return $"{Title} (Audiobook, Narrated by {Narrator}, {Duration} hours)";
            }
        }

        public void DisplayBooksInfo(Book[] books)
        {
            listBoxBooks.Items.Clear(); 
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo()); 
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books =
            {
                new Book { Title = "C# Fundamentals", Author = "John Doe" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Smith", IssueNumber = 45 },
                new Ebook { Title = "Mastering C#", Author = "Alice Brown", FileFormat = "PDF" },
                new Textbook { Title = "Physics for Beginners", Author = "Dr. Richard", Subject = "Physics" },
                new AudioBook { Title = "Learn C# in 10 Hours", Author = "Mike Ross", Narrator = "James Dean", Duration = 10.5 }
            };

            DisplayBooksInfo(books);
        }
    }
}
