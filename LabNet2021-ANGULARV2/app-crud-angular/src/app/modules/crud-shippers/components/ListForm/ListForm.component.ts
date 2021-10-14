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

  modalRef: BsModalRef;
  formValue: FormGroup;
  shipperObj : ShipperDto = new ShipperDto;

  mostrarAdd!: boolean;
  mostrarUpdate!: boolean;

  constructor(private httpclient: HttpClient, private apiService: DbConnectionService, private modalService: BsModalService, private fb: FormBuilder, private toastrService: ToastrService) { }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template,{ backdrop: 'static', keyboard: false });
  }

  campoNotValid(campo: string){
    
    return this.formValue.controls[campo].errors 
        && this.formValue.controls[campo].touched;
  }

  public listShippers: Array<ShipperDto> = [];

  ngOnInit() {

    this.obtenerShippers();

    this.formValue = this.fb.group({
      companyName : ['', [Validators.required, Validators.minLength(3), Validators.maxLength(40)]],
      phone : ['', [Validators.required, Validators.minLength(10), Validators.maxLength(20)]]
    })
  }

  obtenerShippers(){
    this.apiService.getShippers().subscribe(res => {
      
      this.listShippers = res;

    },
    err => {
      this.toastrService.error('Error al obtener listado de Shippers' + err.error.errors)
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
      this.toastrService.error('Error al cargar el Shipper' + err.error.errors)
    });
  }

  deleteShipper(shipper: any){
    this.apiService.deleteShipper(shipper.shipperID)
    .subscribe(res =>{
      this.toastrService.success('Se eliminó correctamente el Shipper')
      this.obtenerShippers();
    },
    err => {
      this.toastrService.error('Error al intentar eliminar el Shipper' + err.error.errors)
    });
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
      this.toastrService.success('Se actualizaron correctamente los datos')     
      this.obtenerShippers();     

    },
    err =>{
      this.toastrService.error('Error al intentar actualizar los datos' + err.error.errors)
    });
  }

  clickBtnAdd(){
    this.formValue.reset();
    this.mostrarAdd = true;
    this.mostrarUpdate = false;
  }

}

