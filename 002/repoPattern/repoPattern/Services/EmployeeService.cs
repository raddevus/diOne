
public class EmployeeSerivce: IEmployeeService{
   IEmployeeRepo EmployeeRepo{get;set;}
   public void EmployeeService (IEmployeeRepo employeeRepo){
      EmployeeRepo = employeeRepo; 
   }
}
