import { Injectable } from '@angular/core';

@Injectable()
export class LocalStorageService {
  private _storage :Storage;

  constructor() {
    this._storage = window.localStorage;
   }

  setItem(name:string, value:string){
    this._storage.setItem(name,value);
  }

  setItemComplex(name:string, value:any){
    this._storage.setItem(name,JSON.stringify(value));
  }

  getItem(name:string){
    return this._storage.getItem(name);
  }

  removeItem(name:string){
    this._storage.removeItem(name);
  }

  ClearStorage(){
    this._storage.clear();
  }
}
