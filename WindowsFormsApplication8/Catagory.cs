using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Catagory
    {
        //default constructor 
        public Catagory()
        {
            newCatagory_a = 0.0;
            newCatagory_b = 0.0;
            newCatagory_c = 0.0;
            newCatagory_d = 0.0;
            newPayment = 0.0;
            newNI = 0.0;
            newTax = 0.0;
            newFinal_payment = 0.0;
 
        }

        //overload contructor
        public Catagory(double catagory_a, double catagory_b, double catagory_c, double catagory_d, double payment, double NI, double Tax, double final_payment)
        {
            newCatagory_a = catagory_a;
            newCatagory_b = catagory_b;
            newCatagory_c = catagory_c;
            newCatagory_d = catagory_d;
            newNI = NI;
            newTax = Tax;
            newPayment = payment;
            newFinal_payment = final_payment;
        }

        

        public Catagory(string catagory_a_2)
        {
            // TODO: Complete member initialization
            this.catagory_a_2 = catagory_a_2;
        }

        public double[] getCatagory_a()
        {
             payment = 37.5 * 48 * 19 ;
             NI = (37.5 * 48 * 19) * 12 / 100;
             Tax = payment * 30 / 100;
             final_payment = payment - (Tax + NI);
            

             return new double[] { payment, NI, Tax, final_payment };


        }
        public double[] getCatagory_b()
        {
            payment = 37.5 * 48 * 17;
            NI = (37.5 * 48 * 17)*12/100;
            Tax = payment * 20 / 100;
            final_payment = payment - (Tax + NI);

            return new double[] { payment, NI, Tax, final_payment };
        }
        public double[] getCatagory_c()
        {
            Math.Round(Convert.ToDouble(payment = 37.5 * 48 * 19));
            Math.Round(Convert.ToDouble(NI = (37.5 * 48 * 10) * 12 / 100));
            Math.Round(Convert.ToDouble(Tax = payment * 10 / 100));
            Math.Round(Convert.ToDouble(final_payment = payment - (Tax + NI)));
           

            return new double[] { payment, NI, Tax, final_payment };
        }
        public double[] getCatagory_d()
        {
            payment = 37.5 * 48 * 5.5;
            NI = (37.5 * 48 * 5.5) * 12 / 100;
            Tax = payment * 0 / 100;
            final_payment = payment - (Tax + NI);

            return new double[] { payment, NI, Tax, final_payment };
        }

        public double getCatagory_a_payment()
        {
            payment = 37.5 * 48 * 19;
            return payment;
        }
        public double getCatagory_a_NI()
        {
            NI = (37.5 * 48 * 19) * 12 / 100;
            return NI;
        }
        public double getCatagory_a_Tax()
        {
            payment = 37.5 * 48 * 19;
            Tax = payment * 30 / 100;
            return Tax;
        }
        public double getCatagory_a_Final()
        {
            payment = 37.5 * 48 * 19;
            NI = (37.5 * 48 * 19) * 12 / 100;
            Tax = payment * 30 / 100;
            final_payment = payment - (Tax + NI);
            return final_payment;
        }

        public double getCatagory_b_payment()
        {
            payment = 37.5 * 48 * 17;
            return payment;
        }
        public double getCatagory_b_NI()
        {
            NI = (37.5 * 48 * 17) * 12 / 100;
            return NI;
        }
        public double getCatagory_b_Tax()
        {
            payment = 37.5 * 48 * 17;
            Tax = payment * 20 / 100;
            return Tax;
        }
        public double getCatagory_b_Final()
        {
            payment = 37.5 * 48 * 17;
            NI = (37.5 * 48 * 17) * 12 / 100;
            Tax = payment * 20 / 100;
            final_payment = payment - (Tax + NI);
            return final_payment;
        }

        public double getCatagory_c_payment()
        {
            payment = 37.5 * 48 * 10;
            return payment;
        }
        public double getCatagory_1_NI()
        {
            NI = (37.5 * 48 * 10) * 12 / 100;
            return NI;
        }
        public double getCatagory_1_Tax()
        {
            payment = 37.5 * 48 * 10;
            Tax = payment * 10 / 100;
            return Tax;
        }
        public double getCatagory_1_Final()
        {
            payment = 37.5 * 48 * 10;
            NI = (37.5 * 48 * 10) * 12 / 100;
            Tax = payment * 10 / 100;
            final_payment = payment - (Tax + NI);
            return final_payment;
        }

        public double getCatagory_d_payment()
        {
            payment = 37.5 * 48 * 5.5;
            return payment;
        }
        public double getCatagory_d_NI()
        {
            NI = (37.5 * 48 * 5.5) * 12 / 100;
            return NI;
        }
        public double getCatagory_d_Tax()
        {
            payment = 37.5 * 48 * 5.5;
            Tax = payment * 0 / 100;
            return Tax;
        }
        public double getCatagory_d_Final()
        {
            payment = 37.5 * 48 * 5.5;
            NI = (37.5 * 48 * 5.5) * 12 / 100;
            Tax = payment * 0 / 100;
            final_payment = payment - (Tax + NI);
            return final_payment;
        }


        //member  variables
        private double newCatagory_a;
        private double newCatagory_b;
        private double newCatagory_c;
        private double newCatagory_d;
        private double newPayment;
        private double newNI;
        private double newTax;
        private double newFinal_payment;
        private double payment;
        private double NI;
        private double Tax;
        private double final_payment;
        private string catagory_a_2;


    }
    }

