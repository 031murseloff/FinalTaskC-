namespace FinalExamTaskC_;

public class PediatriyaManager:IManager
{
    

    public List<Doctor> Doctors { get; set; }

    public PediatriyaManager()
    {
        Doctors = new List<Doctor>
        {
          new Doctor(1,19,"Elshan","Mursalov"),
          new Doctor(2,2,"Sadiq","Mursalov"),
          new Doctor(3,5,"Nebi","Mensimli")
        };
    }



}
