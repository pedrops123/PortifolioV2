import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerPrincipalComponent } from './manager-principal.component';

describe('ManagerPrincipalComponent', () => {
  let component: ManagerPrincipalComponent;
  let fixture: ComponentFixture<ManagerPrincipalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagerPrincipalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManagerPrincipalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
