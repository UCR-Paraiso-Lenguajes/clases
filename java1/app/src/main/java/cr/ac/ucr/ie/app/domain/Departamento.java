package cr.ac.ucr.ie.app.domain;

import java.util.List;

public class Departamento
{	
	private Empleados empleados = new Empleados();
	private int id;
	private String nombre;
	
	public Departamento(int id, String nombre)
	{
		if(id <= 0) throw new RuntimeException("El id debe ser mayor a 0.");
		if(nombre != null && nombre.trim().equals("")) throw new RuntimeException("El nombre es requerido");
		
		this.id = id;
		this.nombre = nombre;
	}
	
	public void ResgistrarEmpleado(Empleado empleado)
	{
		empleados.Agregar(empleado);
	}
	
	public List<Empleado> listarEmpleados()
	{
		return empleados.listar();
	}
}
