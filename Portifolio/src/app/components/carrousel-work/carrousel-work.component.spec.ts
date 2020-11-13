import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarrouselWorkComponent } from './carrousel-work.component';

describe('CarrouselWorkComponent', () => {
  let component: CarrouselWorkComponent;
  let fixture: ComponentFixture<CarrouselWorkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarrouselWorkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarrouselWorkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
