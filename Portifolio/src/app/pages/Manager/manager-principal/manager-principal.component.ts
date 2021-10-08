import { AfterViewInit, Component, ContentChild, ContentChildren, DoCheck, ElementRef, EventEmitter, Input, OnChanges, OnInit, Output, Renderer2, SimpleChanges, ViewChild } from '@angular/core';

@Component({
  selector: 'app-manager-principal',
  templateUrl: './manager-principal.component.html',
  styleUrls: ['./manager-principal.component.css']
})
export class ManagerPrincipalComponent implements OnInit , AfterViewInit ,DoCheck  {

  @ViewChild('menuManager' , { static: true }) AnimationMenu :ElementRef;

  constructor(private render:Renderer2) {  }

  ngDoCheck(): void {
    
  }


  ngAfterViewInit(): void {
 
  }
  


  ngOnInit(): void {
     
  }




  validateMenu($event){
    if($event)
    {
      this.render.removeClass(this.AnimationMenu.nativeElement,"close");
    }
    else
    {
      this.render.addClass(this.AnimationMenu.nativeElement,"close");
    }
  }





  

}
