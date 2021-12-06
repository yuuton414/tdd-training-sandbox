import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TddTrainingService {

  title = 'TDD Training';

  constructor() { }

  getMyEmail(): string {
    const email = 'test1@example.com';
    return email;
  }
}
