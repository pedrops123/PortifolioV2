import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { loginModel } from 'src/app/models/loginModel';
import { ValidationLogin } from 'src/app/models/ValidationLogin';
import { RetornoGlobal } from 'src/app/models/RetornoGlobal';
import { map } from 'rxjs/operators';

@Injectable()
export class LoginServiceService {
  
  httpOptions = {
    headers: new HttpHeaders(
        { 'Content-Type': 'application/json'}
      )
  } 

  constructor(private client:HttpClient) { }

  ValidaUser(dadosInfo:loginModel):Observable<RetornoGlobal<ValidationLogin>>{
      var json = JSON.parse(JSON.stringify(dadosInfo));
      return this.client.post<RetornoGlobal<ValidationLogin>>(`${environment.app_server}/Login/Logar`,json)
      .pipe(
        map(response => Object.assign(new RetornoGlobal<ValidationLogin>(),response))
      );
  } 


}
