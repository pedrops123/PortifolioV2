import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StandardLayoutDirective } from './standard-layout.directive';



@NgModule({
  declarations: [
    StandardLayoutDirective
  ],
  exports:[
    StandardLayoutDirective
  ],
  imports: [
    CommonModule
  ]
})
export class DirectivesModuleModule { }
