/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { DbConnectionService } from './db-connection.service';

describe('Service: DbConnection', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DbConnectionService]
    });
  });

  it('should ...', inject([DbConnectionService], (service: DbConnectionService) => {
    expect(service).toBeTruthy();
  }));
});
