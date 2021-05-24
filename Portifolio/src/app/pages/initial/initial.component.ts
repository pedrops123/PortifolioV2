import { Component, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/app.component';

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
      tooltip:false,
      descriptionTooltip:'',
      active:false
    },
    {
      fotoStack:'../../../assets/stacks/dotnet.png',
      class: 'base-logo-stack img_dotnet stack-up',
      id:'img-dotnet',
      tooltip:false,
      descriptionTooltip:'',
      active:false
    },
    {
      fotoStack:'../../../assets/foto_perfil/foto_perfil.jpg',
      class: 'img-foto',
      id:'',
      tooltip:false,
      descriptionTooltip:'',
      active:false
    },
    {
      fotoStack:'../../../assets/stacks/html5.png',
      class: 'base-logo-stack img_html stack-up',
      id:'img-html',
      tooltip:false,
      descriptionTooltip:'',
      active:false
    },
    {
      fotoStack:'../../../assets/stacks/css3.png',
      class: 'base-logo-stack img_css stack-bottom',
      id:'img-css',
      tooltip:false,
      descriptionTooltip:'',
      active:true
    }

  ]; 
  constructor(component:AppComponent) {
      component.setTitle('Pagina Inicial');
   }

  ngOnInit(): void {
  }

}
