import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TooltipStackRightComponent } from './tooltip-stack-right.component';

describe('TooltipStackRightComponent', () => {
  let component: TooltipStackRightComponent;
  let fixture: ComponentFixture<TooltipStackRightComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TooltipStackRightComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TooltipStackRightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
