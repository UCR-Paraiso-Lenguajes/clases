package cr.ac.ucr.ie.app.controllers.pages;

import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;

import cr.ac.ucr.ie.app.domain.Departamentos;
import cr.ac.ucr.ie.app.domain.Empleados;

@Controller
public class HomeController 
{
	private Departamentos deps = new Departamentos();
	private Empleados empleados = new Empleados();
	
	@RequestMapping("/")
	public String mensaje(ModelMap model) 
	{
		model.addAttribute("empleados", empleados.listar());
		
		return "empleados";
	}
	
	@RequestMapping("/insertarempleado")
	public String insertarEmpleado(ModelMap model) 
	{
		model.addAttribute("empleados", deps.Listar());
		
		return "empleados";
	}
	
}