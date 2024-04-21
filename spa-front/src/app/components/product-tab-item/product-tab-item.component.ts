import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-product-tab-item',
  templateUrl: './product-tab-item.component.html',
  styleUrls: ['./product-tab-item.component.scss']
})
export class ProductTabItemComponent {
  @Input() title: string = "";
  @Input() productId: number = -1;
  @Input() price: number = -1;
  @Input() text: string = "";
  @Input() image: string = "";
  @Input() dark: boolean = false;
  @Input() width: number = 500;
  @Input() showOptions: boolean = false;

  quantity: number = 1;

  constructor(private cartService: CartService) { }

  addToCart() {
    this.cartService.addToCart({
      productId: this.productId,
      quantity: this.quantity,
      price: this.price
    }).subscribe();
  }
}
