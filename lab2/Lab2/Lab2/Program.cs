using HospitalDatabase;

Console.WriteLine("Choose what to do:");
Console.WriteLine("\t1 - create patient\n\t2 - get list of patients\n\t3 - update patient\n\t4 - delete patient");

int action = int.Parse(Console.ReadLine());

switch (action)
{
    case 1:
        PatientCRUD.Create();
        break;
    case 2:
        PatientCRUD.Read();
        break;
    case 3:
        PatientCRUD.Update();
        break;
    case 4:
        PatientCRUD.Delete();
        break;
    default: Console.WriteLine("Invalid action!"); break;
}