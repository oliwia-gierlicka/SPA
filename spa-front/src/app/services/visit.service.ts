import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Visit } from '../models/visit.model';
import { VisitForm } from '../models/visit-form.model';
import { ServiceAvailabilityRequest } from '../models/service-availability-request.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VisitService {

  constructor(private http: HttpClient) { }


  getVisits(): Observable<Visit[]> {
    return this.http.get<Visit[]>(`${environment.apiUrl}/visit`);
  }

  getEmployeeVisits(): Observable<Visit[]> {
    return this.http.get<Visit[]>(`${environment.apiUrl}/employee/visits`);
  }

  deleteVisit(id: number): Observable<void> {
    return this.http.delete<void>(`${environment.apiUrl}/visit/${id}`);
  }

  createVisit(form: VisitForm): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/visit/`, form);
  }

  checkAvailability(form: ServiceAvailabilityRequest): Observable<string[]> {
    return this.http.post<string[]>(`${environment.apiUrl}/visit/availability`, form);
  }
}
