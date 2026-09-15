
public EmployeeSerivce: IEmployeeService{
   IEmployeeRepo EmployeeRepo;
   public EmployeeService (IEmployeeRepo employeeRepo){
      EmployeeRepo = employeeRepo; 
   }
}
