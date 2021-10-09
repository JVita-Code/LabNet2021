import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ShippersListComponent } from './components/shippers-list/shippers-list.component';
import { ShippersFormComponent } from './components/shippers-form/shippers-form.component';
import { HttpClientModule } from '@angular/common/http';







@NgModule({
  declarations: [
    ShippersListComponent,
    ShippersFormComponent
  ],
  imports: [

    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule,
    HttpClientModule
    
  ]
})
export class CrudShippersModule { }
