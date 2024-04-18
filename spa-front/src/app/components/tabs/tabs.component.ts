import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Service } from 'src/app/models/service.model';
import { ServiceSpaService } from 'src/app/services/service-spa.service';

@Component({
  selector: 'app-tabs',
  templateUrl: './tabs.component.html',
  styleUrls: ['./tabs.component.scss']
})
export class TabsComponent {
  current = 'Fitness';
  services: Service[] = []

  constructor(private route: ActivatedRoute, private service: ServiceSpaService) {
    const name = route.snapshot.paramMap.get('id');

    if (name) {
      this.refresh(name)
    }

  }

  refresh(name: string) {
    this.service.byCategory(name).subscribe(x => {
      this.services = x
    })
  }

  choose(newCurrent: string) {
    this.current = newCurrent;
    this.refresh(newCurrent)
  }
}
