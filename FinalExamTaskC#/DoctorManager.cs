

using FinalExamTaskC_.CustomerException;

namespace FinalExamTaskC_;

public class DoctorManager
{

    public void AddDoctor(IManager manager, Doctor doctor)
    {

        manager.Doctors.Add(doctor);

    }

    public Doctor GetById(IManager manager, int id)
    {
       

        var doctor = manager.Doctors.Find(doc => doc.ID == id);
        if (doctor == null)
        {
          throw new MyArgumentNullException("Doctor cannot be bull");
           
        }

        return doctor;
    }

    public List<Doctor> GetDoctors(IManager manager,Func<Doctor,bool>func) { 
    
    var docs=manager.Doctors.Where(func).ToList();
        return docs;
    

    }

    
    public void UpdateDoctor(IManager manager,int id,Doctor doctor)
    {

       var newDoctor=manager.Doctors.Find(doc=>doc.ID == id);

        if (newDoctor != null) {

            newDoctor.Name = doctor.Name;
            newDoctor.Surname = doctor.Surname;
            newDoctor.Experience = doctor.Experience;

        }
        

    }

    public void RemoveDoctor(IManager manager, int id)
    {

        manager.Doctors.RemoveAll(doc => doc.ID == id);

    }




}
