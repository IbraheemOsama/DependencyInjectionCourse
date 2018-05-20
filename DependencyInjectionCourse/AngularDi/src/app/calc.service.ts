import { Injectable } from '@angular/core';

@Injectable()
export class CalcService {

  getNumber(): number {
        return Math.random() * 10;
  }

}
