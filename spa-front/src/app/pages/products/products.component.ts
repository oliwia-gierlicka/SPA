import { Component } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent {

  products: Product[] = [];

  constructor(private productService: ProductsService) {}

  ngOnInit() {
    this.productService.getProducts().subscribe(x => {
      this.products = x;
    });
  }
}
