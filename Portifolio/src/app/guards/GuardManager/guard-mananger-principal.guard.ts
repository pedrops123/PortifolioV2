import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router, CanLoad, Route, UrlSegment } from '@angular/router';
import { Observable } from 'rxjs';
import { TokenService } from 'src/app/services/token/token.service';

@Injectable({
  providedIn: 'root'
})
export class GuardManangerPrincipalGuard implements CanActivate {

  constructor(private ServiceToken:TokenService , private router:Router){}
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
    var result  = this.ServiceToken.getToken();
    if(result != null){
       
        this.ServiceToken.isAuthenticated = true;
    }
    else{
      this.router.navigate(['/login']);
      this.ServiceToken.isAuthenticated = false;
    }
    
      return this.ServiceToken.isAuthenticated;
  }

}
