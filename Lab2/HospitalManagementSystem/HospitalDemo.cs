using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            hospital.AddDoctor(new Doctor(1, "Петренко Іван", "Хірург"));
            hospital.AddDoctor(new Doctor(2, "Коваленко Марія", "Терапевт"));
            hospital.AddDoctor(new Doctor(3, "Іваненко Олег", "Кардіолог"));

            hospital.RegisterPatient(new Patient(1, "Тарас", 25));
            hospital.RegisterPatient(new Patient(2, "Олег", 31));
            hospital.RegisterPatient(new Patient(3, "Марина", 19));
            hospital.RegisterPatient(new Patient(4, "Світлана", 45));

            hospital.CreateRoom(new HospitalRoom(101, 2));
            hospital.CreateRoom(new HospitalRoom(102, 1));

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(4, 102); // Переповнена

            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[0], hospital.Doctors[0], DateTime.Now, "Огляд після операції"));

            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[0], hospital.Doctors[1], DateTime.Now, "Загальний стан стабільний"));

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);

            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
