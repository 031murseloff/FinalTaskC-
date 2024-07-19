namespace FinalExamTaskC_;

public class TimeSlot
{

    public string Time { get; set; }
    public bool IsReserved { get; set; }

    public TimeSlot(string time)
    {
        Time = time;
        IsReserved = false;
    }

    public override string ToString()
    {
        return $"{Time} - {(IsReserved ? "Rezerve edilmiş" : "Rezerve edilmemiş")}";
    }
}
