using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Data;
using StudentPortal.Models;
using StudentPortal.Models.Entities;

namespace StudentPortal.Controllers
{
	public class StudentsController : Controller
	{
		private readonly ApplicationDbContext dbContext;

		public StudentsController(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddStudentViewModel viewModel)
		{
			var student = new Student
			{
				AdSoyad = viewModel.AdSoyad,
				Email = viewModel.Email,
				Telefon = viewModel.Telefon,
				DogumTarihi = viewModel.DogumTarihi,
				DogumYeri = viewModel.DogumYeri,
				Cinsiyet = viewModel.Cinsiyet,

				OkulAdi = viewModel.OkulAdi,
				OkulBaslangic = viewModel.OkulBaslangic,
				OkulBitis = viewModel.OkulBitis,
				OkulOrt = viewModel.OkulOrt,
			};

			await dbContext.Students.AddAsync(student);
			await dbContext.SaveChangesAsync();

			return View(viewModel);
		}

		[HttpGet]
		public async Task<IActionResult> List()
		{
			var students = await dbContext.Students.ToListAsync();
			return View(students);
		}

		[HttpGet]
		public async Task<IActionResult> Edit(Guid id)
		{
			var student = await dbContext.Students.FindAsync(id);

			return View(student);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(Student viewModel)
		{
			var student = await dbContext.Students.FindAsync(viewModel.Id);

			if (student is not null)
			{
				student.AdSoyad = viewModel.AdSoyad;
				student.Email = viewModel.Email;
				student.Telefon = viewModel.Telefon;
				student.DogumTarihi = viewModel.DogumTarihi;
				student.DogumYeri = viewModel.DogumYeri;
				student.Cinsiyet = viewModel.Cinsiyet;

				student.OkulAdi = viewModel.OkulAdi;
				student.OkulBaslangic = viewModel.OkulBaslangic;
				student.OkulBitis = viewModel.OkulBitis;
				student.OkulOrt = viewModel.OkulOrt;
				await dbContext.SaveChangesAsync();
			}

			return RedirectToAction("List", "Students");
		}

		[HttpPost]
		public async Task<IActionResult> Delete(Student viewModel)
		{
			var student = await dbContext.Students
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Id == viewModel.Id);
			if (student is not null)
			{
				dbContext.Remove(viewModel);
				await dbContext.SaveChangesAsync();
			}

			return RedirectToAction("List", "Students");
		}
	}
}
