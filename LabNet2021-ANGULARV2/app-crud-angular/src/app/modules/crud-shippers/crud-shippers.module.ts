import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';


import { ToastrModule } from 'ngx-toastr';
import { NgxMaskModule } from 'ngx-mask';


import { ShippersListComponent } from './components/shippers-list/shippers-list.component';
import { ShippersFormComponent } from './components/shippers-form/shippers-form.component';
import { ShipperDetailComponent } from './components/shipper-detail/shipper-detail.component';
import { ListFormComponent } from './components/ListForm/ListForm.component';


@NgModule({
  declarations: [
    ShippersListComponent,
    ShippersFormComponent,
    ShipperDetailComponent,
    ListFormComponent
  ],
  imports: [

    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    NgxMaskModule.forRoot({
      dropSpecialCharacters: false
    })
    
  ]
})
export class CrudShippersModule { }
