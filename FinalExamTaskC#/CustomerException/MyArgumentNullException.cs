namespace FinalExamTaskC_.CustomerException;

public class MyArgumentNullException:Exception
{

    public MyArgumentNullException() { }

    public MyArgumentNullException(string message) : base(message) { }

    public MyArgumentNullException(string v1,string v2) : base(v2) { }


    
}
