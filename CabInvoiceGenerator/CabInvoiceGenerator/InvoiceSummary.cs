using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalFare;
        private double avrageFare;

        
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.avrageFare = this.totalFare / this.numberOfRides;
        }
        public InvoiceSummary(int numberOfRides, double totalFare, double avrageFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.avrageFare = avrageFare;
        
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;
            InvoiceSummary inputObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputObject.numberOfRides && this.totalFare == inputObject.totalFare && this.avrageFare == inputObject.avrageFare;
        }


        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.avrageFare.GetHashCode();
        }
    }
}