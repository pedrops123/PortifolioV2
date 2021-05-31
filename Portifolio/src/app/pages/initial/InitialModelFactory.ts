import { ModelInitialStacks } from "src/app/models/ModelInitialStacks";

export const dataArray:ModelInitialStacks[] = [
    {
        fotoStack:'../../../assets/stacks/angular.png',
        class: 'base-logo-stack img_angular stack-bottom',
        id:'img-angular',
        tooltip:true,
        tooltipType:'right',
        descriptionTooltip:`   <b>ANGULAR</b> <br/> 
                               <b>Experiência:</b> 2 anos <br/>  
                               <b>Atividades :</b> <br/>
                                  * Montagem de templates <br/>
                                  * Montagem da estrutura inicial <br/>
                                  * Criação de rotas <br/> 
                                  * NPM <br/>
                                  * Guards <br/>
                                  * Services 
                               `,
        active:false
      },
      {
        fotoStack:'../../../assets/stacks/dotnet.png',
        class: 'base-logo-stack img_dotnet stack-up',
        id:'img-dotnet',
        tooltip:true,
        tooltipType:'right',
        descriptionTooltip:`<b>.NET C# / .NET CORE </b> <br/> 
                            <b>Experiência:</b> 5 anos <br/>  
                            <b>Atividades :</b> <br/>
                            * Criação de API'S <br/>
                            * Criação de Controllers <br/>
                            * Criação de Controllers <br/>
                             `,
        active:false
      },
      {
        fotoStack:'../../../assets/foto_perfil/foto_perfil.jpg',
        class: 'img-foto',
        id:'',
        tooltip:false,
        tooltipType:'',
        descriptionTooltip:'',
        active:false
      },
      {
        fotoStack:'../../../assets/stacks/html5.png',
        class: 'base-logo-stack img_html stack-up',
        id:'img-html',
        tooltipType:'left',
        tooltip:true,
        descriptionTooltip:`<b> HTML </b> <br/> 
                            <b>Experiência:</b> 5 anos <br/>  
                            <b>Atividades :</b> <br/>
                            * Criação de Templates  <br/>  conforme modelo <br/>
                            * Bootstrap
                             `,
        active:false
      },
      {
        fotoStack:'../../../assets/stacks/css3.png',
        class: 'base-logo-stack img_css stack-bottom',
        id:'img-css',
        tooltipType:'left',
        tooltip:true,
        descriptionTooltip:`<b> CSS </b> <br/> 
                            <b>Experiência:</b> 5 anos <br/>  
                            <b>Atividades :</b> <br/>
                            * Flex Box <br/>
                            * Grid Layout <br/>
                             `,
        active:false
      }

];

