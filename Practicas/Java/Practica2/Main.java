package Practicas.Java.Practica2;

import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class Main {
    
    public static void main( String args[] ) 
    {
        //Main que llama a la clase empresa para poder ejecutar el programa
        Empresa x = new Empresa();
        x.setBounds(405,450,570,406);
        x.setLocationRelativeTo(null);
        x.setTitle("Practica2");
        x.setDefaultCloseOperation(EXIT_ON_CLOSE);
        x.setVisible(true);
        //Se definen las propiedades de la ventana que se crea
    }//Como su nombre, tamaño, entre otras cosas
}