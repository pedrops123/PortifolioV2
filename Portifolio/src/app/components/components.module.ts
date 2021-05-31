import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardLayoutComponent } from './card-layout/card-layout.component';
import { LoadingComponent } from './loading/loading.component';
import { SwiperModule } from 'ngx-swiper-wrapper';
import { LightboxModule } from 'ngx-lightbox';
import { CarrouselWorkComponent } from './carrousel-work/carrousel-work.component';
import { TooltipStackComponent } from './tooltip-stack/tooltip-stack.component';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TooltipStackRightComponent } from './tooltip-stack-right/tooltip-stack-right.component';
import { TooltipStackLeftComponent } from './tooltip-stack-left/tooltip-stack-left.component';
import { HttpLoaderFactory } from '../app.module';
import { HttpClient } from '@angular/common/http';


@NgModule({
  declarations: [
    CardLayoutComponent,
    LoadingComponent,
    CarrouselWorkComponent,
    TooltipStackComponent,
    TooltipStackRightComponent,
    TooltipStackLeftComponent
  ],
  exports:[
    CardLayoutComponent,
    LoadingComponent,
    CarrouselWorkComponent,
    TooltipStackComponent,
    TooltipStackRightComponent,
    TooltipStackLeftComponent
  ],
  imports: [
    CommonModule,
    SwiperModule,
    LightboxModule,
    TranslateModule
    
  ]
})
export class ComponentsModule { }
