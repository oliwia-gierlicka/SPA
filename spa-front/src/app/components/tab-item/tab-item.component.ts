import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tab-item',
  templateUrl: './tab-item.component.html',
  styleUrls: ['./tab-item.component.scss']
})
export class TabItemComponent {
  @Input() title: string = "";
  @Input() serviceId: number = -1;
  @Input() text: string = "";
  @Input() image: string = "";
  @Input() dark: boolean = false;
  @Input() width: number = 500;
  @Input() showOptions: boolean = false;

  constructor(private router: Router) { }

  makeReservation() {
    sessionStorage.setItem('reservation', JSON.stringify({
      id: this.serviceId,
      name: this.title
    }));
    this.router.navigateByUrl('/make-reservation');
  }
}
