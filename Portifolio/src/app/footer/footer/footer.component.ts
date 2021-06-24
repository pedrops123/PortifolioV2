import { Component, OnInit } from '@angular/core';
import { GeneralParametersService } from 'src/app/services/GeneralParameters/general-parameters.service';

@Component({
  selector: 'footerApp',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  constructor(public parametrosGeraisService:GeneralParametersService) { }

  ngOnInit(): void {
  }


  getActualDate(){
    return new Date().getFullYear().toString();    
  }

}
