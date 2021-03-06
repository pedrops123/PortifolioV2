import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuServiceService } from './menu/menu-service.service';
import { WorkServiceService } from './works/work-service.service';
import { DetailWorkService } from './detail-work/detail-work.service';
import { CookieService } from './Cookie/cookie.service';
import { LocalStorageService } from './LocalStorage/local-storage.service';



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
    LocalStorageService
  ]
})
export class ServicesModule { }
