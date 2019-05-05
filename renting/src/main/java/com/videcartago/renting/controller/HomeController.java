package com.videcartago.renting.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
public class HomeController {

	@RequestMapping(value="/", method=RequestMethod.GET)
	public String root(){
		return "helloworld";
	}
	
	@RequestMapping(value="/home", method=RequestMethod.GET)
	public String home(){
		return "helloworld";
	}
	
	@RequestMapping(value="/adminHome", method=RequestMethod.GET)
	public String adminHome(){
		return "adminHome";
	}
	
	
	@RequestMapping(value="/login", method=RequestMethod.GET)
	public String login(){
		return "login";
	}
}

