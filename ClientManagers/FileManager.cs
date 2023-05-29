class FileManager{
    public bool VulFileopen ()
    {
        string path = "./PC_vul_checklist.txt";

        try
        {
            FileStream fs = File.Open (path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

        return true;
    }
}