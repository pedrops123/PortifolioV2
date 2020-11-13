import { TestBed } from '@angular/core/testing';

import { WorkServiceService } from './work-service.service';

describe('WorkServiceService', () => {
  let service: WorkServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WorkServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
