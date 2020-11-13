import { Component, ElementRef } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'Portifolio';
  buttonVisible:boolean;

  constructor(){
    document.onscroll = ($element)=> { 
      const elementToolbar:HTMLElement = document.documentElement;
      elementToolbar.scrollTop > 90 ? this.buttonVisible = true : this.buttonVisible = false; 
      //console.log(this.buttonVisible);
    }
  }

  scrollToTop(){
    var elementoDOM = document.getElementById('tb-menu');
    elementoDOM.scrollIntoView({ behavior: "smooth", block: "start", inline: "nearest" });
  }


}


