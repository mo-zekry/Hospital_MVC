using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
  public class BookAppointmentController : Controller
  {
    public IActionResult Index()
    {
      return View(new SampleDataDoctor().doctors);
    }


    public IActionResult Book(int doctorId)
    {
      var doctor = new SampleDataDoctor().doctors.Find(d => d.Id == doctorId);
      return View(doctor);
    }

    public IActionResult Booked(){
      return View();
    }

  }
}