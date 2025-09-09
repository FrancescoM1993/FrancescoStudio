import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  template: ``,
  styleUrls: ['./app.css']
})
export class App {
  protected readonly title = signal('MyApp');
}
