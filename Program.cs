namespace complexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Contacts contacts = new Contacts();
            contacts.AddContact(new Contact("Said", "28127"));
            contacts.AddContact(new Contact("Hamed", "232323"));
            contacts.AddContact(new Contact("Salim", "837312"));

            Console.WriteLine(contacts.GetContact("Hamed"));
        }
    }
}