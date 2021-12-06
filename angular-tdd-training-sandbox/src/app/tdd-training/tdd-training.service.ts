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

  convertFizzBuzz(num: number): string {
    if (num % 3 == 0) return 'Fizz';
    if (num % 5 == 0) return 'Buzz'
    return num.toString();
  }

}
