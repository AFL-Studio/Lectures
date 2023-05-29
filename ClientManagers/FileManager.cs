class FileManager{
    public bool VulFileOpen()
    {
        String line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("./PC_vul_checklist.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);

            return false;
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        return true;
    }

    public bool VulFileLoad()
    {


        return true;
    }
}