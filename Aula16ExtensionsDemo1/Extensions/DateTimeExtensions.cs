using System.Globalization;

/*Traditional Method to create a namspace, but this extension can be used better.
 * creating the namespace in System.
 * namespace Aula16ExtensionsDemo1.Extensions*/
namespace System
{
    static class DateTimeExtensions //Rule: The Extension Class need to be "static"
    {
        //The method must be public static  to work in this extension.
        public static string ElapsedTime(this DateTime thisObj) //this Datetime - indicates the Extension method to the DateTime type.
                                                                //thisObj es the name of the parameter
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)+" Hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)+ " Days";
            }
        }
    }
}
