import { Component, OnInit } from '@angular/core';
import { ShipperDto } from '../../models/ShipperDto';
import { Router } from '@angular/router';

import { DbConnectionService } from '../../services/db-connection.service';

@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.css']
})
export class ShippersListComponent implements OnInit {

  public listShippers: Array<ShipperDto> = [];

  selectedShipper?: ShipperDto;
  shippers = ShipperDto; // AGREGADO HACE POCO


  constructor(private apiService: DbConnectionService, public router: Router) { }

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




  onDelete(){
    //  this.listShippers.
   }

}
