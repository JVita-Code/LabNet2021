import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersListComponent } from './components/shippers-list/shippers-list.component';
import { ShippersFormComponent } from './components/shippers-form/shippers-form.component';




@NgModule({
  declarations: [
    ShippersListComponent,
    ShippersFormComponent
  ],
  imports: [
    CommonModule
  ]
})
export class CrudShippersModule { }
