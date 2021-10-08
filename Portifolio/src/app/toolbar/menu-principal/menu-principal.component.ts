import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router, RouterLinkActive, RouterOutlet, ActivatedRoute } from '@angular/router';
import { ButtonsMenu } from 'src/app/models/ButtonsMenu';
import { RetornoGlobal } from 'src/app/models/RetornoGlobal';
import { ManagerPrincipalComponent } from 'src/app/pages/Manager/manager-principal/manager-principal.component';
import { GeneralParametersService } from 'src/app/services/GeneralParameters/general-parameters.service';
import { ManagerPrincipalService } from 'src/app/services/ManagerPrincipal/manager-principal.service';
import { MenuServiceService } from 'src/app/services/menu/menu-service.service';
import { TokenService } from 'src/app/services/token/token.service';


@Component({
  selector: 'menu-principal',
  templateUrl: './menu-principal.component.html',
  styleUrls: ['./menu-principal.component.css']
})
export class MenuPrincipalComponent implements OnInit {
  dadosMenu:ButtonsMenu[];
  idProjetoDisplay:Number;


  constructor(
    private router:Router , 
    private routerActive:ActivatedRoute,  
    private serviceMenu:MenuServiceService,
    private managerPrincipal:ManagerPrincipalComponent,
    private managerService:ManagerPrincipalService,
    public tokenService:TokenService,
    public generalParameters:GeneralParametersService ) {
   
    serviceMenu.getMenuInicial().subscribe(
        Response =>{  this.dadosMenu = Response.retornoObjeto; }  , 
        error => console.log('Ocorreu um erro na coleta dos dados ' + error.message) 
      );
   }

  ngOnInit(): void {
  }

  hasRoute(route:string){
    return this.router.url.includes(route);
  }

  setIdProject(idProjeto:Number){
    this.idProjetoDisplay = idProjeto;
  }

  deslogar(){
    this.tokenService.deslogarUser();
    this.router.navigate(['/login']);
  }

  OpenCloseMenu(){
    this.managerService.OpenMenu = !this.managerService.OpenMenu;
  }


}
