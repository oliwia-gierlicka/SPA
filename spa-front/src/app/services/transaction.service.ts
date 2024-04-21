import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Transaction } from '../models/transaction.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {

  constructor(private http: HttpClient) { }

  public getTransactions(): Observable<{ [key: string]: Transaction[] }> {
    return this.http.get<{ [key: string]: Transaction[] }>(`${environment.apiUrl}/transaction`);
  }
}
