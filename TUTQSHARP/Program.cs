using System.Runtime.Serialization;

public class Person
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = null;
}

public class Iden : Person
{
    public Iden()
    {
        Id = 0;
        Name = "Iden";
    }
}

public class Program
{
    // the original solution to Clement's Answer doesn't use double while loops
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        var seqIdx = 0;
        var arrIdx = 0;
        while(arrIdx < array.Count && seqIdx < sequence.Count)
            {
            if (array[arrIdx] == sequence[seqIdx])
            {
                seqIdx++;
            }
            arrIdx++;
        }
        // the reverse double here. Without it, his original method doesn't work for any case given other than his artificial ones
        array.Reverse();
        seqIdx = 0;
        arrIdx = 0;
        while (arrIdx < array.Count && seqIdx < sequence.Count)
        {
            if (array[arrIdx] == sequence[seqIdx])
            {
                seqIdx++;
            }
            arrIdx++;
        }
        // end rev
        return seqIdx == sequence.Count;
    }

    public static void Main()
    {
        int bin = 0b1001_1010_0001_0100;
        int hex = 0x1b_a0_44_fe;
        int data = 1_2__3___4____5_____6______7________8_________9;
        double real = 1_000.111_1e-1_000;
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs.Add("bin", bin);
        keyValuePairs.Add("hex", hex);
        keyValuePairs.Add("data", data);
        int[] numbers = { 2, 3, 4, 5 };

        TuplS tupleS = new TuplS();
        var eip = tupleS.TuplRet(1000);
        Console.WriteLine("this guy is here{0}, " +
            "this thing here {1}, in the year {2}", eip.Item1);

        for (int i = 0; i < keyValuePairs.Count; i++)
        {
            Console.WriteLine(keyValuePairs.Values.ToString());
        }

        Console.WriteLine(real + " " + AssignValue(out var Name));
        Console.WriteLine(IsValidSubsequence().ToString());

        var httpstatuscode = 402;

        // a Func Lambda
        Func<int, int, int> eddy = (int d, int c) => { return d + c; };

        // you can do this = >
        var Medsci = (int[] e, int w) => { return e[w]; };
        // much simpler code...

        // or this bullshit
        ref int itenb = ref GivNumb(numbers, Medsci.Invoke(numbers, 0 /*<= this number is finiky*/));

        Console.WriteLine(Medsci.Invoke(numbers, 2)+ " " + itenb);

        long total = 0;
        Demo(10, 323, ref total);

        Console.WriteLine("Http status code :");
        Person person = new Person();
        var name = person?.Name ?? "Name is Null";
        try
        {
            throw new Exception(httpstatuscode.ToString());
        }
        catch (Exception ex) when (ex.Message.Equals("400"))
        {
            Console.WriteLine("Bad Request");

            if (ex.Message.Equals("401"))
            {
                Console.Write("Unauthorized");
            }
        }
        catch (Exception ex) when (ex.Message.Equals("402"))
        {
            Console.Write("Unauthorized");
        }
        catch (Exception ex) when (ex.Message.Equals("500"))
        {
            Console.Write("Bad Request");
        }

        int Ie = 0;
        int jf = 0;
        try
        {
            if (jf > 0)
            {
                Console.WriteLine("Res:{0}", Ie / jf);
            }
            else
            {
                throw new MyEx("Cannot divide by zero."); // MyEX
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        var val = 0b0;
        var val2 = 0b1;


        DemoAlpha da = new DemoAlpha();
        da.MethodThrownException();

        Iden iden = new Iden();

        if(iden is Person)
        {
            Console.WriteLine("moooooooo");
        }
        else
        {
            Console.WriteLine("This person does not exist..");
        }

        switch (iden)
        {
            case Iden iden1 when (iden1.Id.Equals(person.Id)):
                Console.WriteLine("Gei");
                break;
            default:
                Console.WriteLine("Nope..");
                break;
        }

        var op = new Tuple<string, string, int>("Sol", "C#", 2022);
        Console.WriteLine("K{0}, in this make he wrote it in {1}.");
    }

    public static ref int GivNumb(int[] me, int index)
    {
        return ref me[index]; // ref ref reeeeef
    }

    public static string AssignValue(out string str)
    {
        str = "TJ";
        return str;
    }

    private static bool IsValidSubsequence()
    {
        return IsValidSubsequence(new List<int>() { 3, 4, 5, 6}, new List<int>() {6,4});
    }

    public static long Demo(long a, long b, ref long c)
    {
        c = a + b;
        return c;
    }

}

public class TuplS
{
    public TuplS()
    {

    }
    public TuplS(string a , string b , int c)
    {
        // waits
    }
    public (string, string, int) TuplRet(int e)
    {
        string name = string.Empty;
        string title = string.Empty;
        int year = 0;

        if (e == 1000)
        {
            name = "Sol";
            title = "C#";
            year = 2022;
        }
        Console.WriteLine("Ok!");
        return (name, title, year);
    }
}

[Serializable]
internal class MyEx : Exception
{
    public MyEx()
    {
    }

    public MyEx(string? message) : base(message)
    {
    }

    public MyEx(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MyEx(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public override string Message => "We cannot divide a number by zero";
}

public class DemoAlpha
{
    StreamReader streamReader = new StreamReader("C:/Users/azuka/source/repos/TUTQSHARP/TUTQSHARP/dmz.txt");
    public async void MethodThrownException()
    {
        try
        {
            string s = streamReader.ReadToEnd();
            Console.WriteLine(s);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            await Log();
        }
        finally
        {
            await Close();
        }
    }
    private async Task Log()
    {
        Console.WriteLine("Date : {0} & Time : {1}",
            DateTime.Now.ToLongDateString(),
            DateTime.Now.ToLongTimeString());
    }

    private async Task Close()
    {
        if (streamReader != null)
        {
            streamReader.Close();
        }
    }
}