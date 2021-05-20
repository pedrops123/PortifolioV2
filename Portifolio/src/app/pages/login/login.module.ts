import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login.component';
import { rotaApp } from 'src/app/routes/app.routes';

import { FormLoginComponent } from './form-login/form-login.component';

import { DirectivesModuleModule } from 'src/app/directives/directives-module.module';
import { LoginServiceService } from '../../services/Login/login-service.service';
import { FormsModule }  from '@angular/forms'
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    LoginComponent,
    FormLoginComponent,


  ],
  exports:[
    LoginComponent
  ],

  imports: [
    CommonModule,

    DirectivesModuleModule,
    FormsModule,
    ReactiveFormsModule,
    rotaApp
  ],
  providers:[
    LoginServiceService
  ]
})
export class LoginModule { }
