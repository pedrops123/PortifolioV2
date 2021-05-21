import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TooltipStackComponent } from './tooltip-stack.component';

describe('TooltipStackComponent', () => {
  let component: TooltipStackComponent;
  let fixture: ComponentFixture<TooltipStackComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TooltipStackComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TooltipStackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
