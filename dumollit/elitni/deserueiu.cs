static void HandleFile(string path)
{
    try
    {
        // Read all the content from the file
        string content = File.ReadAllText(path);
        
        // Process the content here
        Console.WriteLine("File content:");
        Console.WriteLine(content);
    }
    catch (IOException e)
    {
        // Handle any IO errors here
        Console.WriteLine("An error occurred while handling the file:");
        Console.WriteLine(e.Message);
    }
}
