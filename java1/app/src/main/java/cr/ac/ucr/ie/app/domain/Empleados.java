package cr.ac.ucr.ie.app.domain;

import java.util.ArrayList;
import java.util.List;

public class Empleados {

	private ArrayList<Empleado> empleados = new ArrayList<Empleado>();
	
	public Empleados ()
	{
		Agregar(new Empleado(1, "Cristian"));
		Agregar(new Empleado(2, "Dave"));
		Agregar(new Empleado(3, "Cristian"));
		Agregar(new Empleado(4, "Carlos"));
	}

	public void Agregar(Empleado empleado)
	{
		if (empleados.contains(empleado) )throw new RuntimeException("El empleado ya existe");
		empleados.add(empleado);
	}

	public List<Empleado> listar()
	{
		return empleados;
	}
	
	
	
}
