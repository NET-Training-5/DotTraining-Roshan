using System.IO;
class FileIO
{

    public void createFile()
    {
        string fullFilePath = @$"{folderPath}\abc.txt";
        File.WriteAllText(fullFilePath,"This is a test program");
    }

}