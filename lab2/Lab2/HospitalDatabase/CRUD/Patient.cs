namespace P01_HospitalDatabase.CRUD.Patients
{
    internal class Patient : HospitalDatabase.Models.Patients
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool HasMedicalInsurance { get; set; }
    }
}