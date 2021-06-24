import { AfterViewInit, Component, ElementRef, Renderer2, ViewChild } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router, RouterOutlet } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { fader } from './routes/route-animations';
import  * as  $ from 'jquery';
import { Location } from '@angular/common';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations:[fader]
})
export class AppComponent implements AfterViewInit {

  buttonVisible:boolean;
  @ViewChild('componentMainAnimation' , { static: true }) MainAnimation :ElementRef;

  constructor(
    private titleService:Title ,
    private render:Renderer2,   
    private location:Location ,  
    private translate:TranslateService){

    translate.setDefaultLang('pt-BR');

    document.onscroll = ($element)=> { 
      const elementToolbar:HTMLElement = document.documentElement;
      elementToolbar.scrollTop > 90 ? this.buttonVisible = true : this.buttonVisible = false; 
      //console.log(this.buttonVisible);
    }

  }



  ngAfterViewInit(): void {
    this.location.onUrlChange(
      (route:any) =>{
        console.log(route.replace('/',''));
        if (
          route.replace('/','').trim() == 'contact' || 
          route.replace('/','').trim() == '404' || 
          route.replace('/','').trim() == 'login'){

          this.render.removeStyle(this.MainAnimation.nativeElement,'display');
          this.render.setStyle(this.MainAnimation.nativeElement,"display","flex");
          this.render.setStyle(this.MainAnimation.nativeElement,"justify-content","center");
          this.render.setStyle(this.MainAnimation.nativeElement,"align-items","center");
          this.render.setStyle(this.MainAnimation.nativeElement,"height","100%");
          //console.log(document.getElementsByTagName("main")[0].style);
          /* 
          document.getElementsByTagName("main")[0].style.display = "flex";
          document.getElementsByTagName("main")[0].style.justifyContent = "center"; 
          document.getElementsByTagName("main")[0].style.alignContent = "center";
          document.getElementsByTagName("main")[0].style.placeContent = "none !important";
          document.getElementsByTagName("main")[0].style.height = "100%";
          */
        }
        else 
        {
          this.render.setStyle(this.MainAnimation.nativeElement,"display","block");
          this.render.removeStyle(this.MainAnimation.nativeElement,"justify-content");
          this.render.removeStyle(this.MainAnimation.nativeElement,"align-items");
          this.render.removeStyle(this.MainAnimation.nativeElement,"height");

          /* 
          document.getElementsByTagName("main")[0].style.display = "block";
          document.getElementsByTagName("main")[0].style.removeProperty("justifyContent");
          document.getElementsByTagName("main")[0].style.removeProperty("alignContent"); 
          document.getElementsByTagName("main")[0].style.removeProperty("height"); 
          */
        }
      }
    );
  }

  scrollToTop(){
    var elementoDOM = document.getElementById('topo');
    elementoDOM.scrollIntoView({ behavior: "smooth", block: "start", inline: "nearest" });
  }

  setTitle(description:string){
    this.titleService.setTitle(`Portfólio - ${ description }`);
  }

  prepareRoute(outlet:RouterOutlet){
    return outlet && outlet.activatedRouteData && outlet.activatedRouteData['animation'];
  }
}


