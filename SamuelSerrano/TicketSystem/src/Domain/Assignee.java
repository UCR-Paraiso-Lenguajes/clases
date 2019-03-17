package Domain;

import java.util.logging.Level;
import java.util.logging.Logger;
/**
 * @author Samuel
 */
public class Assignee implements Runnable{
    
    private Ticket ticket;
    
    public Assignee(Ticket ticket) {
        this.ticket = ticket;
    }
    
    @Override
    public void run() {
        //obtenemos el nombre del hilo en ejecución
        String threadName = Thread.currentThread().getName();
        System.out.println("Ticket "+ticket.getName()+" en progreso.");
        synchronized(ticket){
            try {
                Thread.sleep(3000);
                ticket.notify();//notificamos a quien nos asigno el ticket que ya esta listo
            } catch (InterruptedException ex) {
                Logger.getLogger(Assignee.class.getName()).log(Level.SEVERE, null, ex);
            }
            System.out.println("El ticket "+ticket.getName()+" está listo");
        }
    }
}