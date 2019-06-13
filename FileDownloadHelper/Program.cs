using System;

namespace FileDownloadHelper
{
    class Program
    {
        static void Main(string[] args)
        {

            Model.ImageInfo imageInfo = new Model.ImageInfo()
            {
                Datas = Guid.NewGuid().ToString()

            };
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.ImageInfos.Add(imageInfo);
                int count =  db.SaveChanges();
                Console.WriteLine(count);
            }
       

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
