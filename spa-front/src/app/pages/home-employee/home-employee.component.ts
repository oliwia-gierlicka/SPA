import { Component } from '@angular/core';
import { Visit } from 'src/app/models/visit.model';
import { VisitService } from 'src/app/services/visit.service';

@Component({
  selector: 'app-home-employee',
  templateUrl: './home-employee.component.html',
  styleUrls: ['./home-employee.component.scss']
})
export class HomeEmployeeComponent {

  visits: Visit[] = [];

  constructor(private visitservice: VisitService) { }

  ngOnInit() {
    this.visitservice.getEmployeeVisits().subscribe(x => {
      this.visits = x;
    })
  }

}
