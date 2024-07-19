namespace FinalExamTaskC_;

public class StomatologiyaManager:IManager
{

    public List<Doctor> Doctors { get; set; }

    public StomatologiyaManager()
    {
        Doctors = new List<Doctor>
        {
            new Doctor(6,1, "Memmed", "Mensimli"),
            new Doctor(7,2, "Nicat", "Memmedov"),
            new Doctor(8,3, "Nihat", "Rufulayev"),
            new Doctor(9,4, "Ruslan", "Abassov")
        };
    }

}
