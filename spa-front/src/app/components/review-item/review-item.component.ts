import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-review-item',
  templateUrl: './review-item.component.html',
  styleUrls: ['./review-item.component.scss']
})
export class ReviewItemComponent {
  @Input()name: string="";
  @Input()text: string="";
}
