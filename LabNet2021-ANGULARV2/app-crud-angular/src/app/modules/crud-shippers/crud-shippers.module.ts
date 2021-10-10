import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { HttpClientModule } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';

import { ShippersListComponent } from './components/shippers-list/shippers-list.component';
import { ShippersFormComponent } from './components/shippers-form/shippers-form.component';
import { ShipperDetailComponent } from './components/shipper-detail/shipper-detail.component';







@NgModule({
  declarations: [
    ShippersListComponent,
    ShippersFormComponent,
    ShipperDetailComponent
  ],
  imports: [

    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ToastrModule.forRoot()
    
  ]
})
export class CrudShippersModule { }
