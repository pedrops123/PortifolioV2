import { AfterViewInit, Component, ElementRef, Input, OnChanges, OnInit, Renderer2, SimpleChanges, ViewChild } from '@angular/core';

@Component({
  selector: 'tooltip-stack-component',
  templateUrl: './tooltip-stack.component.html',
  styleUrls: ['./tooltip-stack.component.css']
})
export class TooltipStackComponent implements OnInit , AfterViewInit , OnChanges {
  
  @Input('hover') isHover :Boolean;
  @ViewChild('divMain') _ToolTipMain :ElementRef;
  
  constructor(private render:Renderer2) { }
  ngOnChanges(changes: SimpleChanges): void {
    if(this.isHover){
      this.render.setStyle(this._ToolTipMain.nativeElement , "display","block");
    }
     else{
      this.render.setStyle(this._ToolTipMain.nativeElement , "display","none");
    }
  }

  ngAfterViewInit(): void {
    console.log(this._ToolTipMain);
    this.render.setStyle(this._ToolTipMain.nativeElement , "display","none");
  }


  ngOnInit(): void {
  }

}
