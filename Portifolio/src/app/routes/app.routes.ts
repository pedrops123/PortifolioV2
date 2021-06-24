import { ModuleWithProviders } from '@angular/core';
import { RouterModule, Routes } from "@angular/router";
import { ContactComponent } from '../pages/contact/contact.component';
import { DetailWorkComponent } from '../pages/detail-work/detail-work.component';
import { InitialComponent } from '../pages/initial/initial.component';
import { LoginComponent } from '../pages/Manager/login/login.component';

import { NotFoundComponent } from '../pages/not-found/not-found.component';
import { WorksComponent } from '../pages/works/works.component';

const APP_ROTAS : Routes = [
    { path: '', redirectTo: 'inicio', pathMatch: 'full' },
    {
        path:'',
        children:[
            {
                path:'inicio',
                component:InitialComponent,
                data: { animation:'isLeft' }
            },
            {
                path:'work',
                component:WorksComponent,
                data: { animation:'isRight' }
            },
            {
                path:'contact',
                data: { animation:'isLeft' },
                component:ContactComponent
            },
            {
                path:'detail/:idWork' ,
                component:DetailWorkComponent
            },
            {
                path:'404',
                component:NotFoundComponent
            },
            {
                path:'login',
                component:LoginComponent
            }
        ]
    },
    {
        path:'**',
        redirectTo:'404'
    },
 
];

export const rotaApp:ModuleWithProviders<RouterModule> = RouterModule.forRoot(APP_ROTAS);