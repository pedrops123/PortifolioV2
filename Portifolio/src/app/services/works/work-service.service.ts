import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { CatalogProjeto } from 'src/app/models/CatalogProjeto';
import { PaginationCardsParameter } from 'src/app/models/PaginationCardsParameter';
import { RetornoGlobal } from 'src/app/models/RetornoGlobal';
import { environment } from 'src/environments/environment';
import  *  as geralOmmiter from '../../models/OmmiterCatalogProjeto';
import { OmmiterCatalogProjeto } from '../../models/OmmiterCatalogProjeto';
@Injectable()
export class WorkServiceService {

  constructor(private Client:HttpClient) {}

 

  getDataCards(parameters:PaginationCardsParameter):Observable<any>{
     var json = JSON.parse(JSON.stringify(parameters));
      return this.Client.post<Observable<any>>(`${environment.app_server}/work/GetPagination`,json)
  }

  getById():Observable<RetornoGlobal<CatalogProjeto>>{
    return this.Client.get("/work/GetById").pipe(
        map(response => Object.assign(new RetornoGlobal<CatalogProjeto>(),response))
      );
  }


  getList():Observable<RetornoGlobal<CatalogProjeto>>{
    return this.Client.get("/work").pipe(
        map(response => Object.assign(new RetornoGlobal<CatalogProjeto>(),response))
      );
  }

  post(postData:any):Observable<RetornoGlobal<CatalogProjeto>>{
    return this.Client.post("/work",postData).pipe(
        map(response => Object.assign(new RetornoGlobal<CatalogProjeto>(),response))
      );
       
  }


}
