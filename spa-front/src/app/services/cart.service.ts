import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CartItem } from '../models/cart-item.model';
import { CartAddForm } from '../models/cart-add-form.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  constructor(private http: HttpClient) { }


  getCart(): Observable<CartItem[]> {
    return this.http.get<CartItem[]>(`${environment.apiUrl}/cart`);
  }

  deleteItemFromCart(id: number): Observable<void> {
    return this.http.delete<void>(`${environment.apiUrl}/cart/${id}`)
  }

  addToCart(form: CartAddForm): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/cart/`, form)
  }

  buy(): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/cart/buy`, {});
  }
}
