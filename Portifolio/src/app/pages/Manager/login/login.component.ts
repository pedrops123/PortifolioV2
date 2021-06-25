import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AppComponent } from 'src/app/app.component';
import { LoginServiceService } from 'src/app/services/Login/login-service.service';
import { TokenService } from 'src/app/services/token/token.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

   _FormLogin:FormGroup;
   _loading:boolean;
  constructor(
       private builder:FormBuilder , 
       private loginService:LoginServiceService,
       private ServiceToken:TokenService,
       private Router:Router,
       principal:AppComponent) {

      this._FormLogin =  builder.group({
        login:['' , [ Validators.required , Validators.minLength(1) ]],
        senha:['',  [ Validators.required , Validators.minLength(1) ]]
      });

      principal.setTitle('Login Manager');
   }

  ngOnInit(): void {
  }



  validateForm(){
      let campoLogin = this._FormLogin.controls['login'];
      let campoSenha = this._FormLogin.controls['senha'];

      if(this._FormLogin.valid){
        this._loading = true;
        this.loginService
        .ValidaUser({login:campoLogin.value , senha:campoSenha.value})
        .subscribe(r => {
          if(r.status == true){
              if (r.retornoObjeto.validado){
                  this.ServiceToken.setToken({
                    token:r.retornoObjeto.token,
                    roles:r.retornoObjeto.roles.descricaoAcesso,
                    hours:2000
                  });
                  this.Router.navigate(['/manager']); 
              }
              else {
                var errors = "";
                r.retornoObjeto.messageErrors.map(r=>{
                  errors += r + '<br/>';
                });
                alert(errors);
                this._FormLogin.reset();
              }
              this._loading = false;
          }
          else 
          {
              var errors = "";
              r.errors.map(r=>{
                errors != r + '<br/>';
              });

              alert(`Ocorreu um erro ao tentar logar : ${ errors }`);
              this._loading = false;
          }
        });
      }
      else
      {
        if(campoLogin.value.length == 0){
            campoLogin.markAsDirty();
        }
        if(campoSenha.value.length == 0){
            campoSenha.markAsDirty();
        }
      }

  }


}
