import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ComponentsModule } from 'src/app/components/components.module';
import { ManagerPrincipalComponent } from './manager-principal/manager-principal.component';



@NgModule({
  declarations: [
    LoginComponent,
    ManagerPrincipalComponent
  ],
  exports:[
    LoginComponent,
    ManagerPrincipalComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    ComponentsModule
  ]
  ,providers:[
    ManagerPrincipalComponent
  ]
})
export class ManagerModule { }
