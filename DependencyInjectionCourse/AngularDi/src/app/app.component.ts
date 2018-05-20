import {Component} from '@angular/core';
import {AppService} from './app.service';

@Component({selector: 'app-root', templateUrl: './app.component.html', styleUrls: ['./app.component.css']})
export class AppComponent {
  title = 'Empty';
  data = 'Welcome to AngularDi!';
  constructor(private _appService: AppService) {
    const numbers = _appService.getNumbers();
    this.title = `${numbers[2]}`;
  }
}
