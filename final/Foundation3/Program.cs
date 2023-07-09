using System;

class Program
{
    static void Main(string[] args)
    {

            Lecture lecture = new Lecture("This is a Lecture", "A lecture on a Lecture", new DateTime (12,12,12), new TimeSpan (12,12,12), "1000 Frog St",
                    "Sacramento", "CA", "10000", "Mr. Smith", 25);

            Reception reception = new Reception("Evil Scientist", "Recpetion for Evil Scientist",new DateTime (11,11,11), new TimeSpan (11,11,11), 
                    "1000 Chicken Street", "TriCity", "CA", "2000", "evil.scentist@unknown");

            Outdoor outdoor = new Outdoor("Call of the Frogs", "A meeting to call frogs", new DateTime (10,10,10), new TimeSpan (10,10,10),
                    "400 Bird St.", "FrogTown", "CA", "2345", "Cold and Rainy");

            Console.WriteLine();        
            Console.WriteLine(lecture.EventDetailsFull());
            Console.WriteLine();   
            Console.WriteLine(lecture.FullDeatails());
            Console.WriteLine();  
            Console.WriteLine(lecture.ShortDetails()); 
            Console.WriteLine();  
            Console.WriteLine(reception.EventDetailsFull());
            Console.WriteLine();   
            Console.WriteLine(reception.FullDeatails()); 
            Console.WriteLine();
            Console.WriteLine(reception.ShortDetails()); 
            Console.WriteLine();    
            Console.WriteLine(outdoor.EventDetailsFull());
            Console.WriteLine();   
            Console.WriteLine(outdoor.FullDeatails()); 
            Console.WriteLine();
            Console.WriteLine(outdoor.ShortDetails()); 
            Console.WriteLine();        
    }
}