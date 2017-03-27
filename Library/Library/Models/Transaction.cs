using System;

namespace Library.Models
{
    public class Transaction
    {
        private static int SerialId = 10001;

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public decimal Value { get; private set; }
        public string Details { get; private set; }

        public Transaction(decimal value, string details)
        {
            Id = SerialId++;
            Date = DateTime.Now;
            Value = value;
            Details = details;
        }
    }
}