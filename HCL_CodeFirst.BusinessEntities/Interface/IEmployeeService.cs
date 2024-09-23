using HCL_CodeFirst.BusinessEntities.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_CodeFirst.BusinessEntities.Interface
{
    public interface IEmployeeServices
    {
        List<EmployeeDTO> GetAllEmployeeDetails();
        List<EmployeeDTO> GetEmployeeDetailsByID(int id);
        bool AddEmployeeDetails(EmployeeDTO employeeDTO);
        bool UpdateEmployeeDetails(EmployeeDTO employeeDTO);
        bool DeleteEmployeeDetails(int id);
    }
}
