import { Component, OnInit, ViewChild } from '@angular/core';
import { Lightbox } from 'ngx-lightbox';
import { SwiperDirective } from 'ngx-swiper-wrapper';
import { arrayFotos } from './CarrouselFotos';



@Component({
  selector: 'carrousel-work',
  templateUrl: './carrousel-work.component.html',
  styleUrls: ['./carrousel-work.component.css']
})
export class CarrouselWorkComponent implements OnInit {

    data = arrayFotos;  

    _album = [];
    fotoThumbSelecionada :number = 0;
    /*
    fotoSelecionadaDisplay:string = "";
    
   */
  constructor(private _lightbox: Lightbox) { 
    
    this.data.forEach(r => this._album.push(
      {
        src:r.url,
        caption:'Descritivo foto',
        thumb:r.url
      }
    ));

    //this.mostraDisplayFoto(this.data[0].url ,this.data[0].id);
  }

  ngOnInit(): void {
  }

  open(index: number): void {
    // open lightbox
    this._lightbox.open(this._album, index);
  }

  close(): void {
    // close lightbox programmatically
    this._lightbox.close();
  }
  /*
  mostraDisplayFoto(foto:string , id:number){
    this.fotoThumbSelecionada = id;
    this.fotoSelecionadaDisplay = foto;
  }
   */

}
