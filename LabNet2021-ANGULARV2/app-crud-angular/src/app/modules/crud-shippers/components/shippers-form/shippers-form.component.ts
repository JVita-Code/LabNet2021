import { Component, OnInit, Input, Output, EventEmitter, OnDestroy } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ShipperDto } from '../../models/ShipperDto';
import { DbConnectionService } from '../../services/db-connection.service';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';


import { ToastrService } from 'ngx-toastr';
import { pairwise, startWith } from 'rxjs/operators';
import { Subscription } from 'rxjs';


@Component({
  selector: 'app-shippers-form',
  templateUrl: './shippers-form.component.html',
  styleUrls: ['./shippers-form.component.css']
})
export class ShippersFormComponent implements OnInit, OnDestroy {

  subscription: Subscription;
  editMode = false;
  editedItemIndex: number;
  editedItem: ShipperDto;


  form!: FormGroup;
  form2!: FormGroup;

  shipper: ShipperDto = new ShipperDto;

  shipperList: ShipperDto[];

  shipperObj : ShipperDto = new ShipperDto();

  @Input() shippers?: ShipperDto;
  
  @Input() selectedShipper?: ShipperDto;

  @Input() seleccionShipper: ShipperDto;

  @Input() newShipper?: ShipperDto;

  // @Input() callbackFunction?: (args: any) => void;

  message: string = "hello!"

  @Output() datosFormEvent = new EventEmitter<ShipperDto>();

  enviaDatosForm(){


    // this.datosFormEvent.emit(this.form2.get('companyName')?.value)   
    // this.datosFormEvent.emit(this.form2.get('phone')?.value) 

  
  }

  constructor(private readonly fb:    FormBuilder, 
              private apiService:     DbConnectionService, 
              public router:          Router, 
              private toastr:         ToastrService, 
              private activatedRoute: ActivatedRoute ) { }

  ngOnInit(): void {


    // this.subscription = this.apiService.startedEditing
    //     .subscribe(
    //       (index: number) =>{
    //         this.editedItemIndex = index;
    //         this.editMode = true;
    //         this.editedItem = this.apiService.selectedshipper(index);
    //       }
    //     );



    // this.activatedRoute.params
    // .subscribe( ({id}) => console.log(id))

    this.form = this.fb.group({      
      
      companyName : [''],
      phone : ['']

    })

    this.form2 = this.fb.group({

      companyName: [''],
      phone: ['']
      
    });

    // this.form2.get('companyName')?.valueChanges.subscribe(dataName => {
    //   console.log(dataName);
    // })
    // this.form2.get('phone')?.valueChanges.subscribe(dataPhone => {
    //   console.log(dataPhone);
    // })

    // this.form2.valueChanges.subscribe(data => {
    //   this.shipperObj
    // })


  }

  // onSubmit(): void {
    
  //   this.shipperObj = this.form2.value;
  //   if(this.shipperList.some(s => s.shipperID == this.shipper.shipperID)){
  //     this.apiService.updateShipper(this.shipper)
  //   }
  // }

  volverForm(){

  this.form.reset();
  }

//   guardarForm(){

  

//   shipper.shipperID = this.form.get('shipperID')?.value;
//   shipper.companyName = this.form.get('companyName')?.value;
//   shipper.phone = this.form.get('phone')?.value; 

//   if (shipper){
//     this.apiService.insertShipper(shipper).subscribe();
//     this.toastr.success('Operación exitosa')
    
//   }
   
// }

  onEdit(shipper: any){

  this.shipperObj.shipperID // seguir aca

  // this.form.controls['companyName'].setValue(shipper.companyName)
  // this.form.controls['phone'].setValue(shipper.phone)

  this.form2.controls['companyName'].setValue(this.seleccionShipper.companyName)
  this.form2.controls['phone'].setValue(this.seleccionShipper.phone)

  }


  // updateShipperDetails(){
  // this.shipperObj.companyName = this.form2.value.companyName;
  // this.shipperObj.phone = this.form2.value.phone;

  // this.apiService.updateShipper(this.shipperObj, this.shipperObj.shipperID)
  // .subscribe(res =>{
  //   alert("Actualizado exitosamente")
  // })
  // }

  // guardarForm2(){

  // var shipper = new ShipperDto();

  // shipper.companyName = this.form2.get('companyName')?.value;
  // shipper.phone = this.form2.get('phone')?.value; 

  
  // this.apiService.updateShipper(this.shippers, ShipperDto).subscribe();

  // this.toastr.success('Operación exitosa') // MAL
  // }
  
  insertForm(){

  // var shipper = new ShipperDto();

  this.shipperObj.companyName = this.form.value.companyName;
  this.shipperObj.phone = this.form.value.phone;

  // shipper.companyName = this.form.get('companyName')?.value;
  // shipper.phone = this.form.get('phone')?.value;

 this.apiService.insertShipper(this.shipperObj).subscribe(res => {
      console.log(res);     

      alert("shipper añadido");
      this.form.reset()
      // this.toastr.success('Operación exitosa')

 },
 error => {
   alert("Error")
 })
  }

  ngOnDestroy(){
    this.subscription.unsubscribe();
  }




}
