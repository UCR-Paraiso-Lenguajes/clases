package Domain;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * @author Samuel
 */
public class Assigner implements Runnable{
    
    private Ticket ticket;
    
    public Assigner(Ticket ticket) {
        
        this.ticket = ticket;
        //tiket = new Ticket();
    }
    
    @Override
    public void run() {
        //obtenemos el nombre del hilo en ejecución
        String threadName = Thread.currentThread().getName();
        System.out.println("Ticket de "+ticket.getName()+" asignado. Esperando a qe lo resuelvan");
        synchronized(ticket){
            try{
                
                ticket.wait();
            } catch (InterruptedException ex) {
                Logger.getLogger(Assigner.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        System.out.println("El ticket "+ticket.getName()+" ha sido atendido por el asignado");
    }
}