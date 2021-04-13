package Practicas.Java.Practica2;

import java.awt.*;
import javax.swing.*;
//Clase contenedor en el que se crean las figuras, así como la definición de sus propiedades.
public class Contenedor extends JPanel {
    //Paraemtros propios de las dimensiones de las figura.
    private int x, y;
    private int w, h;
    private String figur;//Nombre de la figura que se va a crear.
    boolean isClicked;//Comprobador.

    public Contenedor() {
        x = y = 150;
        w = h = 150;//Constructor que inicializa las dimensiones de las figuras.
    }
    //Clase en la que se elige que figura es la que se va a crear.
    public void paintComponent(Graphics u) {
        super.paintComponent(u);
        try {//Según la figura que se seleccione se crea una u otra.
            switch (figur) {
                case "Circulo":
                    u.setColor(Color.black);
                    u.fillOval(x, y, w, h);
                    u.drawString("Has clic", x, y);
                    break;
                case "Cuadrado":
                   u.setColor(Color.blue);
                   u.fillRect(80, 60, w, h);
                   u.setColor(Color.black);
                   u.fillOval(x, y, (int)(w * 0.30), (int)(h * 0.30));
                    break;
                case "Rombo":
                    if(this.isClicked){
                    u.setColor(Color.blue);
                    u.fillRect(x, y, w, h);
                    u.setColor(Color.pink);
                    u.fillOval(x, y, w, h);
                    u.setColor(Color.black);
                    u.fillArc(x, y, w, h, 60, 90);
                    }else{   
                    u.setColor(Color.blue);
                    u.fillRect(80,60, w, h);
                    u.setColor(Color.pink);
                    u.fillOval(x, y, w, h);
                    u.setColor(Color.black);
                    u.fillArc(x, 10, w, h, 60, 90);
                    }
                    break;
            }
        } catch (Exception e) {
        }
    }
    //Metodos set y get en los que se definen y recuperan las propiedades de las figuras.
    public void update(Graphics g) {
        super.update(g);
        paintComponent(g);
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

    public Contenedor(LayoutManager layout) {
        super(layout);
    }

    public int getW() {
        return w;
    }

    public void setW(int w) {
        this.w = w;
    }

    public int getH() {
        return h;
    }

    public void setH(int h) {
        this.h = h;
    }

    public String getIsFigura() {
        return figur;
    }
    //Se define la figura a dibujar.
    public void setIsFigura(String Figura) {
        this.figur = Figura;
    }

    public boolean isClicked() {
        return isClicked;
    }
    //Cambia el estado del click.
    public void setClicked() {
        this.isClicked = !this.isClicked;
    }
}