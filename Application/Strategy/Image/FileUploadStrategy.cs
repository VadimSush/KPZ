namespace Strategy
{
    public class FileUploadStrategy : UploadStrategy
    {
        public override void Upload(string href)
        {
            Console.WriteLine($"Upload image from file system. Path: {href}");
        }
    }
}
