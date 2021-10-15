import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';


import { ToastrModule } from 'ngx-toastr';
import { NgxMaskModule } from 'ngx-mask';


import { ListFormComponent } from './components/ListForm/ListForm.component';


@NgModule({
  declarations: [

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
