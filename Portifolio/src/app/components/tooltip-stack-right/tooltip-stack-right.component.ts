import { AfterViewInit, Component, ElementRef, Input, OnChanges, OnInit, Renderer2, SimpleChanges, ViewChild } from '@angular/core';

@Component({
  selector: 'tooltip-right',
  templateUrl: './tooltip-stack-right.component.html',
  styleUrls: ['./tooltip-stack-right.component.css']
})
export class TooltipStackRightComponent implements OnInit , AfterViewInit , OnChanges {

  @Input('hover') isHover :Boolean;
  @Input('idElemento') Id : string;
  @Input('TextoTooltip') texto :string;
  @ViewChild('divMain', { static: true }) _ToolTipMain :ElementRef;
  
  
  constructor(private render:Renderer2) {
    this.isHover = false;
   }
   
  ngOnChanges(changes: SimpleChanges): void {
    if(this.isHover){
      this.render.removeClass(this._ToolTipMain.nativeElement,"hide");
    }
     else{
      this.render.addClass(this._ToolTipMain.nativeElement , "hide");
    }
  }

  ngAfterViewInit(): void {
   // console.log(this._ToolTipMain);
    this.render.addClass(this._ToolTipMain.nativeElement , "hide");
  }


  ngOnInit(): void {
  }
}
