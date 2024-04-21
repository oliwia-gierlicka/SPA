import { Component } from '@angular/core';
import { Visit } from 'src/app/models/visit.model';
import { VisitService } from 'src/app/services/visit.service';

@Component({
  selector: 'app-visits',
  templateUrl: './visits.component.html',
  styleUrls: ['./visits.component.scss']
})
export class VisitsComponent {

  items: Visit[] = [];

  constructor(private visitService: VisitService) {}

  ngOnInit() {
    this.visitService.getVisits().subscribe(x => {
      this.items = x;
    })
  }

  decline(id: number) {
    this.visitService.deleteVisit(id).subscribe(() => {
      this.visitService.getVisits().subscribe(x => {
        this.items = x;
      })
    })
  }
}
