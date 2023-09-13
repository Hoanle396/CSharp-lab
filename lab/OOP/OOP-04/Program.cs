using System;
using System.Collections.Generic;

namespace OOP_04
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            // Nhập danh sách nhân viên
            Console.WriteLine("Nhập thông tin nhà khoa học:");
            Scientist scientist = ReadScientistInformation();
            employees.Add(scientist);

            Console.WriteLine("Nhập thông tin nhà quản lý:");
            Manager manager = ReadManagerInformation();
            employees.Add(manager);

            Console.WriteLine("Nhập thông tin nhân viên phòng thí nghiệm:");
            LaboratoryStaff laboratoryStaff = ReadLaboratoryStaffInformation();
            // Chuyển đổi thông tin nhân viên phòng thí nghiệm thành đối tượng Employee
            Employee employee = ConvertToEmployee(laboratoryStaff);
            employees.Add(employee);

            // Tính tổng lương đã chi trả cho từng loại đối tượng
            double totalScientistSalary = CalculateTotalScientistSalary(employees);
            double totalManagerSalary = CalculateTotalManagerSalary(employees);
            double totalLaboratoryStaffSalary = CalculateTotalLaboratoryStaffSalary(employees);

            // In tổng lương đã chi trả cho từng loại đối tượng
            Console.WriteLine("Tổng lương đã chi trả cho nhà khoa học: " + totalScientistSalary);
            Console.WriteLine("Tổng lương đã chi trả cho nhà quản lý: " + totalManagerSalary);
            Console.WriteLine("Tổng lương đã chi trả cho nhân viên phòng thí nghiệm: " + totalLaboratoryStaffSalary);

            Console.ReadLine();
        }

        static Scientist ReadScientistInformation()
        {
            Console.Write("Họ tên: ");
            string scientistName = Console.ReadLine();
            Console.Write("Năm sinh: ");
            int scientistBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bằng cấp: ");
            string scientistDegree = Console.ReadLine();
            Console.Write("Chức vụ: ");
            string scientistPosition = Console.ReadLine();
            Console.Write("Số bài báo đã công bố: ");
            int scientistPublishedPapers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số ngày công trong tháng: ");
            int scientistWorkDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bậc lương: ");
            int scientistSalaryRank = Convert.ToInt32(Console.ReadLine());

            Scientist scientist = new Scientist
            {
                FullName = scientistName,
                BirthYear = scientistBirthYear,
                Degree = scientistDegree,
                Position = scientistPosition,
                PublishedPapers = scientistPublishedPapers,
                WorkDays = scientistWorkDays,
                SalaryRank = scientistSalaryRank
            };

            return scientist;
        }

        static Manager ReadManagerInformation()
        {
            Console.Write("Họ tên: ");
            string managerName = Console.ReadLine();
            Console.ReadLine();
            Console.Write("Năm sinh: ");
            int managerBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bằng cấp: ");
            string managerDegree = Console.ReadLine();
            Console.Write("Chức vụ: ");
            string managerPosition = Console.ReadLine();
            Console.Write("Số ngày công trong tháng: ");
            int managerWorkDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bậc lương: ");
            int managerSalaryRank = Convert.ToInt32(Console.ReadLine());

            Manager manager = new Manager
            {
                FullName = managerName,
                BirthYear = managerBirthYear,
                Degree = managerDegree,
                Position = managerPosition,
                WorkDays = managerWorkDays,
                SalaryRank = managerSalaryRank
            };

            return manager;
        }

        static LaboratoryStaff ReadLaboratoryStaffInformation()
        {
            Console.Write("Họ tên: ");
            string laboratoryStaffName = Console.ReadLine();
            Console.Write("Năm sinh: ");
            int laboratoryStaffBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bằng cấp: ");
            string laboratoryStaffDegree = Console.ReadLine();
            Console.Write("Lương trong tháng: ");
            double laboratoryStaffMonthlySalary = Convert.ToDouble(Console.ReadLine());

            LaboratoryStaff laboratoryStaff = new LaboratoryStaff
            {
                FullName = laboratoryStaffName,
                BirthYear = laboratoryStaffBirthYear,
                Degree = laboratoryStaffDegree,
                MonthlySalary = laboratoryStaffMonthlySalary
            };

            return laboratoryStaff;
        }

        static Employee ConvertToEmployee(LaboratoryStaff laboratoryStaff)
        {
            Employee employee = new Employee
            {
                FullName = laboratoryStaff.FullName,
                BirthYear = laboratoryStaff.BirthYear,
                Degree = laboratoryStaff.Degree,
                Position = "Nhân viên phòng thí nghiệm"
            };

            return employee;
        }

        static double CalculateTotalScientistSalary(List<Employee> employees)
        {
            double totalSalary = 0;

            foreach (Employee employee in employees)
            {
                if (employee is Scientist scientist)
                {
                    totalSalary += scientist.CalculateSalary();
                }
            }

            return totalSalary;
        }

        static double CalculateTotalManagerSalary(List<Employee> employees)
        {
            double totalSalary = 0;

            foreach (Employee employee in employees)
            {
                if (employee is Manager manager)
                {
                    totalSalary += manager.CalculateSalary();
                }
            }

            return totalSalary;
        }

        static double CalculateTotalLaboratoryStaffSalary(List<Employee> employees)
        {
            double totalSalary = 0;

            foreach (Employee employee in employees)
            {
                if (!(employee is Scientist) && !(employee is Manager))
                {
                    // Chuyển đổi đối tượng Employee thành đối tượng LaboratoryStaff
                    LaboratoryStaff laboratoryStaff = ConvertToLaboratoryStaff(employee);
                    totalSalary += laboratoryStaff.MonthlySalary;
                }
            }

            return totalSalary;
        }

        static LaboratoryStaff ConvertToLaboratoryStaff(Employee employee)
        {
            LaboratoryStaff laboratoryStaff = new LaboratoryStaff
            {
                FullName = employee.FullName,
                BirthYear = employee.BirthYear,
                Degree = employee.Degree,
                MonthlySalary = 0 // Giá trị lương không được sử dụng cho nhân viên phòng thí nghiệm
            };

            return laboratoryStaff;
        }
    }
}
