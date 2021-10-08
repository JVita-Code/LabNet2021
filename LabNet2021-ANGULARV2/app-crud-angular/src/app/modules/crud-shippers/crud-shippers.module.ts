import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersListComponent } from './components/shippers-list/shippers-list.component';
import { ShippersFormComponent } from './components/shippers-form/shippers-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';







@NgModule({
  declarations: [
    ShippersListComponent,
    ShippersFormComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    
    
  ]
})
export class CrudShippersModule { }
