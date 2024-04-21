import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';

export const authGuard: CanActivateFn = (route, state) => {
  const router = inject(Router);
  const isLogged = !!sessionStorage.getItem('token');

  if (isLogged)
    return true;

  router.navigateByUrl('/sign-in');
  return false;
};
