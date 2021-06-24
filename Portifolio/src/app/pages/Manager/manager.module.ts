import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ComponentsModule } from 'src/app/components/components.module';



@NgModule({
  declarations: [LoginComponent],
  exports:[LoginComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    ComponentsModule
  ]
})
export class ManagerModule { }
