import { Component } from '@angular/core';
import { CartItem } from 'src/app/models/cart-item.model';
import { CartService } from 'src/app/services/cart.service';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent {

  items: CartItem[] = [];
  products: Product[] = [];

  constructor(private cartService: CartService, private productService: ProductsService, private router: Router) { }

  ngOnInit() {
    this.cartService.getCart().subscribe(x => {
      this.items = x;
    })
    this.productService.getDetails().subscribe(x => {
      this.products = x;
    })
  }

  getProductName(id: number): string {
    const product = this.products.filter(x => x.id === id);
    return product[0].name;
  }

  calculateSummary(): number {
    const prices = this.items.map(x => x.price * x.quantity);

    return prices.reduce((p, c, i, a) => p + c);
  }

  buy() {
    this.cartService.buy().subscribe(x => {
      this.router.navigateByUrl('/home-user')
    });
  }

}
