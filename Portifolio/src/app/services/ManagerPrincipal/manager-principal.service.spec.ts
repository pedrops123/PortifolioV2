import { TestBed } from '@angular/core/testing';

import { ManagerPrincipalService } from './manager-principal.service';

describe('ManagerPrincipalService', () => {
  let service: ManagerPrincipalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ManagerPrincipalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
