import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-service-item',
  templateUrl: './service-item.component.html',
  styleUrls: ['./service-item.component.scss']
})
export class ServiceItemComponent {
  @Input() image:string="";
  @Input() title:string="";
  @Input() text:string="";
  @Input() link:string="";

  constructor(private router:Router){}
  
  navigate(){
    this.router.navigateByUrl(this.link);
  }
}
