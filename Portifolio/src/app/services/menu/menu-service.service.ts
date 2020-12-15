import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ButtonsMenu } from '../../models/ButtonsMenu';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable()
export class MenuServiceService {

  constructor(private Client:HttpClient) { }

    getMenuInicial():Observable<ButtonsMenu[]>{
       return this.Client.get<ButtonsMenu[]>(`${ environment.app_server }/Menu`);
    }



}
 