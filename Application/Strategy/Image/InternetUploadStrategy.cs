namespace Strategy
{
    public class InternetUploadStrategy : UploadStrategy
    {
        public override void Upload(string href)
        {
            Console.WriteLine($"Upload image from Internet. Path to web-page: {href}");
        }
    }
}
