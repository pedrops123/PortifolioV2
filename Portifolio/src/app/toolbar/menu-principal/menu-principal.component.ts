import { Component, OnInit } from '@angular/core';
import { Router, RouterLinkActive, RouterOutlet, ActivatedRoute } from '@angular/router';
import { ButtonsMenu } from 'src/app/models/ButtonsMenu';
import { RetornoGlobal } from 'src/app/models/RetornoGlobal';
import { MenuServiceService } from 'src/app/services/menu/menu-service.service';


@Component({
  selector: 'menu-principal',
  templateUrl: './menu-principal.component.html',
  styleUrls: ['./menu-principal.component.css']
})
export class MenuPrincipalComponent implements OnInit {

  dadosMenu:ButtonsMenu[];
 

  constructor(private router:Router , private routerActive:ActivatedRoute,  private serviceMenu:MenuServiceService) {
   
    serviceMenu.getMenuInicial().subscribe(
        Response =>{ this.dadosMenu = Response.retornoObjeto; console.log(Response.retornoObjeto)}  , 
        error => console.log('Ocorreu um erro na coleta dos dados ' + error.message) 
      );
   }

  ngOnInit(): void {
  }

  hasRoute(route:string){
    return this.router.url.includes(route);
  }

  
  getIdDescription(){
    let id = this.routerActive.snapshot.paramMap.get('idWork');
    //console.log(id);
    return id;
  }
  


}
