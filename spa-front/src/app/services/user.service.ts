import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RegisterForm } from '../models/register-form.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { }

  createUser(form:RegisterForm) :Observable<void>{
    return this.http.post<void>('https://localhost:44369/user/new/',form)
  }
}
