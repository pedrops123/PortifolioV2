import { TestBed } from '@angular/core/testing';

import { GeneralParametersService } from './general-parameters.service';

describe('GeneralParametersService', () => {
  let service: GeneralParametersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GeneralParametersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
