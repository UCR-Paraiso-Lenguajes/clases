package cr.ac.ucr.ie.app.domain;

public class Departamento
{	
	private int cod;
	private String nombre;
	
	public Departamento(int cod, String nombre)
	{
		if(cod <= 0) throw new RuntimeException("El id debe ser mayor a 0.");
		if(nombre != null && nombre.trim().equals("")) throw new RuntimeException("El nombre es requerido");
		
		this.cod = cod;
		this.nombre = nombre;
	}
	
}
