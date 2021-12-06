import { TestBed } from '@angular/core/testing';

import { TddTrainingService } from './tdd-training.service';

describe('TddTrainingService', () => {
  let service: TddTrainingService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TddTrainingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('自分の Email が取得できている', () => {
    const expEmail = 'test1@example.com'
    expect(service.getMyEmail()).toEqual(expEmail);
  });
});
