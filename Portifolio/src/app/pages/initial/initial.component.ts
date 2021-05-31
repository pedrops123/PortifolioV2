import { AfterContentChecked, AfterContentInit, AfterViewInit, Component, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/app.component';
import  $ from 'jquery';
import { CookieService } from 'src/app/services/Cookie/cookie.service';
import { LocalStorageService } from 'src/app/services/LocalStorage/local-storage.service';
import { dataArray } from './InitialModelFactory';
import { ModelInitialStacks } from 'src/app/models/ModelInitialStacks';

@Component({
  selector: 'app-initial',
  templateUrl: './initial.component.html',
  styleUrls: ['./initial.component.css']
})
export class InitialComponent implements OnInit {
  stackArray:ModelInitialStacks[] = dataArray;

  constructor(component:AppComponent , private LocalStorageService:LocalStorageService) {
      component.setTitle('Pagina Inicial');      
      //console.log(LocalStorageService.getItem('complete_animation'));
      if(LocalStorageService.getItem('complete_animation') == null){
            setTimeout(() => {
              this.initialTransition();
          }, 100);
      }
   }
 

  ngOnInit(): void {
  }


  initialTransition(){
    //Ativa  
    setTimeout(() => {
      document.getElementById("img-angular").classList.add("animation");
      document.getElementById("img-dotnet").classList.add("animation");
      document.getElementById("img-html").classList.add("animation");
      document.getElementById("img-css").classList.add("animation"); 
    }, 100);

    setTimeout(() => {
      document.getElementById("img-angular").classList.remove("animation");
      document.getElementById("img-dotnet").classList.remove("animation");
      document.getElementById("img-html").classList.remove("animation");
      document.getElementById("img-css").classList.remove("animation"); 
    }, 2000);

    // Seta local Storage para executar apenas uma vez a animação
    this.LocalStorageService.setItemComplex('complete_animation', { completed:true });
  }

}
