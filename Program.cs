namespace HelloWorld
{
    class Program
    {
        private static object ex;

        static void Main(string[] args)
        {  
            
             try //Hataya sebebiyet verme ihtimali olan kod
             {
                Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi:" +  sayi);
             }
            catch (Exception ex) //Hata ile karşılaşıldığında ne yapılacağı buraya yazılır
             {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            
             }   
             finally //Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız 
             {
                Console.WriteLine("İslem Tamamlandi");

             }

             try
             {
                 int a = int.Parse(Console.ReadLine());

                 int b = int.Parse(Console.ReadLine());

                 int c = a+b;

                 Console.WriteLine(c);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
             }
             finally
             {
                Console.WriteLine("İşlem tamamlandı.");

             }

             try
             {
                int x = int.Parse(null);
             }
             catch (ArgumentNullException ex)  
             {
                
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);
             }

            
        }
    }
}