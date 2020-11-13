import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { loginModel } from 'src/app/models/loginModel';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { LoginServiceService } from '../../../services/Login/login-service.service';
import { Router } from '@angular/router';

class validacoesForm {
  validacaoLogin:string;
  validacaoSenha:string;
}


@Component({
  selector: 'form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.css']
})
export class FormLoginComponent implements OnInit {

  loginForm = new FormGroup({
      login:new  FormControl(''),
      senha:new FormControl('')
  },
  [
    Validators.nullValidator,
    Validators.required 
  ]);


  dadosFormulario:loginModel;
  validation:validacoesForm;
  mensagemValidation:string = "";
  
  constructor(private serviceLogin:LoginServiceService, private Router:Router) { 
    this.dadosFormulario = {
      login :'',
      senha:''
    }

    this.validation = {
      validacaoLogin : '',
      validacaoSenha : ''
    }

  }

  ngOnInit(): void {
    
  }

  submitUser(){

    let dadosLogin:loginModel = {
      login: this.loginForm.controls["login"].value,
      senha:this.loginForm.controls["senha"].value
    };

    
    this.serviceLogin.ValidaUser(dadosLogin).subscribe(
      response => {
        if(response.validado){
          this.Router.navigate(['/']);
          this.loginForm.reset();
        }
        else{
          this.mensagemValidation = response.messageErrors[0];
        }
      },
      error => console.log(error)
    );


    /*
        
      var login  = this.loginForm.controls["login"].value;
      var senha =  this.loginForm.controls["senha"].value;
      console.log(this.loginForm);
      console.log(login.toString());
      console.log(senha.toString());
    */



    
  }




}
