import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductTabItemComponent } from './product-tab-item.component';

describe('ProductTabItemComponent', () => {
  let component: ProductTabItemComponent;
  let fixture: ComponentFixture<ProductTabItemComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProductTabItemComponent]
    });
    fixture = TestBed.createComponent(ProductTabItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
