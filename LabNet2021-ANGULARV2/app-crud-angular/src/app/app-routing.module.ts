import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListFormComponent } from './modules/crud-shippers/components/ListForm/ListForm.component';
import { ShippersFormComponent } from './modules/crud-shippers/components/shippers-form/shippers-form.component';
import { ShippersListComponent } from './modules/crud-shippers/components/shippers-list/shippers-list.component';

const routes: Routes = [
  
  {
    path: '',
    component: ListFormComponent
  },  
  
  {
    path: 'form',
    component: ShippersFormComponent
  }, 

  {
    path: 'oldList',
    component: ShippersListComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
