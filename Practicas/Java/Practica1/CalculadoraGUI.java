package Practicas.Java.Practica1;

import java.awt.*;
import java.awt.event.*;

public class CalculadoraGUI extends Frame implements ActionListener {

    /**
     *
     */
    private static final long serialVersionUID = 1L;
    
    private TextField txt_in;
    private Button btn_0;
    private Button btn_1;
    private Button btn_2;
    private Button btn_3;
    private Button btn_4;
    private Button btn_5;
    private Button btn_6;
    private Button btn_7;
    private Button btn_8;
    private Button btn_9;
    private Button btn_suma;
    private Button btn_resta;
    private Button btn_multi;
    private Button btn_div;
    private Button btn_cuadrado;
    private Button btn_igual;
    private Label lbl_c1;
    private Label lbl_c2;
    private Label lbl_c3;
    private Label lbl_op;
    private Panel panel_central;
    private Panel panel_superior;
    private int dat1;
    private int dat2;
    private String op;
    private Operaciones ope;

    public CalculadoraGUI(String nombre) {
        super(nombre);
        initComponents();
    }

    public void initComponents() {
        this.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });
        ope = new Operaciones();
        panel_superior = new Panel();
        panel_central = new Panel();
        panel_superior.setLayout(new GridLayout());
        panel_central.setLayout(new GridLayout());
        btn_0 = new Button ("0");
        btn_0.addActionListener(this);
        btn_1 = new Button ("1");
        btn_1.addActionListener(this);
        btn_2 = new Button ("2");
        btn_2.addActionListener(this);
        btn_3 = new Button ("3");
        btn_3.addActionListener(this);
        btn_4 = new Button ("4");
        btn_4.addActionListener(this);
        btn_5 = new Button ("5");
        btn_5.addActionListener(this);
        btn_6 = new Button ("6");
        btn_6.addActionListener(this);
        btn_7 = new Button ("7");
        btn_7.addActionListener(this);
        btn_8 = new Button ("8");
        btn_8.addActionListener(this);
        btn_9 = new Button ("9");
        btn_9.addActionListener(this);
        btn_suma = new Button ("+");
        btn_suma.addActionListener(this);
        btn_resta = new Button ("-");
        btn_resta.addActionListener(this);
        btn_multi = new Button ("*");
        btn_multi.addActionListener(this);
        btn_div = new Button ("/");
        btn_div.addActionListener(this);
        btn_cuadrado = new Button ("^");
        btn_cuadrado.addActionListener(this);
        btn_igual = new Button ("=");
        btn_igual.addActionListener(this);
        lbl_c1 = new Label ("C1");
        lbl_c2 = new Label ("C2");
        lbl_c3 = new Label ("C3");
        lbl_op = new Label ("Op");
        txt_in = new TextField();
        txt_in.setForeground(Color.GRAY);
        txt_in.setText("0123456789");
        panel_superior.setLayout(new GridLayout(1,1));
        panel_superior.add(txt_in, 0,0);
        panel_central.setLayout(new GridLayout(5,4));
        panel_central.add(lbl_c1);
        panel_central.add(lbl_c2);
        panel_central.add(lbl_c3);
        panel_central.add(lbl_op);
        panel_central.add(btn_1);
        panel_central.add(btn_2);
        panel_central.add(btn_3);
        panel_central.add(btn_suma);
        panel_central.add(btn_4);
        panel_central.add(btn_5);
        panel_central.add(btn_6);
        panel_central.add(btn_resta);
        panel_central.add(btn_7);
        panel_central.add(btn_8);
        panel_central.add(btn_9);
        panel_central.add(btn_div);
        panel_central.add(btn_multi);
        panel_central.add(btn_0);
        panel_central.add(btn_cuadrado);
        panel_central.add(btn_igual);
        this.setLayout(new BorderLayout());
        this.add(panel_superior, BorderLayout.NORTH);
        this.add(panel_central, BorderLayout.CENTER);
        this.setSize(500,400);
        this.setResizable(false);
        this.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent arg0) {
        if (arg0.getSource() == btn_0){
            txt_in.setText(txt_in.getText() + "0");
        }
        if (arg0.getSource() == btn_1){
            txt_in.setText(txt_in.getText() + "1");
        }
        if (arg0.getSource() == btn_2){
            txt_in.setText(txt_in.getText() + "2");
        }
        if (arg0.getSource() == btn_3){
            txt_in.setText(txt_in.getText() + "3");
        }
        if (arg0.getSource() == btn_4){
            txt_in.setText(txt_in.getText() + "4");
        }
        if (arg0.getSource() == btn_5){
            txt_in.setText(txt_in.getText() + "5");
        }
        if (arg0.getSource() == btn_6){
            txt_in.setText(txt_in.getText() + "6");
        }
        if (arg0.getSource() == btn_7){
            txt_in.setText(txt_in.getText() + "7");
        }
        if (arg0.getSource() == btn_8){
            txt_in.setText(txt_in.getText() + "8");
        }
        if (arg0.getSource() == btn_9){
            txt_in.setText(txt_in.getText() + "9");
        }
        if (arg0.getSource() == btn_suma){
            String nose = txt_in.getText();
            if(isNumber(nose)){
                dat1=Integer.parseInt(nose);
                op = "+";
                txt_in.setText("");
            }
            else
            txt_in.setText("Por favor ingresa solo números");
        }
        if (arg0.getSource() == btn_resta){
            String nose = txt_in.getText();
            if(isNumber(nose)){
                dat1=Integer.parseInt(nose);
                op = "-";
                txt_in.setText("");
            }
            else
            txt_in.setText("Por favor ingresa solo números");
        }
        if (arg0.getSource() == btn_multi){
            String nose = txt_in.getText();
            if(isNumber(nose)){
                dat1=Integer.parseInt(nose);
                op = "*";
                txt_in.setText("");
            }
            else
            txt_in.setText("Por favor ingresa solo números");
        }
        if (arg0.getSource() == btn_div){
            String nose = txt_in.getText();
            if(isNumber(nose)){
                dat1=Integer.parseInt(nose);
                op = "/";
                txt_in.setText("");
            }
            else
            txt_in.setText("Por favor ingresa solo números");
        }
        if (arg0.getSource() == btn_cuadrado){
            String nose = txt_in.getText();
            if(isNumber(nose)){
                dat1=Integer.parseInt(nose);
                op = "^";
                txt_in.setText("");
            }
            else
            txt_in.setText("Por favor ingresa solo números");
        }
        if (arg0.getSource() == btn_igual){
            String nose = txt_in.getText();
            if(isNumber(nose)){
                dat2=Integer.parseInt(nose);
                txt_in.setText(ope.Operac(dat1, dat2, op));
            }
            else
            txt_in.setText("Por favor ingresa solo números");
        }
    }

    public static boolean isNumber(String cadena) {

        boolean resultado;
        try {
            Integer.parseInt(cadena);
            resultado = true;
        } catch (NumberFormatException excepcion) {
            resultado = false;
        }
        return resultado;
    }
    public static void main(String args []){
        CalculadoraGUI c = new CalculadoraGUI("Calculadora simple");
    }
    
}