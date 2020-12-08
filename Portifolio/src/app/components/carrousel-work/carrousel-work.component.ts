import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { Lightbox } from 'ngx-lightbox';
import { SwiperDirective } from 'ngx-swiper-wrapper';
import { arrayFotos } from './CarrouselFotos';



@Component({
  selector: 'carrousel-work',
  templateUrl: './carrousel-work.component.html',
  styleUrls: ['./carrousel-work.component.css']
})
export class CarrouselWorkComponent implements OnInit  {

    @Input("fotos") data:string[];  

    _album = [];
    fotoThumbSelecionada :number = 0;
    loading:boolean;
    mostrar:boolean;

    /*
      fotoSelecionadaDisplay:string = "";
   */
  constructor(private _lightbox: Lightbox) { 
    this.loading = true;
    this.mostrar = false;
     // console.log(this.data);
     setTimeout(()=>{
      this.data.forEach(r => this._album.push(
        {
          src:r,
          caption:'Descritivo foto',
          thumb:r
        }
      ));
      this.loading = false;
      this.mostrar = true;
     },1000);
     
   
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
