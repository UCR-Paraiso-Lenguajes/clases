package cr.ac.ucr.ie.app.domain;

import java.util.ArrayList;
import java.util.Iterator;

public class Departamentos
{	
	private ArrayList<Departamento> departamentos = new ArrayList<Departamento>();
	
	public Departamentos()
	{
		departamentos.add(new Departamento(1, "Recursos Humanos"));
		departamentos.add(new Departamento(2, "Registro"));
		departamentos.add(new Departamento(3, "Finanzas"));
	}
	
	public Iterator<Departamento> Listar()
	{
		return departamentos.iterator();		
	}
}
