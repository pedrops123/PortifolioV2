import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardLayoutComponent } from './card-layout/card-layout.component';
import { LoadingComponent } from './loading/loading.component';
import { SwiperModule } from 'ngx-swiper-wrapper';
import { LightboxModule } from 'ngx-lightbox';
import { CarrouselWorkComponent } from './carrousel-work/carrousel-work.component';
import { TooltipStackComponent } from './tooltip-stack/tooltip-stack.component';
import { TranslateModule } from '@ngx-translate/core';


@NgModule({
  declarations: [
    CardLayoutComponent,
    LoadingComponent,
    CarrouselWorkComponent,
    TooltipStackComponent
  ],
  exports:[
    CardLayoutComponent,
    LoadingComponent,
    CarrouselWorkComponent,
    TooltipStackComponent
  ],
  imports: [
    CommonModule,
    SwiperModule,
    LightboxModule
    
  ]
})
export class ComponentsModule { }
