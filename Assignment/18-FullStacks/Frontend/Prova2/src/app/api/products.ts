import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiClient, Product } from './api-client';

@Injectable({
  providedIn: 'root'
})
export class Products {
  constructor(private apiClient: ApiClient) {}

  productsAll(): Observable<Product[]> {
    return this.apiClient.productsAll();
  }

  productsById(id: number): Observable<Product> {
    return this.apiClient.productsGET(id);
  }

  createProduct(product: Product): Observable<Product> {
    return this.apiClient.productsPOST(product);
  }

  updateProduct(id: number, product: Product): Observable<void> {
    return this.apiClient.productsPUT(id, product);
  }
}
  

