using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace DemoMVC.Controllers;

public class DaiLyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(DaiLy daily)
    {
        string strOutput = "Đây là " + daily.MaDaiLy + " - " + daily.TenDaiLy + " - " + daily.NguoiDaiDien + " - " + daily.DiaChi + " - " + daily.DienThoai + " - " + daily.MaHTPP;
        ViewBag.infoDaiLy = strOutput;
        return View();
    } 
}
