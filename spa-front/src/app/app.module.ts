import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { WelcomeSectionComponent } from './components/welcome-section/welcome-section.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { TransparentButtonComponent } from './components/transparent-button/transparent-button.component';
import { AboutComponent } from './components/about/about.component';
import { ServicesComponent } from './components/services/services.component';
import { ServiceItemComponent } from './components/service-item/service-item.component';
import { ProductsSectionComponent } from './components/products/products.component';
import { ReviewsComponent } from './components/reviews/reviews.component';
import { ReviewItemComponent } from './components/review-item/review-item.component';
import { ContactComponent } from './components/contact/contact.component';
import { BackComponent } from './components/back/back.component';
import { FitnessComponent } from './pages/fitness/fitness.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { TabItemComponent } from './components/tab-item/tab-item.component';
import { ProductsComponent } from './pages/products/products.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { SignInComponent } from './pages/sign-in/sign-in.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { JwtInterceptor } from './interceptor/jwt.interceptor';
import { HomeUserComponent } from './pages/home-user/home-user.component';
import { NavbarUserComponent } from './components/navbar-user/navbar-user.component';
import { ButtonComponent } from './components/button/button.component';
import { MakeReservationComponent } from './pages/make-reservation/make-reservation.component';
import { ProductTabItemComponent } from './components/product-tab-item/product-tab-item.component';
import { CartComponent } from './pages/cart/cart.component';
import { VisitsComponent } from './pages/visits/visits.component';
import { OrdersComponent } from './pages/orders/orders.component';
import { HomeEmployeeComponent } from './pages/home-employee/home-employee.component';
import { NavbarEmployeeComponent } from './components/navbar-employee/navbar-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    WelcomeSectionComponent,
    NavbarComponent,
    TransparentButtonComponent,
    AboutComponent,
    ServicesComponent,
    ServiceItemComponent,
    ProductsSectionComponent,
    ReviewsComponent,
    ReviewItemComponent,
    ContactComponent,
    BackComponent,
    FitnessComponent,
    TabsComponent,
    TabItemComponent,
    ProductsComponent,
    SignInComponent,
    HomeUserComponent,
    NavbarUserComponent,
    ButtonComponent,
    MakeReservationComponent,
    ProductTabItemComponent,
    CartComponent,
    VisitsComponent,
    OrdersComponent,
    HomeEmployeeComponent,
    NavbarEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule 
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
