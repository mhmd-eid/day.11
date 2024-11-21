namespace doctoersWep.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DoctorName { get; set; }
        public DateTime Time { get; set; }

        List<Patient> Patients { get; set; }


    }
}
