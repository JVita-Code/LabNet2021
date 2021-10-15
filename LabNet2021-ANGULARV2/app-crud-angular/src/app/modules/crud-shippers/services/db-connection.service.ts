import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { environment } from 'src/environments/environment';
import { Observable, Subject } from 'rxjs';
import { ShipperDto } from '../models/ShipperDto';


import { map } from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class DbConnectionService {

  // httpOptions = {
  // headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  // };

  startedEditing = new Subject<number>();

  endpoint: string = 'shipper'
  url = environment.apiShippers + this.endpoint;

  constructor(private http: HttpClient) { }

  public getShippers(): Observable<Array<ShipperDto>> {

    return this.http.get<Array<ShipperDto>>(this.url);    
  }

  public getShipper(id: number): Observable<ShipperDto>{

    return this.http.get<ShipperDto>(this.url + `/${id}`);
  }

  public insertShipper(shipper: ShipperDto){
  
    return this.http.post(this.url, shipper)
    .pipe(map((res: any)=>{
      return res;
    }));
  } 

  public deleteShipper(id: number): Observable<any> {    
   
    return this.http.delete(this.url + "/" + id);
  }

  public updateShipper(shipper: ShipperDto, id: number): Observable<ShipperDto> {
    
    return this.http.put<any>(this.url + "/" + id, shipper)
    .pipe(map((res:any)=> {
      return res;
    }));
  }

}
