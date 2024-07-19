namespace FinalExamTaskC_;

public class TravmatologiyaManager:IManager
{

    public List<Doctor> Doctors { get ; set ; }

    public TravmatologiyaManager()
    {
        Doctors = new List<Doctor>
        {
           new Doctor(4,10,"Cavid","Mensimli"),
           new Doctor(5,2,"Elvin","Dadasov")
        };
    }
}
