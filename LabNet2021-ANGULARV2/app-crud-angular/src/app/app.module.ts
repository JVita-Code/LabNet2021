import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient, HttpClientModule } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { CrudShippersModule } from './modules/crud-shippers/crud-shippers.module';
import { ShipperDetailComponent } from './modules/crud-shippers/components/shipper-detail/shipper-detail.component';



@NgModule({
  declarations: [
    AppComponent,
    
    
    // ErrorPageComponent
  ],
  imports: [

    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CrudShippersModule,
    HttpClientModule
    
    
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
