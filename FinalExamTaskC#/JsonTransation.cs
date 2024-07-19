using Newtonsoft.Json;
using System.Threading.Channels;

namespace FinalExamTaskC_;

public static class JsonTransation
{
    public static void JsonSeralizeMethod(IManager manager,string FileName)
    {
        var JsonString=JsonConvert.SerializeObject(manager.Doctors, Formatting.Indented);
        File.WriteAllText($"{FileName}.json", JsonString);

    }


    public static void JsonDeserializeMethod(string FileName)
    {

        var stringData=File.ReadAllText($"{FileName}.json");
        var CDate = JsonConvert.DeserializeObject<List<Doctor>>(stringData);
       
        

    }

}
