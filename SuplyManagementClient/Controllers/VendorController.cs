using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers;

public class VendorController : Controller
{
    public VendorController()
    {
    }

    [AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    public IActionResult Create()
    {
        return View();
    }

    [Route("/Event/D/{slug}")]
    [AllowAnonymous]
    public IActionResult DetailEvent()
    {
        return View();
    }

    [Authorize(Roles = "Event Organizer")]
    public IActionResult Manage()
    {
        return View();
    }

    [Authorize(Roles = "Event Organizer")]
    public IActionResult Dashboard()
    {
        return View();
    }

    [Authorize(Roles = "Event Organizer")]
    public IActionResult Order()
    {
        return View();
    }

    [Authorize(Roles = "Event Organizer")]
    public IActionResult OrderTicket()
    {
        return View();
    }

    [Authorize(Roles = "Event Organizer")]
    public IActionResult Revenue()
    {
        return View();
    }

    [Authorize(Roles = "Admin")]
    public IActionResult List()
    {
        return View();
    }

    [Route("/Event/Detail/{id}")]
    public IActionResult Detail()
    {
        return View();
    }

    [Route("/Event/Attendees/{id}")]
    public IActionResult Attendee()
	{
		return View();
	}
}
