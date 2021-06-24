import { FotosProjeto } from "./FotosProjeto";

export class CatalogProjeto {
   id:Number;
   nome_projeto:String; 
   img_thumbnail:String;
   descritivo_capa:String; 
   texto_projeto:String; 
   ListaFotos:Array<FotosProjeto>;  
}