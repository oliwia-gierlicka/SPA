import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Visit } from 'src/app/models/visit.model';
import { VisitService } from 'src/app/services/visit.service';

@Component({
  selector: 'app-home-user',
  templateUrl: './home-user.component.html',
  styleUrls: ['./home-user.component.scss']
})
export class HomeUserComponent {

  visit?: Visit;

  constructor(private visitservice: VisitService,
    private router: Router) { }

  ngOnInit() {
    this.visitservice.getVisits().subscribe(x => {
      this.visit = x[0];
    })
  }

  deleteVisit() {
    if (this.visit)
      this.visitservice.deleteVisit(this.visit.id).subscribe();
  }

  goToServices() {
    this.router.navigateByUrl('/service/Fitness');

  }
}
