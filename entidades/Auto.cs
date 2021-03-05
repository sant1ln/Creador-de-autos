namespace autos.entidades
{
    class Auto
    {

        public Auto(string Linea, int Modelo,int Cilindraje,TipoAuto tipoAuto,
        Transmiciones tipoTransmicion)
        {
            this.Linea = Linea;
            this.Modelo = Modelo;
            this.Cilindraje = Cilindraje;
            this.tipoAuto = tipoAuto;
            this.TipoTransmicion = tipoTransmicion;
        }

        string linea;
        int modelo;
        int cilindraje;
        TipoAuto categoria;
        Transmiciones tipoTransmicion;
        public string Linea
        {
            get{return linea;}
            set{linea = value;}
        }
        public int Modelo
        {
            get{return modelo;}
            set{modelo = value;}
        }
        public int Cilindraje
        {
            get{return cilindraje;}
            set{cilindraje = value;}
        }
        public TipoAuto tipoAuto
        {
            get {return categoria;}
            set{categoria = value;}
        }
        public Transmiciones TipoTransmicion {
             get {return tipoTransmicion;} 
             set {tipoTransmicion = value; }
        }
    }


}