import { Component, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/app.component';
//import { PageEvent } from '@angular/material/paginator';
import { DataCardComponent } from 'src/app/models/DataCardComponent';
import { PaginationCardsParameter } from 'src/app/models/PaginationCardsParameter';
import { WorkServiceService } from 'src/app/services/works/work-service.service';


@Component({
  selector: 'app-works',
  templateUrl: './works.component.html',
  styleUrls: ['./works.component.css']
})
export class WorksComponent implements OnInit {
  indexBefore = null;
  totalLength = 1000;
  qtdParada:number = 0;
  cards:DataCardComponent[]; 
  pageSize = 6;
  pageSizeOptions: number[] = [6];


  enableLoading:boolean;
  enableContent:boolean;

  constructor(
    private serviceWorks:WorkServiceService,
     component:AppComponent
     ) {
    component.setTitle('Meus Trabalhos');
/* 
      let eventInitial:PageEvent = {
        length:this.totalLength,
        pageSize:this.pageSize,
        pageIndex:0
      }
   */ 
   // this.getDataPagination(eventInitial);
   }

  ngOnInit(): void {
  }
/* x
  getDataPagination(){

    this.enableLoading = true;
    this.enableContent = false; 

    //console.log(event);
    if(this.indexBefore != null){
      if(event.pageIndex > this.indexBefore){
        this.qtdParada = this.qtdParada + event.pageSize;
      }
      else
      {
        this.qtdParada = this.qtdParada - event.pageSize;
      }
    }
   

    this.indexBefore = event.pageIndex;

    let parameter:PaginationCardsParameter = {
      skip:this.qtdParada,
      take: event.pageSize 
    };
    
    this.serviceWorks.getDataCards(parameter).subscribe(
      (r) => {
        this.cards = r;
        this.enableLoading = false;
        this.enableContent = true; 
        
      },
      (error) => { 
        console.log(error);
        this.enableLoading = false;
        this.enableContent = true; 
      }
    );
    console.log(this.cards);
    //this.cards = this.cards.slice((page_number - 1) * page_size, page_number * page_size);
  }
*/
}
