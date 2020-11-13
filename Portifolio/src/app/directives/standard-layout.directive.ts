import { ElementRef, HostBinding, Renderer2 } from '@angular/core';
import { Directive } from '@angular/core';

@Directive({
  selector: '[appStandardLayout]'
})
export class StandardLayoutDirective {

  constructor(private element:ElementRef , private renderer:Renderer2) {
      this.renderer.setStyle(this.element.nativeElement , 'background-color' , '#E7E7E7');
      this.renderer.setStyle(this.element.nativeElement , 'width' , '100%');
      this.renderer.setStyle(this.element.nativeElement , 'height' , '100%');
      this.renderer.setStyle(this.element.nativeElement , 'display' , 'flex');
      this.renderer.setStyle(this.element.nativeElement , 'align-items' , 'center');
      this.renderer.setStyle(this.element.nativeElement , 'justify-content' , 'center');
   }

}
