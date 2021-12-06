import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TddTrainingComponent } from './tdd-training.component';
import { TddTrainingService } from './tdd-training.service';

describe('TddTrainingComponent', () => {
  let component: TddTrainingComponent;
  let fixture: ComponentFixture<TddTrainingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      providers: [
        TddTrainingService,
      ],
      declarations: [ TddTrainingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TddTrainingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('title が取得できている', () => {
    expect(component.title).toEqual('TDD Training');
  });
  
});
