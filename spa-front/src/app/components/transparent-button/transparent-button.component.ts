import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-transparent-button',
  templateUrl: './transparent-button.component.html',
  styleUrls: ['./transparent-button.component.scss']
})
export class TransparentButtonComponent {
  @Input() text: string = "";
  @Output() click: EventEmitter<void> = new EventEmitter();
}
