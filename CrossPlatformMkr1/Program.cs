using CrossPlatformMkr1.FilesUtil;
using CrossPlatformMkr1.Util;

public class Program()
{
    private static readonly string PathInput = Path.Combine(Path.GetFullPath("CrossPlatformMkr1"), "Files", "INPUT.txt");
    private static readonly string PathOutput = Path.Combine(Path.GetFullPath("CrossPlatformMkr1"), "Files", "OUTPUT.txt");

    public static void Main(String[] args)
    {
        try
        {
            

            var line = FileReader.Read(PathInput);
            
            var validate = Validator.Validate(line);
            if (validate)
            {
                var uniqueThreeDigitCount = NumberProcessor.GetUniqueThreeDigitCount(line);
                FileWriter.Write(PathOutput, uniqueThreeDigitCount);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}