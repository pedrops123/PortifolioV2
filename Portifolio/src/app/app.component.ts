import { Component, ElementRef } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { RouterOutlet } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { fader } from './routes/route-animations';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations:[fader]
})
export class AppComponent {

  buttonVisible:boolean;

  constructor(private titleService:Title , private translate:TranslateService){

    translate.setDefaultLang('pt-BR');

    document.onscroll = ($element)=> { 
      const elementToolbar:HTMLElement = document.documentElement;
      elementToolbar.scrollTop > 90 ? this.buttonVisible = true : this.buttonVisible = false; 
      //console.log(this.buttonVisible);
    }
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


