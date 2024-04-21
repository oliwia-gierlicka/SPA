import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserInfo } from 'src/app/models/user-info.model';
import { UserService } from 'src/app/services/user.service';
import { VisitService } from 'src/app/services/visit.service';

@Component({
  selector: 'app-make-reservation',
  templateUrl: './make-reservation.component.html',
  styleUrls: ['./make-reservation.component.scss']
})
export class MakeReservationComponent {

  serviceId: number = -1;
  serviceName: string = '';
  availableSlots: string[] = [];
  employees: UserInfo[] = [];

  form = new FormGroup({
    serviceId: new FormControl(this.serviceId, [Validators.required]),
    date: new FormControl('', [Validators.required]),
    employeeId: new FormControl('', [Validators.required])
  })

  constructor(private visitService: VisitService, 
    private userService: UserService,
    private router: Router) { }

  ngOnInit() {
    const reservation = JSON.parse(sessionStorage.getItem('reservation') || '{}')

    this.serviceId = reservation.id
    this.serviceName = reservation.name;

    this.form.patchValue({
      serviceId: this.serviceId
    })
    this.userService.getEmployees().subscribe(x => {
      this.employees = x;
    })
  }

  send() {
    if (this.form.valid) {
      const formValues = this.form.value;

      this.visitService.createVisit({
        serviceId: formValues.serviceId ?? 0,
        date: formValues.date ?? '',
        employeeId: parseInt(formValues.employeeId ?? '')
      }).subscribe(x => {
        sessionStorage.removeItem('reservation')
        this.router.navigateByUrl('/home-user')
      });
    }
  }

  changeDate(ev: any) {
    const val = ev.target.value;
    this.visitService.checkAvailability({
      when: val || '',
      employeeId: parseInt(this.form.controls.employeeId.value || ''),
      serviceId: this.serviceId
    }).subscribe(x => {
      this.availableSlots = x;
    })
  }

}
