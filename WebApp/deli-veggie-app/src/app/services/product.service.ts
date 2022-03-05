import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { product } from '../models/product';
import { EnvironmentService } from './environment.service';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private rootUrl: string;
  constructor(
    public httpClient: HttpClient,
    public environmentService: EnvironmentService
  ) {
      this.rootUrl = this.environmentService.getAPIUrl();
   }

  getAllProducts(): Observable<product[]> {  
    return this.httpClient.get<product[]>(this.rootUrl + '/Product');  
  }  
  getProductById(id:string): Observable<product> {  
    return this.httpClient.get<product>(this.rootUrl + '/Product/' + id);  
  }
}
