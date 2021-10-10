import { Component, OnInit, Input } from '@angular/core';
import { ShipperDto } from '../../models/ShipperDto'; 


@Component({
  selector: 'app-shipper-detail',
  templateUrl: './shipper-detail.component.html',
  styleUrls: ['./shipper-detail.component.css']
})


export class ShipperDetailComponent implements OnInit {

  @Input() shippers?: ShipperDto;

  constructor() { }

  ngOnInit() {
  }

}
