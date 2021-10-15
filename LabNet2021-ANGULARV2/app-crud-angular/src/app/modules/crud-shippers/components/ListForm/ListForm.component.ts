import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators  } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { DbConnectionService } from '../../services/db-connection.service';


import { ShipperDto } from '../../models/ShipperDto';
import { BsModalService } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal/bs-modal-ref.service';


import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-ListForm',
  templateUrl: './ListForm.component.html',
  styleUrls: ['./ListForm.component.css']
})

export class ListFormComponent implements OnInit {

  err = null;
  isLoading = false;
  modalRef: BsModalRef;
  formValue: FormGroup;
  shipperObj : ShipperDto = new ShipperDto;

  mostrarAdd!: boolean;
  mostrarUpdate!: boolean;

  public listShippers: Array<ShipperDto> = [];

  constructor(private httpclient:     HttpClient, 
              private apiService:     DbConnectionService, 
              private modalService:   BsModalService, 
              private fb:             FormBuilder, 
              private toastrService:  ToastrService) { }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template,{ backdrop: 'static', keyboard: false });
  }

  campoNotValid(campo: string){
    
    return this.formValue.controls[campo].errors 
        && this.formValue.controls[campo].touched;
  }

  ngOnInit() {

    this.obtenerShippers();

    this.formValue = this.fb.group({
      companyName : ['', [Validators.required, Validators.minLength(3), Validators.maxLength(40)]],
      phone : ['', [Validators.required, Validators.minLength(10), Validators.maxLength(20)]]
    })
  }

  obtenerShippers(){
    
    this.isLoading = true;
    this.apiService.getShippers()
    .subscribe(res => {
      
      this.isLoading = false;
      this.listShippers = res;     

    },
    err => {
      
      this.isLoading = false;
      this.err = err.message
      this.toastrService.error('Error al intentar obtener listado de Shippers - ' + err.message) 
    });
  }

  insertShipperDetails(){

    if(this.formValue.invalid){
      this.formValue.markAllAsTouched();
      return;
    }

    this.shipperObj.companyName = this.formValue.value.companyName;
    this.shipperObj.phone = this.formValue.value.phone;

    this.apiService.insertShipper(this.shipperObj)
    .subscribe(res =>{
      
      this.formValue.reset();
      this.toastrService.success('Se cargó correctamente el Shipper')
      this.obtenerShippers();

    },
    err => {
      this.err = err.message
      this.toastrService.error('Error al cargar el Shipper - ' + err.message)
    });
  }

  deleteShipper(shipper: any){

    if(window.confirm('¿Está seguro que desea eliminar el registro?')){
      this.apiService.deleteShipper(shipper.shipperID)
      .subscribe(res =>{
        this.toastrService.success('Se eliminó correctamente el Shipper')
        this.obtenerShippers();
      },
      err => {
        this.err = err.message
        this.toastrService.error('Error al intentar eliminar el Shipper - ' + err.message)
      });
    }    
  }

  onEdit(shipper: any){

    this.mostrarAdd = false;
    this.mostrarUpdate = true;

    this.shipperObj.shipperID = shipper.shipperID;
    this.formValue.controls['companyName'].setValue(shipper.companyName)
    this.formValue.controls['phone'].setValue(shipper.phone)
  }

  updateShipperDetails(){

    if(this.formValue.invalid){
      this.formValue.markAllAsTouched();
      return;
    }

    this.shipperObj.companyName = this.formValue.value.companyName;
    this.shipperObj.phone = this.formValue.value.phone;

    this.apiService.updateShipper(this.shipperObj, this.shipperObj.shipperID)
    .subscribe( res =>{
      // this.toastrService.success('Se actualizaron correctamente los datos')
      this.toastrService.success('Se actualizaron correctamente los datos')       
      this.obtenerShippers();     

    },
    err =>{
      this.err = err.message
      this.toastrService.error('Error al intentar actualizar los datos - ' + err.message)
    });
  }

  clickBtnAdd(){
    this.formValue.reset();
    this.mostrarAdd = true;
    this.mostrarUpdate = false;
  }

}

