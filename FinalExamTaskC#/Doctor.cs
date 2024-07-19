namespace FinalExamTaskC_;

public class Doctor
{
    public int ID { get; set; }
    public int Experience { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public List<TimeSlot> TimeSlots { get; set; }

    public Doctor(int id, int experience, string name, string surname)
    {
        ID = id;
        Experience = experience;
        Name = name;
        Surname = surname;

        TimeSlots = new List<TimeSlot>
        {
            new TimeSlot("09:00-10:00"),
            new TimeSlot("10:00-11:00"),
            new TimeSlot("11:00-12:00")
            
        };
    }

    public override string ToString() => $"Experience: {Experience}\n  Name: {Name}\n  Surname: {Surname}\n";
}
