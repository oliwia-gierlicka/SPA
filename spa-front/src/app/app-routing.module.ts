import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { FitnessComponent } from './pages/fitness/fitness.component';
import { ProductsComponent } from './pages/products/products.component';

const routes: Routes = [
  {
    path:'',
    component:HomeComponent
  },
  {
    path:'service/:id',
    component:FitnessComponent
  },

  {
    path:'products',
    component:ProductsComponent
  },
  {
    path:'**',
    component:HomeComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
