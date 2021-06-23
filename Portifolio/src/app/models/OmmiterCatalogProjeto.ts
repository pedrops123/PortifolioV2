import { CatalogProjeto } from "./CatalogProjeto";

export abstract class OmmiterCatalogProjeto {

   static getCreate(){
        let tipoCreate:CatalogProjeto;
        return tipoCreate;
    }


    static getUpdate(){
        type obj_create = Omit<CatalogProjeto, "ListaFotos">;
        let tipoCreate:obj_create;
        return tipoCreate;
    }

}