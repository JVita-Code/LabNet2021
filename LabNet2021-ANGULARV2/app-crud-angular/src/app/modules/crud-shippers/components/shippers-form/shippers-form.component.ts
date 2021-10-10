import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ShipperDto } from '../../models/ShipperDto';
import { DbConnectionService } from '../../services/db-connection.service';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-shippers-form',
  templateUrl: './shippers-form.component.html',
  styleUrls: ['./shippers-form.component.css']
})
export class ShippersFormComponent implements OnInit {

  form!: FormGroup;

  @Input() shippers?: ShipperDto;
  
  

  constructor(private readonly fb: FormBuilder, private apiService: DbConnectionService, public router: Router, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      
      companyName: [''],
      phone: ['']

    })
  }

  onSubmit(): void {
    
    console.log(this.form.value);
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
     this.toastr.success('Operación exitosa')

   })


}

}
