import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PaginationCardsParameter } from 'src/app/models/PaginationCardsParameter';
import { environment } from 'src/environments/environment';

@Injectable()
export class WorkServiceService {

  constructor(private Client:HttpClient) { }

  getDataCards(parameters:PaginationCardsParameter):Observable<any>{
     var json = JSON.parse(JSON.stringify(parameters));
      return this.Client.post<Observable<any>>(`${environment.app_server}/work/GetPagination`,json)
  }

}
