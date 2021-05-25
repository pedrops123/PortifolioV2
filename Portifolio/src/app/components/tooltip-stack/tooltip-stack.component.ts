import { AfterViewInit, Component, ElementRef, Input, OnChanges, OnInit, Renderer2, SimpleChanges, ViewChild } from '@angular/core';

@Component({
  selector: 'tooltip-stack-component',
  templateUrl: './tooltip-stack.component.html',
  styleUrls: ['./tooltip-stack.component.css']
})
export class TooltipStackComponent implements OnInit , AfterViewInit , OnChanges {
  
  @Input('hover') isHover :Boolean;
  @Input('TextoTooltip') texto :string;
  @ViewChild('divMain', { static: true }) _ToolTipMain :ElementRef;
  
  constructor(private render:Renderer2) { }
  ngOnChanges(changes: SimpleChanges): void {
    if(this.isHover){
      this.render.removeClass(this._ToolTipMain.nativeElement,'hide');
    }
     else{
      this.render.addClass(this._ToolTipMain.nativeElement , "hide");
    }
  }

  ngAfterViewInit(): void {
    console.log(this._ToolTipMain);
    this.render.addClass(this._ToolTipMain.nativeElement , "hide");
  }


  ngOnInit(): void {
  }

}
