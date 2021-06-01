import { AfterContentChecked, AfterContentInit, AfterViewChecked, AfterViewInit, Component, ElementRef, OnInit } from '@angular/core';
import { AppComponent } from 'src/app/app.component';
import  $ from 'jquery';
import { CookieService } from 'src/app/services/Cookie/cookie.service';
import { LocalStorageService } from 'src/app/services/LocalStorage/local-storage.service';
import { dataArray } from './InitialModelFactory';
import { ModelInitialStacks } from 'src/app/models/ModelInitialStacks';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-initial',
  templateUrl: './initial.component.html',
  styleUrls: ['./initial.component.css']
})
export class InitialComponent implements OnInit , AfterContentChecked {
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
  ngAfterContentChecked(): void {
    this.montaIdadeDinamica();
    this.montaAnoInicio();
    this.montaNomeDev();
    this.montaStacksMensagem();
    //console.log(el);
  }


  ngOnInit(): void {
  }

//#region transicao_inicial
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
     // this.LocalStorageService.setItemComplex('complete_animation', { completed:true });
    }

//#endregion
  

  //#region montagem_mensagem

  montaIdadeDinamica(){
    let idadeDinamica = (new Date().getFullYear() - 1996).toString();
    let el:HTMLCollectionOf<Element> = document.getElementsByClassName("painel-boas-vindas");
    let textMontado = el[0].innerHTML.replace("$year","atualmente tenho " + idadeDinamica + " anos" );
    el[0].innerHTML = textMontado;
  }

  montaAnoInicio() {
    let el:HTMLCollectionOf<Element> = document.getElementsByClassName("painel-boas-vindas");
    let textMontado = el[0].innerHTML.replace("$anoInicio", environment.dataInicioCarreira.toString() );
    el[0].innerHTML = textMontado;
  }

  montaNomeDev(){
    let nome_dev_split = environment.name_dev.split(' ');
    let nomeDevMontado = "";

    nome_dev_split.map(r => {
        let substringName = r.substring(2,r.length).toString();
        nomeDevMontado += r[0].toUpperCase() + r[1].toString() + substringName + " ";   
    });


    let el:HTMLCollectionOf<Element> = document.getElementsByClassName("painel-boas-vindas");
    let textMontado = el[0].innerHTML.replace("$nameDev", nomeDevMontado );
    el[0].innerHTML = textMontado;
  }

  montaStacksMensagem(){
    let stringStacks = "";
    this.stackArray.map(r=> {
      if (r.nameStack != ''){
          stringStacks += r.nameStack + " , ";
      }
    });

    const ultimaPosicaoVirgula = stringStacks.lastIndexOf(','); 
    const stringStacksMontada =  stringStacks.substring(0 , ultimaPosicaoVirgula -1);

    let el:HTMLCollectionOf<Element> = document.getElementsByClassName("painel-boas-vindas");
    let textMontado = el[0].innerHTML.replace("$ArrayStacks", stringStacksMontada );
    el[0].innerHTML = textMontado;
  }

  //#endregion



}
