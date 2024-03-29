package Ejercicios.Ejercicio8;
import java.awt.Frame;
import java.awt.event.*;

public class Pantalla extends Frame implements MouseListener, MouseMotionListener, KeyListener {

    /**
     *
     */
    private static final long serialVersionUID = 1L;
    private Contenedor obj_pintable;

    public Pantalla() {
        initComponents();
    }

    public void initComponents() {
        this.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });
        obj_pintable = new Contenedor();
        obj_pintable.addMouseListener(this);
        obj_pintable.addMouseMotionListener(this);
        obj_pintable.addKeyListener(this);
        this.addKeyListener(this);
        this.add(obj_pintable);

        this.setSize(1024,500);
        this.setVisible(true);
    }

    public static void main(String args[]) {
        Pantalla p = new Pantalla();
    }

    @Override
    public void mouseClicked(MouseEvent arg0) {
        System.out.println("Clicked");
        if (obj_pintable.isClicked()) {
            obj_pintable.setW(arg0.getX());
            obj_pintable.setH(arg0.getY());
            obj_pintable.repaint();
        } else {
            obj_pintable.setX(arg0.getX());
            obj_pintable.setY(arg0.getY());
        }
        obj_pintable.setClicked();
        
        
    }

    @Override
    public void mouseEntered(MouseEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Entrando");
    }

    @Override
    public void mouseExited(MouseEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Saliendo");
    }

    @Override
    public void mousePressed(MouseEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Presionado");
    }

    @Override
    public void mouseReleased(MouseEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Liberado");
    }

    @Override
    public void mouseDragged(MouseEvent arg0) {
        if(!obj_pintable.isClicked()) {
            obj_pintable.setX(arg0.getX());
            obj_pintable.setY(arg0.getY());
            
            obj_pintable.repaint();
        }
        
    }

    @Override
    public void mouseMoved(MouseEvent arg0) {
        System.out.println("Mover");
    }

    @Override
    public void keyPressed(KeyEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Presionando " + arg0.getKeyChar());
        if (!obj_pintable.isClicked()) {
            switch(arg0.getKeyChar()) {
                case 'd':
                case 'D':
                    obj_pintable.setX(obj_pintable.getX() + 1);
                    obj_pintable.tick();
                    break;
                case 'a':
                case 'A':
                    obj_pintable.setX(obj_pintable.getX() - 1);
                    obj_pintable.tick();
                    break;
                case 'w':
                case 'W':
                    obj_pintable.setY(obj_pintable.getY() - 1);

                    break;
                case 's':
                case 'S':
                    obj_pintable.setY(obj_pintable.getY() + 1);
                    break;

            }
            obj_pintable.repaint();
        }
    }

    @Override
    public void keyReleased(KeyEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Liberando " + arg0.getKeyChar());
    }

    @Override
    public void keyTyped(KeyEvent arg0) {
        // TODO Auto-generated method stub
        System.out.println("Tecleada: " + arg0.getKeyChar());
    }
    
}