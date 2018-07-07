using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Accounting
{
    public class Personnel
    {
        public int Id { get; }
        public string Name { get; }
        public decimal SSNumber { get; }
        public decimal PersonNumber { get; }

        public IEnumerable<Contract> Contracts { get; private set; }

        public Personnel(int id, string name, decimal ssNumber, decimal personNumber)
        {
            Id = id;
            Name = name;
            SSNumber = ssNumber;
            PersonNumber = personNumber;
        }

        public Personnel(int id, string name, decimal ssNumber, decimal personNumber, IEnumerable<Contract> contracts)
            : this(id, name, ssNumber, personNumber)
        {
            Contracts = contracts;
        }
    }
}