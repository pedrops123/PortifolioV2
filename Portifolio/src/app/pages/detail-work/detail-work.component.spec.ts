import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailWorkComponent } from './detail-work.component';

describe('DetailWorkComponent', () => {
  let component: DetailWorkComponent;
  let fixture: ComponentFixture<DetailWorkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailWorkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailWorkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
