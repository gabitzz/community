namespace DevExpress.DevAV
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class CustomerInfoWithSales
    {
        private Lazy<IEnumerable<CustomerStore>> customerStores;
        private Lazy<IEnumerable<CustomerEmployee>> customerEmployees;

        public long Id { get; set; }

        public string Name { get; set; }

        public string HomeOfficeLine { get; set; }

        public string HomeOfficeCity { get; set; }

        public StateEnum HomeOfficeState { get; set; }

        public string HomeOfficeZipCode { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public Decimal? TotalSales { get; set; }

        public IEnumerable<CustomerStore> CustomerStores
        {
            get
            {
                return this.customerStores.Value;
            }
        }

        public IEnumerable<CustomerEmployee> Employees
        {
            get
            {
                return this.customerEmployees.Value;
            }
        }

        public IEnumerable<Decimal> MonthlySales { get; private set; }

        public void Init(Func<IEnumerable<CustomerStore>> getStores, Func<IEnumerable<CustomerEmployee>> getEmployees, IEnumerable<Decimal> monthlySales)
        {
            this.customerStores = new Lazy<IEnumerable<CustomerStore>>(getStores);
            this.customerEmployees = new Lazy<IEnumerable<CustomerEmployee>>(getEmployees);
            this.MonthlySales = monthlySales;
        }
    }
}

