import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AppComponent } from 'src/app/app.component';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  _FormContato:FormGroup;
  
  constructor(builder:FormBuilder , component:AppComponent) {
    component.setTitle('Meu Contato');

    this._FormContato = builder.group({
      email:['',Validators.email],
      mensagem:['',Validators.maxLength(1)]
    });

   }

  ngOnInit(): void {
  }

}
