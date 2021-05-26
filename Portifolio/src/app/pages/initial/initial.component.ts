import { AfterContentChecked, AfterContentInit, AfterViewInit, Component, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/app.component';
import  $ from 'jquery';
import { CookieService } from 'src/app/services/Cookie/cookie.service';
import { LocalStorageService } from 'src/app/services/LocalStorage/local-storage.service';

@Component({
  selector: 'app-initial',
  templateUrl: './initial.component.html',
  styleUrls: ['./initial.component.css']
})
export class InitialComponent implements OnInit {
  stackArray:any[] = [

    {
      fotoStack:'../../../assets/stacks/angular.png',
      class: 'base-logo-stack img_angular stack-bottom',
      id:'img-angular',
      tooltip:true,
      tooltipType:'right',
      descriptionTooltip:`<b>Texto Angular</b> <br/><br/> teste de texto no tooltip , isto é apenas um teste simples <br/> de como ficará o tooltip com o texto original!<br/>`,
      active:true
    },
    {
      fotoStack:'../../../assets/stacks/dotnet.png',
      class: 'base-logo-stack img_dotnet stack-up',
      id:'img-dotnet',
      tooltip:true,
      tooltipType:'right',
      descriptionTooltip:`<b>Texto Dotnet</b> <br/><br/> teste de texto no tooltip , isto é apenas um teste simples <br/> de como ficará o tooltip com o texto original!<br/>`,
      active:false
    },
    {
      fotoStack:'../../../assets/foto_perfil/foto_perfil.jpg',
      class: 'img-foto',
      id:'',
      tooltip:false,
      tooltipType:'',
      descriptionTooltip:'',
      active:false
    },
    {
      fotoStack:'../../../assets/stacks/html5.png',
      class: 'base-logo-stack img_html stack-up',
      id:'img-html',
      tooltipType:'left',
      tooltip:true,
      descriptionTooltip:`<b>Texto HTML</b> <br/><br/> teste de texto no tooltip ,
                           isto é apenas um teste simples <br/> de como ficará o
                           tooltip com o texto original!<br/><br/><br/><br/><br/><br/>
                           <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>`,
      active:false
    },
    {
      fotoStack:'../../../assets/stacks/css3.png',
      class: 'base-logo-stack img_css stack-bottom',
      id:'img-css',
      tooltipType:'left',
      tooltip:true,
      descriptionTooltip:`<b>Texto CSS</b> <br/><br/> teste de texto no tooltip , isto é apenas um teste simples <br/> de como ficará o tooltip com o texto original!<br/>`,
      active:true
    }

  ]; 
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
