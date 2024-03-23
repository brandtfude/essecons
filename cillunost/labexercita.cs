public byte[] ReadFileData(string filePath)
{
    try
    {
        byte[] fileData = File.ReadAllBytes(filePath);
        return fileData;
    }
    catch (IOException e)
    {
        Console.WriteLine("An error occurred while reading the file: " + e.Message);
        return null;
    }
}
