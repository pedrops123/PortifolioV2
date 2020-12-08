import { TestBed } from '@angular/core/testing';

import { DetailWorkService } from './detail-work.service';

describe('DetailWorkService', () => {
  let service: DetailWorkService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DetailWorkService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
