import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Service } from '../models/service.model';

@Injectable({
  providedIn: 'root'
})
export class ServiceSpaService {

  constructor(private http:HttpClient) { }

  byCategory(name:string):Observable<Service[]>{
    return this.http.get<Service[]>('https://localhost:44369/service/category/'+name)
  }
}
