namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
            string[] rsvps = new string[10];
            int count = 0;

            void RSVP(string name, int partySize, string allergies, bool inviteOnly)
            {
                if (inviteOnly)
                {
                    // search guestList before adding rsvp
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVPs()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }


            }
        }
    }
}
