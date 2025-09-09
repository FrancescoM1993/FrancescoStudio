import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { Category } from '../../models/category.model';
import { CategoryService } from '../../services/category';

@Component({
  selector: 'app-category-form',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule],
  template: `
    <h2>{{isNew ? 'Aggiungi' : 'Modifica'}} categoria</h2>
    <form (ngSubmit)="save()">
      <label>Nome: <input [(ngModel)]="model.name" name="name" required></label><br>
      <button type="submit">Salva</button>
      <button type="button" (click)="goBack()">Annulla</button>
    </form>
  `
})
export class CategoryForm implements OnInit {
  model: Category = { id: 0, name: '' };
  isNew = true;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private service: CategoryService
  ) {}

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.isNew = false;
      this.service.get(+id).subscribe(c => this.model = c);
    }
  }

  save() {
    if (this.isNew) {
      this.service.add(this.model).subscribe(() => this.goBack());
    } else {
      this.service.update(this.model.id, this.model).subscribe(() => this.goBack());
    }
  }

  goBack() {
    this.router.navigate(['/categories']);
  }
}