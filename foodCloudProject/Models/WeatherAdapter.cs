namespace foodCloudProject.Models
{
    public class WeatherAdapter
    {
        public string Check(string City)
        {
            //להתחבר לשרת גייט ולקבל נתונים על מזג האויר 
            return $"בעיר{City}היום נעים טמפרטורה 29 מעלות";
        }
    }
}
