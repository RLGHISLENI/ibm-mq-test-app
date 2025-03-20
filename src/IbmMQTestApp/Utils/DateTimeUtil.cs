namespace IbmMQTestApp.Utils
{
    public static class DateTimeUtil
    {

        public static DateTime ConvertToLocalTime(this DateTime utcDateTime)
        {
            // Converte o DateTime fornecido para o fuso horário local
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, TimeZoneInfo.Local);
        }
    }
}
