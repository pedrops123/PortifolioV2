import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { loginModel } from 'src/app/models/loginModel';

@Injectable()
export class LoginServiceService {
  
  httpOptions = {
    headers: new HttpHeaders(
        { 'Content-Type': 'application/json'}
      )
  } 

  constructor(private client:HttpClient) { }

  ValidaUser(dadosInfo:loginModel):Observable<any>{
    var json = JSON.parse(JSON.stringify(dadosInfo));
    return this.client.post<Observable<any>>(`${environment.app_server}/Login/Logar`,json);
  } 


}
