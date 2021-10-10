import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { ShipperDto } from '../models/ShipperDto';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class DbConnectionService {

  endpoint: string = 'shipper'

  constructor(private http: HttpClient) { }

  public getShippers(): Observable<Array<ShipperDto>> {

    let url = environment.apiShippers + this.endpoint;
    return this.http.get<Array<ShipperDto>>(url);
  }

  public insertShipper(shipperRequest: ShipperDto): Observable<any> {

    let url = environment.apiShippers + this.endpoint;
    return this.http.post(url, shipperRequest);
  }  

  public deleteShipper(id: any): Observable<any> {    
    return this.http.delete(environment.apiShippers + this.endpoint + "/" + id);
  }
  
}
