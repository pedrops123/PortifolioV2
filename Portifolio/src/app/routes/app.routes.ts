import { ModuleWithProviders } from '@angular/core';
import { RouterModule, Routes } from "@angular/router";
import { BaseLayoutComponent } from '../components/base-layout/base-layout.component';
import { SiteLayoutComponent } from '../components/site-layout/site-layout.component';

import { ContactComponent } from '../pages/contact/contact.component';
import { DetailWorkComponent } from '../pages/detail-work/detail-work.component';
import { InitialComponent } from '../pages/initial/initial.component';
import { LoginComponent } from '../pages/login/login.component';
import { NotFoundComponent } from '../pages/not-found/not-found.component';
import { WorksComponent } from '../pages/works/works.component';

const APP_ROTAS : Routes = [
    { path: '', redirectTo: 'inicio', pathMatch: 'full' },
    {
        path:'',
        component:BaseLayoutComponent,
        children:[
            {
                path:'login',
                component:LoginComponent
            }
        ]
    },
    {
        path:'',
        children:[
            {
                path:'inicio',
                component:InitialComponent
            },
            {
                path:'work',
                component:WorksComponent
            },
            {
                path:'contact',
                component:ContactComponent
            },
            {
                path:'detail/:idWork' ,
                component:DetailWorkComponent
            },
            {
                path:'404',
                component:NotFoundComponent
            }
        ]
    },
    {
        path:'**',
        redirectTo:'404'
    },
 
];

export const rotaApp:ModuleWithProviders<RouterModule> = RouterModule.forRoot(APP_ROTAS);