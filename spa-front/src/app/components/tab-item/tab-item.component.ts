import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-tab-item',
  templateUrl: './tab-item.component.html',
  styleUrls: ['./tab-item.component.scss']
})
export class TabItemComponent {
  @Input()title:string="";
  @Input()text:string="";
  @Input()image:string="";
  @Input()dark:boolean=false
  @Input() width: number = 500;
}
