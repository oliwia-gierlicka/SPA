import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { FitnessComponent } from './pages/fitness/fitness.component';
import { ProductsComponent } from './pages/products/products.component';
import { SignInComponent } from './pages/sign-in/sign-in.component';
import { HomeUserComponent } from './pages/home-user/home-user.component';
import { MakeReservationComponent } from './pages/make-reservation/make-reservation.component';
import { CartComponent } from './pages/cart/cart.component';
import { VisitsComponent } from './pages/visits/visits.component';
import { OrdersComponent } from './pages/orders/orders.component';
import { HomeEmployeeComponent } from './pages/home-employee/home-employee.component';
import { authGuard } from './guards/auth.guard';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'service/:id',
    component: FitnessComponent
  },
  {
    path: 'products',
    component: ProductsComponent
  },
  {
    path: 'sign-in',
    component: SignInComponent
  },
  {
    path: 'cart',
    component: CartComponent,
    canActivate: [authGuard]
  },
  {
    path: 'orders',
    component: OrdersComponent,
    canActivate: [authGuard]
  },
  {
    path: 'visits',
    component: VisitsComponent,
    canActivate: [authGuard]
  },
  {
    path: 'home-user',
    component: HomeUserComponent,
    canActivate: [authGuard]
  },
  {
    path: 'home-employee',
    component: HomeEmployeeComponent,
    canActivate: [authGuard]
  },
  {
    path: 'make-reservation',
    component: MakeReservationComponent,
    canActivate: [authGuard]
  },
  {
    path: '**',
    component: HomeComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
