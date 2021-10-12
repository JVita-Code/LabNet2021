import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { ShipperDto } from '../models/ShipperDto';
import { catchError, retry } from 'rxjs/operators';

import { map } from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class DbConnectionService {

  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  
  endpoint: string = 'shipper'
  url = environment.apiShippers + this.endpoint;

  constructor(private http: HttpClient) { }

  public getShippers(): Observable<Array<ShipperDto>> {

    return this.http.get<Array<ShipperDto>>(this.url);    
  }

  public getShipper(id: number): Observable<ShipperDto>{

    return this.http.get<ShipperDto>(this.url + `/${id}`)
  }

  public insertShipper(shipperRequest: ShipperDto): Observable<any> {

    
    return this.http.post(this.url, shipperRequest);
  }  

  public deleteShipper(id: number): Observable<any> {    
   
    return this.http.delete(this.url + "/" + id);
  }

  public updateShipper(shipper: ShipperDto, id: number): Observable<any> {
    
  return this.http.put(this.url + "/" + id, shipper)
  .pipe(map((res:any)=> {
    return res;
  }))

  // return this.http.put(this.url + "/" + shipper.shipperID)

  // let url = environment.apiShippers + this.endpoint;
  // return this.http.put(environment.apiShippers + this.endpoint + "/" + id, this.httpOptions)
  // // }

  

}
}
