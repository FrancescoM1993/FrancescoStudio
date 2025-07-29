import { Routes } from '@angular/router';
import { ProductsList } from './pages/products-list/products-list';

export const routes: Routes = [
  { path: 'products', component: ProductsList },
  { path: '', redirectTo: '/products' },
];

