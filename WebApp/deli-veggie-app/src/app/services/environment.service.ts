import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment'

@Injectable({
  providedIn: 'root'
})
export class EnvironmentService {

  constructor() { }

  public getAPIUrl() : string {
    return environment.Api_Url;
  }
}
