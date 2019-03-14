package cr.ac.ucr.ie.app.controllers;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class TestController 
{
	
	@RequestMapping("/")
	public String home() 
	{
		return "Spring boot is working!";
	}
	
}