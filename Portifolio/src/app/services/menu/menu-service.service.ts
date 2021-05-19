import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ButtonsMenu } from '../../models/ButtonsMenu';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { RetornoGlobal } from 'src/app/models/RetornoGlobal';

@Injectable()
export class MenuServiceService {

  constructor(private Client:HttpClient) { }

    getMenuInicial():Observable<RetornoGlobal<ButtonsMenu[]>>{
       return this.Client.get<RetornoGlobal<ButtonsMenu[]>>(`${ environment.app_server }/Menu`);
    }



}
 