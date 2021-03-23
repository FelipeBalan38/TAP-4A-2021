package Ejercicios.Ejercicio8;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.swing.JOptionPane;

public class Nota extends Frame implements ActionListener{

    /**
     *
     */
    private static final long serialVersionUID = 1L;
    public Nota() {
        initComponents();
    }

    public void initComponents() {
        this.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });
        panel_superior = new Panel();
        panel_central = new Panel();
        panel_inferior = new Panel();
        panel_central.setLayout(new BorderLayout());
        panel_superior.setLayout(new FlowLayout());
        panel_inferior.setLayout(new BorderLayout());
        btn_color = new Button("Color");
        btn_comilla = new Button("Comillas");
        btn_size = new Button("Tamaño");
        btn_open = new Button("Abrir");
        btn_save = new Button("Guardar");
        btn_exit = new Button("Salir");
        txt_out = new TextArea();
        txt_state = new TextArea();
        btn_color.addActionListener(this);
        btn_comilla.addActionListener(this);
        btn_size.addActionListener(this);
        btn_open.addActionListener(this);
        btn_save.addActionListener(this);
        btn_exit.addActionListener(this);
        this.setLayout(new BorderLayout());
        panel_superior.add(btn_color, null);
        panel_superior.add(btn_comilla, null);
        panel_superior.add(btn_size, null);
        panel_superior.add(btn_open, null);
        panel_superior.add(btn_save, null);
        panel_superior.add(btn_exit, null);
        panel_central.add(txt_out, BorderLayout.CENTER);
        panel_inferior.add(txt_state, BorderLayout.SOUTH);
        this.add(panel_superior, BorderLayout.NORTH);
        this.add(panel_inferior, BorderLayout.SOUTH);
        this.add(panel_central, BorderLayout.CENTER);
        this.setSize(500,600);
        this.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent arg0) {
        if (arg0.getSource() == btn_color) {
            int clr = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el número del color al que desea cambiar:\n"+
                                                                    "1. Azul \n"+
                                                                    "2. Verde \n"+
                                                                    "3. Amarillo \n"+
                                                                    "4. Rojo \n"+
                                                                    "5. Naranja \n"+
                                                                    "6. Salir \n"));
            color(clr);
            txt_state.append("");
            txt_state.append("Se cambio el color del texto\n");
        }
        if (arg0.getSource() == btn_comilla) {
            String texto, divi;
            texto=txt_out.getText();
            divi=(txt_out.getSelectedText());
            txt_out.setText(texto.split(divi)[0]+"'"+"'"+divi+"'"+"'"+texto.split(divi)[1]);
            txt_state.append("");
            txt_state.append("Se le pusieron comillas al texto\n");
        }
        if (arg0.getSource() == btn_size) {
            int tmñ = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el número de tamaño que le quiere dar al texto:\n"));
            tamaño(tmñ);
            txt_state.append("");
            txt_state.append("Se le cambio el tamaño al texto\n");
        }
        if (arg0.getSource() == btn_open) {
            String name = JOptionPane.showInputDialog("Ingrese el nombre del archivo que desea abrir:\n");
            abrir(name);
            txt_state.append("");
            txt_state.append("Se abrió un archivo guardado\n");
        }
        if (arg0.getSource() == btn_save) {
            String name = JOptionPane.showInputDialog("Ingrese el nombre del archivo a guardar:\n");
            guardar(name);
            txt_state.append("");
            txt_state.append("Se guardó el archivo\n");
        }
        if (arg0.getSource() == btn_exit) {
            txt_state.append("");
            txt_state.append("Saliendo\n");
            this.setVisible(false);
        }
        
    }
    public void color(int s){
        if(s==1){
            txt_out.setForeground(Color.BLUE);
        }
        else if(s==2){
            txt_out.setForeground(Color.GREEN);
        }
        else if(s==3){
            txt_out.setForeground(Color.YELLOW);
        }
        else if(s==4){
            txt_out.setForeground(Color.RED);
        }
        else if(s==5){
            txt_out.setForeground(Color.ORANGE);
        }
        else{
            JOptionPane.showMessageDialog(null,"No seleccionó ningún color");
        }
    }
    public void tamaño(int j){
            txt_out.setFont(new Font("", Font.BOLD,j));
    }
    public void guardar (String nombre){
        FileWriter fichero = null;
        PrintWriter pw = null;
        try
        {
            fichero = new FileWriter("D:/980016451/Documents/Cuarto semestre/Topicos avanz. de programación/PruebaNota/"+nombre+".txt");
            pw = new PrintWriter(fichero);
            pw.println(txt_out.getText());

        } catch (Exception e) {
            e.printStackTrace();
        } finally {
           try {
           if (null != fichero)
              fichero.close();
           } catch (Exception e2) {
              e2.printStackTrace();
           }
        }
    }
    public void abrir(String nombre){
        File archivo = null;
        FileReader fr = null;
        BufferedReader br = null;

      try {
         archivo = new File ("D:\\980016451\\Documents\\Cuarto semestre\\Topicos avanz. de programación\\PruebaNota\\"+nombre+".txt");
         fr = new FileReader (archivo);
         br = new BufferedReader(fr);

         String linea;
         while((linea=br.readLine())!=null)
            txt_out.append(linea+"\n");
      }
      catch(Exception e){
         e.printStackTrace();
      }finally{

         try{                    
            if( null != fr ){   
               fr.close();     
            }                  
         }catch (Exception e2){ 
            e2.printStackTrace();
         }
      }
    }

    private TextArea txt_out;
    private TextArea txt_state;
    private Button btn_color;
    private Button btn_comilla;
    private Button btn_size;
    private Button btn_open;
    private Button btn_save;
    private Button btn_exit;
    private Panel panel_central;
    private Panel panel_superior;
    private Panel panel_inferior;


    public static void main (String args []){
        Nota n = new Nota();
    }
    
}