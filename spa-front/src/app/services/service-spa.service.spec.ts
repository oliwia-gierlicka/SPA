import { TestBed } from '@angular/core/testing';

import { ServiceSpaService } from './service-spa.service';

describe('ServiceSpaService', () => {
  let service: ServiceSpaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceSpaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
