import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-tabs',
  templateUrl: './tabs.component.html',
  styleUrls: ['./tabs.component.scss']
})
export class TabsComponent {
  current=0;

  constructor(private route:ActivatedRoute){
    const id = route.snapshot.paramMap.get('id');

    if (id) {
      this.current = +id;
    }
  }

  choose(newCurrent:number){
    this.current=newCurrent;
  }
}
