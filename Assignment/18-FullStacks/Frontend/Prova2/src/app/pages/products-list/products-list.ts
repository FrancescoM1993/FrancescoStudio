import { Component, OnInit } from '@angular/core';
import { Products } from '../../api/products';
import { Product } from '../../api/api-client';

@Component({
  selector: 'app-products-list',
  standalone: false,
  templateUrl: './products-list.html',
  styleUrl: './products-list.scss'
})
export class ProductsList implements OnInit {
  products: Product[] = [];

  constructor(private productsService: Products) { }

  ngOnInit(): void {
    this.productsService.productsAll().subscribe(products => {
      this.products = products;
    });
  }

}
