using System;

namespace Interfaces {

    public static class Controlador{
        
        public static void testar(){
            Duck pato = new Duck();
            pato.display();
            Duck patomau = new MallarDuck();
            patomau.display();
            Duck patovermelho = new ReadHeadDuck();
            patovermelho.display();
        }
    }

}