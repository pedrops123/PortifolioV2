import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable()
export class GeneralParametersService {

  constructor() { }

  getNameDev():string{
    return environment.name_dev;
  }

  getDataInicioCarreira():number {
      return environment.dataInicioCarreira;
  }

}
