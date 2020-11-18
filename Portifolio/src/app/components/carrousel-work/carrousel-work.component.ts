import { Component, OnInit, ViewChild } from '@angular/core';
import { SwiperDirective } from 'ngx-swiper-wrapper';
import { arrayFotos } from './CarrouselFotos';

@Component({
  selector: 'carrousel-work',
  templateUrl: './carrousel-work.component.html',
  styleUrls: ['./carrousel-work.component.css']
})
export class CarrouselWorkComponent implements OnInit {

    data = arrayFotos;  

    fotoSelecionadaDisplay:string = "";
    fotoThumbSelecionada :number = 0;
  
  constructor() { 
    this.mostraDisplayFoto(this.data[0].url ,this.data[0].id);
  }

  ngOnInit(): void {
  }


  mostraDisplayFoto(foto:string , id:number){
    this.fotoThumbSelecionada = id;
    this.fotoSelecionadaDisplay = foto;
  }

}
