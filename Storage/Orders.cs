using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    enum TermsOfPayment
    {
        [Description("Készpénz")]
        cash,
        [Description("Átutalás")]
        transfer,
        [Description("Bankkártya")]
        bankCard
    }
    class Orders
    {
        int? id;
        List<Products> product;
        Users user;
        PartnerClass partner;
        PartnerClass companyData;
        DateTime orderDate;
        DateTime completionDate;
        DateTime paymentDeadline;
        bool innoviced;
        TermsOfPayment termsOfPayment;
        string customer;

        public Orders(int? id, List<Products> product, Users user, PartnerClass partner, PartnerClass companyData, DateTime orderDate, DateTime completionDate, DateTime paymentDeadline, bool innoviced, TermsOfPayment termsOfPayment, string customer)
        {
            Id = id;
            Product = product;
            User = user;
            Partner = partner;
            CompanyData = companyData;
            OrderDate = orderDate;
            CompletionDate = completionDate;
            PaymentDeadline = paymentDeadline;
            Innoviced = innoviced;
            TermsOfPayment = termsOfPayment;
            Customer = customer;
            
        }
        public Orders(List<Products> product, Users user, PartnerClass partner, PartnerClass companyData, DateTime orderDate)
        {
            Product = product;
            User = user;
            Partner = partner;
            CompanyData = companyData;
            OrderDate = orderDate;
        }
        public Orders(int? id, DateTime orderDate, DateTime completionDate, DateTime paymentDeadline, bool innoviced, TermsOfPayment termsOfPayment, string customer)
        {
            Id = id;
            OrderDate = orderDate;
            CompletionDate = completionDate;
            PaymentDeadline = paymentDeadline;
            Innoviced = innoviced;
            TermsOfPayment = termsOfPayment;
            Customer = customer;
        }
        public Orders(DateTime orderDate, DateTime completionDate, DateTime paymentDeadline, bool innoviced, TermsOfPayment termsOfPayment)
        {
            OrderDate = orderDate;
            CompletionDate = completionDate;
            PaymentDeadline = paymentDeadline;
            Innoviced = innoviced;
            TermsOfPayment = termsOfPayment;
        }

        public int? Id { get => id; set => id = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        internal List<Products> Product { get => product; set => product = value; }
        internal Users User { get => user; set => user = value; }
        internal PartnerClass Partner { get => partner; set => partner = value; }
        internal PartnerClass CompanyData { get => companyData; set => companyData = value; }
        public DateTime CompletionDate { get => completionDate; set => completionDate = value; }
        public DateTime PaymentDeadline { get => paymentDeadline; set => paymentDeadline = value; }
        public bool Innoviced { get => innoviced; set => innoviced = value; }
        internal TermsOfPayment TermsOfPayment { get => termsOfPayment; set => termsOfPayment = value; }
        public string Customer { get => customer; set => customer = value; }
    }
}
