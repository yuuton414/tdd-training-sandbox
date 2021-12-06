import { Component, OnInit } from '@angular/core';
import { TddTrainingService } from './tdd-training.service';

@Component({
  selector: 'app-tdd-training',
  templateUrl: './tdd-training.component.html',
  styleUrls: ['./tdd-training.component.scss']
})
export class TddTrainingComponent implements OnInit {

  title = '';

  constructor(
    private _service: TddTrainingService,
  ) { }

  ngOnInit(): void {
    this.title = this._service.title;
  }

}
