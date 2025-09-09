
import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Category } from '../../models/category.model';
import { CategoryService } from '../../services/category';

@Component({
  selector: 'app-categories-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  template: `
    <h2>Categorie</h2>
    <button routerLink="/categories/new">Aggiungi categoria</button>
    <table>
      <tr>
        <th>Nome</th><th>Azioni</th>
      </tr>
      <tr *ngFor="let c of categories">
        <td>{{c.name}}</td>
        <td>
          <button [routerLink]="['/categories', c.id]">Modifica</button>
          <button (click)="delete(c.id)">Elimina</button>
        </td>
      </tr>
    </table>
  `
})
export class CategoriesList implements OnInit {
  categories: Category[] = [];
  constructor(private service: CategoryService) {}
  ngOnInit() { this.load(); }
  load() {
    this.service.getAll().subscribe(res => this.categories = res);
  }
  delete(id: number) {
    if (confirm('Sicuro di eliminare?')) {
      this.service.delete(id).subscribe(() => this.load());
    }
  }
}