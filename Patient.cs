namespace Homework7
{
    public class Patient
    {
        public Plan Plan { get; set; }

        public Patient(int сode)
        {
            Plan = new Plan(сode);
        }
        public void SelectDoctor()
        {
            int code = Plan.Code;
            switch (code)
            {
                case 1:
                    var surgeon = new Surgeon();
                    surgeon.Treat();
                    break;
                case 2:
                    var dentist = new Dentist();
                    dentist.Treat();
                    break;
                default:
                    var therapist = new Therapist();
                    therapist.Treat();
                    break;
            }
        }
    }
}
