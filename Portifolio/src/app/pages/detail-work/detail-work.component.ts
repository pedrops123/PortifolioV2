import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Lightbox } from 'ngx-lightbox';
import { AppComponent } from 'src/app/app.component';
import { DetailProject } from 'src/app/models/DetailProject';
import { lightbox_model } from 'src/app/models/lightbox_model';
import { DetailWorkService } from 'src/app/services/detail-work/detail-work.service';
import { MenuPrincipalComponent } from 'src/app/toolbar/menu-principal/menu-principal.component';
import { data } from '../works/data';
import { dataExampleArray } from './data-detail-example';

@Component({
  selector: 'work-detail',
  templateUrl: './detail-work.component.html',
  styleUrls: ['./detail-work.component.css']
})
export class DetailWorkComponent implements OnInit {

  idProjeto:any;
  dataProjeto:any[] = dataExampleArray;
  positionActual = 0;
  imageSelected:String = this.dataProjeto[this.positionActual].src;

  constructor(private route: ActivatedRoute , private _lightbox: Lightbox , private principal:AppComponent ,private serviceDetail:DetailWorkService , private routerLink:Router ) {
      this.idProjeto = parseInt(this.route.snapshot.paramMap.get('idWork'));

      /* 

       this.serviceDetail.getDataDetailWork(this.idProjeto).subscribe(
         r => {
           this.dataProjeto = r;
           console.log(this.dataProjeto);
         },
         error => {
          // routerLink.navigate(['404']);
          console.log(error);
         });
      */
      //console.log(this.idProjeto);
      principal.scrollToTop();
   }

   setNextImage(){
      this.positionActual++;
      if(this.positionActual <= this.dataProjeto.length -1){
        this.setImage();
      }
   }


   setPreviousImage(){
    this.positionActual--;
     if(this.positionActual >= 0){
        this.setImage();
     }
   }

   setImage(){
     this.imageSelected =  this.dataProjeto[this.positionActual].src;
   }

   openModalImg(index:number){
    this._lightbox.open(this.dataProjeto , index);
   }


   close(): void {
    // close lightbox programmatically
    this._lightbox.close();
  }

  
  ngOnInit(): void {
  }

}
