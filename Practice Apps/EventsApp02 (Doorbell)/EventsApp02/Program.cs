namespace EventsApp02
{
    public class Doorbell
    {
        // Declare an event
        public event Action? BellRang;

        // Trigger the event
        public void Press()
        {
            Console.WriteLine("Someone pressed the doorbell!");

            BellRang?.Invoke();
        }
    }

    public class Person
    {
        public void AnswerDoor()
        {
            Console.WriteLine("Person: I'll answer the door!");
        }
    }

    public class SecurityCamera
    {
        public void StartRecording()
        {
            Console.WriteLine("Camera: Starting recording!");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Doorbell doorbell = new Doorbell();

            Person person = new Person();
            SecurityCamera camera = new SecurityCamera();

            // Subscribe to the event
            doorbell.BellRang += person.AnswerDoor;
            doorbell.BellRang += camera.StartRecording;

            // Trigger the event
            doorbell.Press();
        }
    }
}
