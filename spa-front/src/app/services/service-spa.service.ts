import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Service } from '../models/service.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ServiceSpaService {

  constructor(private http: HttpClient) { }

  byCategory(name: string): Observable<Service[]> {
    return this.http.get<Service[]>(`${environment.apiUrl}/service/category/${name}`)
  }
}
