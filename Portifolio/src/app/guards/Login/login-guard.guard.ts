import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { TokenService } from 'src/app/services/token/token.service';

@Injectable({
  providedIn: 'root'
})
export class LoginGuardGuard implements CanActivate {

  constructor(private ServiceToken:TokenService , private router:Router){}
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    let acessoPermitido:boolean;
      console.log(this.ServiceToken.getBoolean());
    if(this.ServiceToken.getBoolean()){
      this.router.navigate(['/manager']);
      acessoPermitido = false;
    }else
    {
      acessoPermitido = true;
    }

    return acessoPermitido;
  }
  
}
