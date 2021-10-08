/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ShippersService } from './shippers.service';

describe('Service: Shippers', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ShippersService]
    });
  });

  it('should ...', inject([ShippersService], (service: ShippersService) => {
    expect(service).toBeTruthy();
  }));
});
