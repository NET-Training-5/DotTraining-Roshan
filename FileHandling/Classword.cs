using System.IO;
class FileIO
{

    public void createFile()
    {
                    for (byte counter = 0; counter < 10; counter++)
            {
                Directory.CreateDirectory($@"D:\Data\Folder1{counter}");
                
                
                    
                    
                 //File.Create($@"D:\Data\Folder1{counter}\Roshan{counter}.txt");
                File.WriteAllText($@"D:\Data\Folder1{counter}\Roshan{counter}.txt",$"This is a folder{counter}");
;              
                


                    

            }

    }

}