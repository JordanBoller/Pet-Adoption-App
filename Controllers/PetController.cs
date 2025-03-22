using midterm_project.Repositories;
using midterm_project.Models;
using Microsoft.AspNetCore.Mvc;


namespace midterm_project.Controllers;

public class PetController : Controller
{
    private readonly ILogger<PetController> _logger;
    private readonly IPetRepository _petRepository;

    public PetController(ILogger<PetController> logger, IPetRepository repository)
    {
        _logger = logger;
        _petRepository = repository;
    }

    public IActionResult List()
    {
        return View(_petRepository.GetAllPets());
    }
    [HttpGet]
    public IActionResult Detail(int id) 
    {
        var pet = _petRepository.GetPetById(id);

        if (pet == null) {
            return RedirectToAction("List");
        }

        return View(pet);
    }

    [HttpPost]
    public IActionResult Detail(Pet pet) 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        _petRepository.UpdatePet(pet);
        
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Add() 
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Pet pet) 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        _petRepository.CreatePet(pet);

        return RedirectToAction("List");
    }

    public IActionResult Delete(int id) 
    {
        _petRepository.DeletePetById(id);
        
        return RedirectToAction("List");
    }
}