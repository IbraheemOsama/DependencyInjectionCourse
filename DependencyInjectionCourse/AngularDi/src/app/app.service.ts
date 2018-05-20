import {Injectable} from '@angular/core';
import {CalcService} from './calc.service';

@Injectable()
export class AppService {

  constructor(private _calcService: CalcService) {}

  getNumbers(): number[] {
    const numberArray = [];
    numberArray.push(this._calcService.getNumber());
    numberArray.push(this._calcService.getNumber());
    numberArray.push(this._calcService.getNumber());
    return numberArray;
  }

}
