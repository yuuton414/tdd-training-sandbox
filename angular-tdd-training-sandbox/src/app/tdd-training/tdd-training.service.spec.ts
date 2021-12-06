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

  describe('FizzBuzz数列と変換規則を扱うテスト', () => {
    it('これは失敗します', () => {
      // テストを失敗させるメソッド
      // fail();
    });

    describe('数を文字列に変換する', () => {

      describe('その他の数のときはそのまま文字列に変換する', () => {
        it('1を渡すと文字列1を返す', () => {
          expect('1').toEqual(service.convertFizzBuzz(1));
        });
    
        // // 三角測量で出たUnitテスト -> いらなくなる
        // it('2を渡すと文字列2を返す', () => {
        //   expect('2').toEqual(service.convertFizzBuzz(2));
        // });
      });

      describe('15の倍数のときは FizzBuzz を返す', () => {
        it('15を渡すと文字列 FizzBuzz を返す', () => {
          expect('FizzBuzz').toEqual(service.convertFizzBuzz(15));
        });
      });
      
      describe('5の倍数のときはBuzzを返す', () => {
        it('5を渡すと文字列Buzzを返す', () => {
          expect('Buzz').toEqual(service.convertFizzBuzz(5));
        });
      });

      describe('3の倍数のときはFizzを返す', () => {
        it('3を渡すと文字列Fizzを返す', () => {
          expect('Fizz').toEqual(service.convertFizzBuzz(3));
        });
      });
      
    });
  
   

    

    
  });
});
