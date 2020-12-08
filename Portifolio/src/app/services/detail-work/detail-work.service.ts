import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { DetailProject } from 'src/app/models/DetailProject';
import { environment } from 'src/environments/environment';

@Injectable()
export class DetailWorkService {

  constructor(private Client:HttpClient) { }

  getDataDetailWork(idTrabalho:number):Observable<DetailProject>{
    var string =  `${environment.app_server}​/work​/GetDetailProject​/${idTrabalho}`;
    console.log(string);
    return this.Client.get(`${environment.app_server}/work/GetDetailProject/${idTrabalho}`)
    .pipe(
       map(response => Object.assign(new DetailProject() , response))
       );
  }
}
