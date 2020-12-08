import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AppComponent } from 'src/app/app.component';
import { DetailProject } from 'src/app/models/DetailProject';
import { DetailWorkService } from 'src/app/services/detail-work/detail-work.service';

@Component({
  selector: 'work-detail',
  templateUrl: './detail-work.component.html',
  styleUrls: ['./detail-work.component.css']
})
export class DetailWorkComponent implements OnInit {

  idProjeto:any;
  dataProjeto:any;
  
  constructor(private route: ActivatedRoute , private principal:AppComponent ,private serviceDetail:DetailWorkService , private routerLink:Router ) {
      this.idProjeto = this.route.snapshot.paramMap.get('idWork');
       this.serviceDetail.getDataDetailWork(this.idProjeto).subscribe(
         r => {
           this.dataProjeto = r;
           console.log(this.dataProjeto);
         },
         error => {
           routerLink.navigate(['404']);
          console.log(error);
         });
      
      //console.log(this.idProjeto);
      principal.scrollToTop();
   }

  ngOnInit(): void {
  }

}
