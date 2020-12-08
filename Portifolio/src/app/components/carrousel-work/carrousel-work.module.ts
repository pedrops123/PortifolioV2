import { AppModule } from './../../app.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CarrouselWorkComponent } from './carrousel-work.component';
import { SwiperModule, SwiperPaginationInterface } from 'ngx-swiper-wrapper';
import { SWIPER_CONFIG } from 'ngx-swiper-wrapper';
import { SwiperConfigInterface } from 'ngx-swiper-wrapper';
import { Thumbs } from 'swiper';
import { LightboxModule } from 'ngx-lightbox';
import { LoadingModule } from '../loading/loading.module';


/* 
const pagination: SwiperPaginationInterface = {
  el: '.swiper-pagination',
  clickable: true
};

const DEFAULT_SWIPER_CONFIG: SwiperConfigInterface = {

    
    effect:'flip',
    direction: 'horizontal',
    slidesPerView: 1,
    centeredSlides: true,
    slideToClickedSlide: true,
    pagination: pagination,
    navigation: true,
  
};

*/

@NgModule({
  declarations: [
    CarrouselWorkComponent
  ],
  exports:[
    CarrouselWorkComponent
  ],
  imports: [
    CommonModule,
    SwiperModule,
    LightboxModule,
    LoadingModule
  ],
  providers:[
    /* 
    {
      
      provide:SWIPER_CONFIG,
      useValue:DEFAULT_SWIPER_CONFIG
    }
    */
  ]
})
export class CarrouselWorkModule { }
