import { TestBed, inject } from '@angular/core/testing';

import { UsernumberService } from './usernumber.service';

describe('UsernumberService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [UsernumberService]
    });
  });

  it('should be created', inject([UsernumberService], (service: UsernumberService) => {
    expect(service).toBeTruthy();
  }));
});
