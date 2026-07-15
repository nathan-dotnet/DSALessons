namespace CSharpLesson.OOPLessons
{
    public class Encapsulation  //
    {
        public string Name { get; set; }
        private int _speed;
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value >= 0 && value <= 100)
                    _speed = value;
                else
                    Console.WriteLine("Invalid speed!");
            }
        }
        public bool IsRunning { get; set; }

        public Encapsulation(string name, int speed, bool isRunning)  // ← rename constructor too
        {
            Name = name;
            Speed = speed;
            IsRunning = isRunning;
        }

        public static void Run()
        {
            Encapsulation m1 = new Encapsulation("Drill Press", 75, true);
            Encapsulation m2 = new Encapsulation("Conveyor", 150, false);
            Encapsulation m3 = new Encapsulation("Lathe", 50, true);

            Console.WriteLine(m1.Name + " | Speed: " + m1.Speed + " | Running: " + m1.IsRunning);
            Console.WriteLine(m2.Name + " | Speed: " + m2.Speed + " | Running: " + m2.IsRunning);
            Console.WriteLine(m3.Name + " | Speed: " + m3.Speed + " | Running: " + m3.IsRunning);
        }
    }
}