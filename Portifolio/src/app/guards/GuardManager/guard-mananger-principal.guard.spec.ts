import { TestBed } from '@angular/core/testing';

import { GuardManangerPrincipalGuard } from './guard-mananger-principal.guard';

describe('GuardManangerPrincipalGuard', () => {
  let guard: GuardManangerPrincipalGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(GuardManangerPrincipalGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
