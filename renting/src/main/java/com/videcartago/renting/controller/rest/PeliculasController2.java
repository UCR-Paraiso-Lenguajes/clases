package com.videcartago.renting.controller.rest;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;
import com.videcartago.renting.business.PeliculaBusiness;
import com.videcartago.renting.domain.Pelicula;

@RestController
public class PeliculasController2 {

	@Autowired
	private PeliculaBusiness peliculaBusiness;
	
	@RequestMapping(value="/api/peliculas", method=RequestMethod.GET )
	public @ResponseBody List<Pelicula> listarPeliculas2(
			@RequestParam(value="title", defaultValue="the") String title,
			@RequestParam(value="gender", defaultValue="suspenso") String gender)
	{
		return peliculaBusiness.findAllMoviesByTitleAndGender(title, gender);
	}

	@RequestMapping(value="/api/pelicula", method=RequestMethod.POST )
	public @ResponseBody Pelicula insertarPelicula(@RequestBody Pelicula pelicula)
	{
	
		pelicula = peliculaBusiness.save(pelicula);
		
		return pelicula;
	}	

}

