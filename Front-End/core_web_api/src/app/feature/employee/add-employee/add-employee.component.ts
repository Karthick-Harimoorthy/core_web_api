import { Component } from '@angular/core';
import { AddEmployeeRequest } from '../models/add-employee-request.model';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent {

  model: AddEmployeeRequest;

  constructor()
  {
    this.model = {

      EmpName:'',
      EmpPhNo:'',
      EmpMailID:''
      
    }
  }

  onFormSubmit()
  {

  }
}
