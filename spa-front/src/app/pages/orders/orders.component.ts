import { Component } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { Transaction } from 'src/app/models/transaction.model';
import { ProductsService } from 'src/app/services/products.service';
import { TransactionService } from 'src/app/services/transaction.service';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent {

  items: { [key: string]: Transaction[] } = {};
  keys: string[] = [];
  products: Product[] = [];

  constructor(private transactionService: TransactionService, private productService: ProductsService) { }

  ngOnInit() {
    this.transactionService.getTransactions().subscribe(x => {
      this.keys = Object.keys(x);
      this.items = x;
    })
    this.productService.getProducts().subscribe(x => {
      this.products = x;
    })
  }

  getProductName(id: number): string {
    const product = this.products.filter(x => x.id === id);
    return product[0].name;
  }

}
