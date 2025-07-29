import { Component } from "@angular/core";
import { RouterLink, RouterLinkActive, RouterOutlet } from "@angular/router";

@Component({
  selector: "app-root",
  standalone: true,
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
  imports: [RouterOutlet, RouterLink, RouterLinkActive],
  template: `
    <nav>
      <a routerLink="/products" routerLinkActive="active">Products</a>
    </nav>
    <main class="p-4">
      <h1>{{ title }}</h1>
      <router-outlet></router-outlet>
    </main>
  `,
  styles: [`
    nav {
      background: #eee;
      padding: 1rem;
    }
    a {
      margin-right: 1rem;
    }
    .active {
      font-weight: bold;
    }
    main {
      padding: 2rem;
    }
  `]
})
export class AppComponent {
  title = "Prova2";
}
 

