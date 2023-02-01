using System;

namespace abstractFactory
{
    class Program
    {
        public abstract class patient
        {
            public abstract void dignose();
        }
        public class patient_emergency : patient
        {
            public override void dignose()
            {

            }
        }
        public class relationship_patient : patient
        {
            public override void dignose()
            {

            }
        }
        public class designPattern_patient : patient
        {
            public override void dignose()
            {
                
            }
        }
        public class hospital
        {
            public patient getPatient(string patientType)
            {
                if (patientType == "emergency")
                {
                    return new patient_emergency();
                }
                else if(patientType=="relationship")
                {
                    return new relationship_patient();
                }
                else if (patientType=="designPattern")
                {
                    return new designPattern_patient();
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
