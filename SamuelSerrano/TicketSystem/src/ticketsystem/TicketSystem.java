package ticketsystem;

import Domain.Assignee;
import Domain.Assigner;
import Domain.Ticket;

/**
 *
 * @author Samuel
 */
public class TicketSystem {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Ticket ticket1 = new Ticket(1, "Orden de papas de Esteban");
        Assigner assigner1 = new Assigner(ticket1);
        new Thread(assigner1,"cajero #1").start();
        
        Ticket ticket2 = new Ticket(2, "Orden de haburguesa con papas de Samuel");
        Assigner assigner2 = new Assigner(ticket2);
        new Thread(assigner2,"cajero #2").start();
        
        Assignee assignee1 = new Assignee(ticket1);
        new Thread(assignee1, "asignado #1").start();
        Assignee assignee2 = new Assignee(ticket2);
        new Thread(assignee2, "asignado #2").start();
    }
}