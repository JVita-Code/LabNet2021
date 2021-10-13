import { Component, OnInit } from '@angular/core';
import { ShipperDto } from '../../models/ShipperDto';
import { Router } from '@angular/router';

import { DbConnectionService } from '../../services/db-connection.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.css']
})
export class ShippersListComponent implements OnInit {

  public listShippers: Array<ShipperDto> = [];

  selectedShipper: ShipperDto;

  message?: string;

  receiveMessage($event: any){
    this.message = $event
  }


  public shipperEncontrado?: ShipperDto;
  // shippers = ShipperDto; // AGREGADO HACE POCO


  constructor(private apiService: DbConnectionService, public router: Router, private toastr: ToastrService) { }

  ngOnInit(): void {

    // this.initForm();
    this.obtenerShippers();
  }

  obtenerShippers(){
    this.apiService.getShippers().subscribe(res => {
      this.listShippers = res;
      console.log(this.listShippers);

    });
  }
  

  onSelect(shipper: ShipperDto): void {

    this.selectedShipper = shipper;
  }

  deleteShipper(shipper: any): void {    
    
    // this.listShippers = this.listShippers.filter(s => s !== shipper);
    this.apiService.deleteShipper(shipper.shipperID)
    .subscribe(res => {
      alert("shipper eliminado")
      this.obtenerShippers();
    })

    // this.toastr.success('Se ha eliminado el Shipper')
  }

  findShipper(id: number){
    this.apiService.getShipper(id).subscribe(ship => {
    this.shipperEncontrado = ship;
    console.log(this.shipperEncontrado);
    },
    error => console.log(error))
  }

}
