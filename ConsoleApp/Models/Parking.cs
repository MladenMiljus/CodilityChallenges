namespace CodilityChallenges.Models
{
    internal class Parking
    {
        public int Bill;
        private readonly int _priceForEntry = 2;
        private readonly int _priceForFirstHour = 3;
        private readonly int _priceForEachAdditionalHour = 4;

        internal Parking(TimeSpan entry, TimeSpan departure)
        {
            Bill = CalculateBill(entry, departure);
        }

        private int CalculateBill(TimeSpan entry, TimeSpan departure)
        {
            var totalHours = (departure - entry).Hours;
            var totalMinutes = (departure - entry).Minutes;
            var startedHoursAfterFirst = totalMinutes > 0 ? totalHours : totalHours - 1;

            return _priceForEntry + _priceForFirstHour + startedHoursAfterFirst * _priceForEachAdditionalHour;
        }
    }
}
