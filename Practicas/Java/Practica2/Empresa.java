package Practicas.Java.Practica2;

import java.awt.*;
import java.awt.event.*;//Importanciónde los paquetes necesarios para la ventana así como para
import javax.swing.*;//los elementos de este

public class Empresa extends JFrame {
    //Clase princial en la que se inicializan todos los datos que tendrá la ventana
    private static final long serialVersionUID = 1L;

        //Variables a usar
        JButton fig1;
        JButton fig2;//Se cean las figuras solicitadas en la practica.
        JButton fig3;
        JPanel  Boton;//Boton para la selección de 
        Contenedor ventafig; //Objeto para la creación de las figuras.
        JPanel options;
        int cont = 0;
    //Constructor que inicializa los componentes de la ventana.
    public Empresa() {
        initComponents();
    }
    //Método en el que se definen cada uno de los componentes 
    public void initComponents() {

        this.setLayout(new BorderLayout());
        this.addKeyListener(new KeyAdapter() {
            public void keyPressed(KeyEvent e) {
                paintContainerKeyPressed(e);
            }
        });
        //Configuración de los botones con sus propiedades.
        fig1 = new JButton("Circulo (a)");
        fig1.setFocusable(false);
        fig1.setFont(new Font("Arial", 10, 20));
        fig1.addActionListener(e -> CirculoActionPerformed(e));
        
        fig2 = new JButton("Cuadrado (s)");
        fig2.setFocusable(false);
        fig2.setFont(new Font("Arial", 10, 20));
        fig2.addActionListener(e -> CuadradoActionPerformed(e));

        fig3 = new JButton("Rombo (d)");
        fig3.setFocusable(false);
        fig3.setFont(new Font("Arial", 10, 20));
        fig3.addActionListener(e -> RomboActionPerformed(e));
        //Se añaden los botones al Panel para que aparezcan en la ventana.
        Boton = new JPanel();
        Boton.setBackground(new Color(216, 241, 255));
        Boton.add(fig1);
        Boton.add(fig2);
        Boton.add(fig3);
        //Creación del panel en el que estarán las figuras.
        options = new JPanel();
        options.setPreferredSize(new Dimension(90, 400));
        options.setBackground(new Color(216, 241, 255));
        //En esta parte se le añaden los listeners a los diversos componentes para aplicarles funciones.
        ventafig = new Contenedor();
        ventafig.addMouseListener(new MouseAdapter() {
            public void mouseClicked(MouseEvent e) {
                paintContainerMouseClicked(e);
            }//Por si se hace click.
        });
        ventafig.addMouseMotionListener(new MouseMotionAdapter() {
            public void mouseDragged(MouseEvent e) {
                paintContainerMouseDragged(e);
            }//Por si se arrastra el mouse.
        });
        ventafig.addKeyListener(new KeyAdapter() {
            public void keyPressed(KeyEvent e) {
                paintContainerKeyPressed(e);
            }//Por si se presiona alguna tecla.
        });

        this.add(Boton, BorderLayout.SOUTH);
        this.add(ventafig, BorderLayout.CENTER);

        //Se inicializan las propiedades de la ventana.
        this.setSize(500, 500);
        this.setLocationRelativeTo(null);
        this.setVisible(true);

    }
    
    public void reiniciar(){
        cont = 0;
        } 
    //Métodos que le dan función a los botones
    private void CirculoActionPerformed(ActionEvent e) {
        ventafig.setIsFigura("Circulo");
        //Al presionar el botón de circulo se manda el dato circulo a la clase contenedor 
    }// y esta cea la figura correspondiente, así pasa con las otra dos figuras.
    private void CuadradoActionPerformed(ActionEvent e) {
        ventafig.setIsFigura("Cuadrado");
        JOptionPane.showMessageDialog(null, "Cuadrado");
    }
    
    private void RomboActionPerformed(ActionEvent e) {
        ventafig.setIsFigura("Rombo");
        JOptionPane.showMessageDialog(null, "Rombo");
    }
    //Método cambia el estado del click sobre la figura.
    private void paintContainerMouseClicked(MouseEvent e) {
        ventafig.setClicked();
        ventafig.repaint();
    }
    //Método que permite arrastrar la figura.
    private void paintContainerMouseDragged(MouseEvent e) {
        if (!ventafig.isClicked()) {
            ventafig.setX(e.getX());
            ventafig.setY(e.getY());
        }else{
            ventafig.setW(e.getX());
            ventafig.setH(e.getY());
            }
            ventafig.repaint();
        }
    //Método que periten hacer que los botones puedan ser presionados con teclas establecidas.
    private void paintContainerKeyPressed(KeyEvent e) {
        if (!ventafig.isClicked()) {
            switch (e.getKeyCode()) {
                case 'a':
                case 'A':
                    fig1.doClick();
                    break;
                case 's':
                case 'S':
                    fig2.doClick();
                    break;
                case 'd':
                case 'D':
                    fig3.doClick();
                    break;
                default:
                    break;
            }
        }
    }

}