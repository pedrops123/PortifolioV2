import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuServiceService } from './menu/menu-service.service';
import { WorkServiceService } from './works/work-service.service';
import { DetailWorkService } from './detail-work/detail-work.service';
import { CookieService } from './Cookie/cookie.service';
import { LocalStorageService } from './LocalStorage/local-storage.service';
import { GeneralParametersService } from './GeneralParameters/general-parameters.service';
import { LoginServiceService } from './Login/login-service.service';
import { TokenService } from './token/token.service';
import { ManagerPrincipalService } from './ManagerPrincipal/manager-principal.service';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers: [
    MenuServiceService,
    WorkServiceService,
    DetailWorkService,
    CookieService,
    LocalStorageService,
    GeneralParametersService,
    LoginServiceService,
    TokenService,
    ManagerPrincipalService
  ]
})
export class ServicesModule { }
