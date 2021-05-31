import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TooltipStackLeftComponent } from './tooltip-stack-left.component';

describe('TooltipStackLeftComponent', () => {
  let component: TooltipStackLeftComponent;
  let fixture: ComponentFixture<TooltipStackLeftComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TooltipStackLeftComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TooltipStackLeftComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
