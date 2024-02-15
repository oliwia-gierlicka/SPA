import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products-section',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsSectionComponent {
constructor(private router:Router){}
navigate(){
  this.router.navigateByUrl("/products");
}
}
