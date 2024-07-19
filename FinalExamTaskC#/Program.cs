

using FinalExamTaskC_;
using FinalExamTaskC_.Users;
using System.Threading.Channels;

class Program
{

    public static void PrintDoctors(IManager manager)
    {
        int count = 1;
        manager.Doctors.ForEach(doc => {
            Console.WriteLine($"{count}.{doc}");
            count++;
        });

        Console.Write("Hekim seçin: ");
        int doctorIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (doctorIndex < 0 || doctorIndex >= manager.Doctors.Count)
        {
            Console.WriteLine("Geçersiz hekim seçimi");
            return;
        }

        Doctor selectedDoctor = manager.Doctors[doctorIndex];
        count = 1;
        selectedDoctor.TimeSlots.ForEach(slot => {
            Console.WriteLine($"{count}. {slot}");
            count++;
        });

        Console.Write("Saat seçin: ");
        int timeSlotIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (timeSlotIndex < 0 || timeSlotIndex >= selectedDoctor.TimeSlots.Count)
        {
            Console.WriteLine("Yanlis Saat secimi");
            return;
        }

        TimeSlot selectedSlot = selectedDoctor.TimeSlots[timeSlotIndex];

        if (selectedSlot.IsReserved)
        {
            Console.WriteLine("Bu saat rezerv edilmisdir!");
        }
        else
        {
            selectedSlot.IsReserved = true;
            Console.WriteLine("Rezervasya Ugurludur!");
            return;
        }
    }

    static void Main(string[] args)
    {

        Console.Write("Name:");
        string Name = Console.ReadLine();

        Console.Write("Surname:");
        string Surname = Console.ReadLine();

        Console.Write("Email:");
        string Email = Console.ReadLine();

        Console.Write("Phone:");
        string Phone = Console.ReadLine();

        UserManager.UserAdd(new User(1, Name, Surname, Email, Phone));


        Console.WriteLine("1.Pediatriya\n2.Stomotlogiya\n3.Travmatologiya\n");

        Console.Write("Secim: ");
        int secim = Convert.ToInt32(Console.ReadLine());

        IManager manager = null;

        switch (secim)
        {
            case 1:
                {
                    manager = new PediatriyaManager();
                    JsonTransation.JsonSeralizeMethod(manager, "PediatriyaDoctors");

                    PrintDoctors(manager);
                    break;
                }
            case 2:
                {
                    manager = new StomatologiyaManager();
                    JsonTransation.JsonSeralizeMethod(manager, "StomalogiyaDoctors");

                    PrintDoctors(manager);
                    break;
                }
            case 3:
                {
                    manager = new TravmatologiyaManager();

                    JsonTransation.JsonSeralizeMethod(manager, "TravmatologiyaDoctors");

                    PrintDoctors(manager);
                    break;
                }
            default:
                {
                    Console.WriteLine("Geçersiz seçim");
                    break;
                }
        }


        PrintDoctors(manager);
        
        


    }



}











