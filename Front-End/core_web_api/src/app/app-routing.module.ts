import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './feature/employee/employee-list/employee-list.component';
import { AddEmployeeComponent } from './feature/employee/add-employee/add-employee.component';

const routes: Routes = [
  {
    path:'admin/employee',
    component:EmployeeListComponent
  },
  {
    path:'admin/employee/add',
    component:AddEmployeeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
