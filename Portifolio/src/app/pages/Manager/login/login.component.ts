import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginServiceService } from 'src/app/services/Login/login-service.service';

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
      private loginService:LoginServiceService) {
      this._FormLogin =  builder.group({
        login:['' , [ Validators.required , Validators.minLength(1) ]],
        senha:['',  [ Validators.required , Validators.minLength(1) ]]
      });
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

              }
              else{
                var errors = "";
                r.retornoObjeto.messageerrors.map(r=>{
                  errors != r + '<br/>';
                });
                alert(errors);
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
