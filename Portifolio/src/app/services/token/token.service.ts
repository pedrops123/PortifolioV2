import { Injectable } from '@angular/core';
import { CookieService } from '../Cookie/cookie.service';

@Injectable()
export class TokenService {

  isAuthenticated:boolean;
  constructor(private cookieService:CookieService) { }


  setToken({ token , roles, hours }){
    let obj_token = {
      token:token,
      acesso:roles,
      expires:hours
    }
    this.cookieService.setCookie('acesso_login',JSON.stringify(obj_token),hours);
  }

  getToken(){
    return this.cookieService.getCookie('acesso_login');
  }

  deslogarUser(){
      this.cookieService.deleteCookie('acesso_login');
  }

  getBoolean(){
    return this.isAuthenticated;
  }
}
