import { Injectable } from '@angular/core';

@Injectable()
export class CookieService {
 
  // Seta cookie no navegador cliente por hora
  setCookie(name:string , value:any , hours:number) 
  {
    var expires = "";
    if (hours) {
      var now = new Date();
      var time = now.getTime();
      time += 3600 * hours;
      now.setTime(time);
        expires = "; expires='" + now.toUTCString();
    }
    document.cookie = name + "=" + (value || "")  + expires + "; path=/";
}

// coleta cookie no navegador cliente
  getCookie(name) {
      var nameEQ = name + "=";
      var ca = document.cookie.split(';');
      for(var i=0;i < ca.length;i++) {
          var c = ca[i];
          while (c.charAt(0)==' ') c = c.substring(1,c.length);
          if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
      }
      return null;
  }


  deleteCookie(name:string){
    document.cookie = name +'=; Path=/; Expires=Thu, 01 Jan 1970 00:00:01 GMT;';
  }



}

