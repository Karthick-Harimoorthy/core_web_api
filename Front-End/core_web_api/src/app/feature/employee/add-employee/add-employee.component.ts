import { Component } from '@angular/core';
import { AddEmployeeRequest } from '../models/add-employee-request.model';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent {

  model: AddEmployeeRequest;

  constructor(private employeeservice: EmployeeService)
  {
    this.model = {

      emp_name:'',
      emp_ph_no:'',
      emp_mail_id:''
      
    }
  }

  onFormSubmit()
  {
    this.employeeservice.addemployee(this.model).subscribe({
      next: (response) => {
         console.log('Employee added successfully');
      },
      error:(error) => {
        console.log('error has occured');
      }
    })
  }
}
