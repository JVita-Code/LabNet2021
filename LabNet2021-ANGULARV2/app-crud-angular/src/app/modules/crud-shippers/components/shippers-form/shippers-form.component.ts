import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ShipperDto } from '../../models/ShipperDto';
import { DbConnectionService } from '../../services/db-connection.service';

@Component({
  selector: 'app-shippers-form',
  templateUrl: './shippers-form.component.html',
  styleUrls: ['./shippers-form.component.css']
})
export class ShippersFormComponent implements OnInit {

  form!: FormGroup;

  constructor(private readonly fb: FormBuilder, private apiService: DbConnectionService  ) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      
      companyName: [''],
      phone: ['']

    })
  }

volverForm(){

  this.form.reset();
}

guardarForm(){

  var shipper = new ShipperDto();

  // shipper.ShipperID = this.form.get('ShipperID')?.value;
  shipper.companyName = this.form.get('companyName')?.value;
  shipper.phone = this.form.get('phone')?.value; 

  
  this.apiService.insertShipper(shipper).subscribe(res => {
    this.form.reset();
    console.log('se insertó el nuevo shipper')

  })
}

}
