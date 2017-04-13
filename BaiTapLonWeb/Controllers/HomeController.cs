using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapLonWeb.Models;

namespace BaiTapLonWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        webbangiayEntities4 db = new webbangiayEntities4();

        public ActionResult Index()
        {
            var previewimg = (from pi in db.hinhanhs orderby pi.MaSP descending select pi).Take(16).ToList();
            var previews = (from ps in db.hinhanhs orderby ps.MaSP descending select ps).Take(16).ToList();
            String chuoi = "";
            for (int i = 0; i < previews.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = previews[i].MaSP }, null);
                chuoi+="<div>";
                            chuoi+="<img alt=\"\" src=\""+previewimg[i].anh1+"\" /><br />";
                            chuoi += "<span class=\"thumbnail-text\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + previews[i].TenSP + "</a></span>";
                            chuoi += "</div>";
            }
            ViewBag.View = chuoi;
                return View();
        }

        public ActionResult Footwear()
        {
            var footwearimg = (from f in db.hinhanhs orderby f.MaSP ascending select f).Take(12).ToList();
            var footweardetails = (from foot in db.sanphams orderby foot.MaSP ascending select foot).Take(12).ToList();
            String chuoi = "";
            for (int i = 0; i < 12; i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails[i].MaSP }, null);
                chuoi+="<div class=\"col1\">";
                chuoi+="<div class=\"cell\">";
                    chuoi+="<img src=\""+footwearimg[i].anh1+"\" />";
                    chuoi+="<div class=\"space\"></div>";
                    chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails[i].TenSP + "</a></div>";
                    chuoi+="<div style=\"float:right; width:25%;\">"+footweardetails[i].GiaBan.ToString()+"</div>";
                chuoi+="</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult Nike()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("NI") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("NI") select foot1).ToList();
            String chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails1[i].TenSP + "</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult NewBalance()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("NE") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("NE") select foot1).ToList();
            String chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails1[i].TenSP + "</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult Adidas()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("AD") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("AD") select foot1).ToList();
            String chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails1[i].TenSP + "</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult Asics()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("AS") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("AS") select foot1).ToList();
            String chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails1[i].TenSP + "</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult CR()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("CR") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("CR") select foot1).ToList();
            String chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails1[i].TenSP + "</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult Clarks()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("CL") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("CL") select foot1).ToList();
            String chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\"" + geturl + "\" style=\"text-decoration:none; color:white;\">" + footweardetails1[i].TenSP + "</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult Puma()
        {
            var footwearimg1 = (from f1 in db.hinhanhs where f1.MaSP.Contains("PM") select f1).ToList();
            var footweardetails1 = (from foot1 in db.sanphams where foot1.MaSP.Contains("PM") select foot1).ToList();
            var chuoi = "";
            for (int i = 0; i < footweardetails1.Count(); i++)
            {
                UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
                String geturl = url.Action("ViewDetails", "Home", new { id = footweardetails1[i].MaSP }, null);
                chuoi += "<div class=\"col1\">";
                chuoi += "<div class=\"cell\">";
                chuoi += "<img src=\"" + footwearimg1[i].anh1 + "\" />";
                chuoi += "<div class=\"space\"></div>";
                chuoi += "<div style=\"float:left; width:75%;\"><a href=\""+geturl+"\" style=\"text-decoration:none; color:white;\">"+footweardetails1[i].TenSP+"</a></div>";
                chuoi += "<div style=\"float:right; width:25%;\">" + footweardetails1[i].GiaBan.ToString() + "</div>";
                chuoi += "</div>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }




        public ActionResult ViewDetails(String id)
        {
            
            var detail = (from d in db.sanphams where d.MaSP.Contains(id) select d).ToList();
            var detailimg = (from di in db.hinhanhs where di.MaSP.Contains(id) select di).ToList();
            var detailnumber = (from dn in db.soluongs where dn.MaSP.Contains(id) select dn).ToList();
            String chuoi = "";
            String soluong = "";
            UrlHelper url = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext);
            String geturl = url.Action("Order", "Home", new { order = detail[0].MaSP }, null);
            for (int i = 0; i < detailimg.Count(); i++)
            {
                if (detailnumber[i].size39 > 0)
                    soluong += "39, ";
                if (detailnumber[i].size40 > 0)
                    soluong += "40, ";
                if (detailnumber[i].size41 > 0)
                    soluong += "41, ";
                if (detailnumber[i].size42 > 0)
                    soluong += "42, ";
                if (detailnumber[i].size43 > 0)
                    soluong += "43, ";
                chuoi += "<ul class=\"slides\" style=\"float: left; margin-left: 39px;\">";
                chuoi += "<input type=\"radio\" name=\"radio-btn\" id=\"img-1\" checked= checked />";
                chuoi += "<li class=\"slide-container\">";
                chuoi += "<div class=\"slide\">";
                chuoi += "<img src=\"" + detailimg[i].anh1 + "\" />";
                chuoi += "</div>";
                chuoi += "<div class=\"nav\">";
                chuoi += "<label for=\"img-6\" class=\"prev\">&#x2039;</label>";
                chuoi += "<label for=\"img-2\" class=\"next\">&#x203a;</label>";
                chuoi += "</div>";
                chuoi += "</li>";

                chuoi += "<input type=\"radio\" name=\"radio-btn\" id=\"img-2\" />";
                chuoi += "<li class=\"slide-container\">";
                chuoi += "<div class=\"slide\">";
                chuoi += "<img src=\"" + detailimg[i].anh2 + "\" />";
                chuoi += "</div>";
                chuoi += "<div class=\"nav\">";
                chuoi += "<label for=\"img-1\" class=\"prev\">&#x2039;</label>";
                chuoi += "<label for=\"img-3\" class=\"next\">&#x203a;</label>";
                chuoi += "</div>";
                chuoi += "</li>";

                chuoi += "<input type=\"radio\" name=\"radio-btn\" id=\"img-3\" />";
                chuoi += "<li class=\"slide-container\">";
                chuoi += "<div class=\"slide\">";
                chuoi += "<img src=\"" + detailimg[i].anh3 + "\" />";
                chuoi += "</div>";
                chuoi += "<div class=\"nav\">";
                chuoi += "<label for=\"img-2\" class=\"prev\">&#x2039;</label>";
                chuoi += "<label for=\"img-4\" class=\"next\">&#x203a;</label>";
                chuoi += "</div>";
                chuoi += "</li>";

                chuoi += "<input type=\"radio\" name=\"radio-btn\" id=\"img-4\" />";
                chuoi += "<li class=\"slide-container\">";
                chuoi += "<div class=\"slide\">";
                chuoi += "<img src=\"" + detailimg[i].anh4 + "\" />";
                chuoi += "</div>";
                chuoi += "<div class=\"nav\">";
                chuoi += "<label for=\"img-3\" class=\"prev\">&#x2039;</label>";
                chuoi += "<label for=\"img-5\" class=\"next\">&#x203a;</label>";
                chuoi += "</div>";
                chuoi += "</li>";

                chuoi += "<input type=\"radio\" name=\"radio-btn\" id=\"img-5\" />";
                chuoi += "<li class=\"slide-container\">";
                chuoi += "<div class=\"slide\">";
                chuoi += "<img src=\"" + detailimg[i].anh5 + "\" />";
                chuoi += "</div>";
                chuoi += "<div class=\"nav\">";
                chuoi += "<label for=\"img-4\" class=\"prev\">&#x2039;</label>";
                chuoi += "<label for=\"img-6\" class=\"next\">&#x203a;</label>";
                chuoi += "</div>";
                chuoi += "</li>";

                chuoi += "<input type=\"radio\" name=\"radio-btn\" id=\"img-6\" />";
                chuoi += "<li class=\"slide-container\">";
                chuoi += "<div class=\"slide\">";
                chuoi += "<img src=\"" + detailimg[i].anh1 + "\" />";
                chuoi+="<div style=\"float: left; width:52%;\">";
                    chuoi+="<div style=\"float: right;\">";
                        chuoi+="<a>@Html.ActionLink(\"index\", \"Index\", \"Home\")</a>";
                    chuoi+="</div>";
                chuoi+="</div>";
                chuoi += "</div>";
                chuoi += "<div class=\"nav\">";
                chuoi += "<label for=\"img-5\" class=\"prev\">&#x2039;</label>";
                chuoi += "<label for=\"img-1\" class=\"next\">&#x203a;</label>";
                chuoi += "</div>";
                chuoi += "</li>";

                chuoi += "<li class=\"nav-dots\">";
                chuoi += "<label for=\"img-1\" class=\"nav-dot\" id=\"img-dot-1\"></label>";
                chuoi += "<label for=\"img-2\" class=\"nav-dot\" id=\"img-dot-2\"></label>";
                chuoi += "<label for=\"img-3\" class=\"nav-dot\" id=\"img-dot-3\"></label>";
                chuoi += "<label for=\"img-4\" class=\"nav-dot\" id=\"img-dot-4\"></label>";
                chuoi += "<label for=\"img-5\" class=\"nav-dot\" id=\"img-dot-5\"></label>";
                chuoi += "<label for=\"img-6\" class=\"nav-dot\" id=\"img-dot-6\"></label>";
                chuoi += "</li>";
                chuoi += "</ul>";
                chuoi += "<div style=\"float:left; width:20%; margin-left:30px; color: White; height:800px; text-align:left;\"><h2 style=\"font-family:helvetica;\">" + detail[i].TenSP + "</h2>";
                chuoi += "<h3>Sizes value: "+soluong+"</h3>";
                chuoi += "<h3>Price: " + detail[i].GiaBan + "</h3>";
                chuoi += "<a href=\"" + geturl + "\" style=\"text-decoration:underline; color:yellow; font-size:15\">Order Now !!!</a>";
                chuoi += "</div>";
            }
            ViewBag.View = chuoi;
            return View();
        }

        public ActionResult Order(String order)
        {
            var orderimg = (from o in db.hinhanhs where o.MaSP.Contains(order) select o).ToList();
            var detailnumber = (from dn in db.soluongs where dn.MaSP.Contains(order) select dn).ToList();
            String chuoi="";
            String soluong = "";
                if (detailnumber[0].size39 > 0)
                    soluong += "39, ";
                if (detailnumber[0].size40 > 0)
                    soluong += "40, ";
                if (detailnumber[0].size41 > 0)
                    soluong += "41, ";
                if (detailnumber[0].size42 > 0)
                    soluong += "42, ";
                if (detailnumber[0].size43 > 0)
                    soluong += "43, ";
            chuoi+="<div style=\"float: left; width:40%; margin-left:39px; height:400px;\">";
            chuoi+="<img src=\""+orderimg[0].anh1+"\" style=\"width:100%; height:100%;\"/>";
            chuoi+="</div>";
            chuoi+="<div style=\"float:right; width:50%; height:130px; margin-right:2px;\">";
                chuoi+="<table style=\"color: white; font-size: 15px;\">";
                    chuoi+="<tr style=\"visibility: hidden;\">";
                        chuoi+="<td>MaSP: </td>";
                        chuoi += "<td><input type=\"text\" id=\"txtmasp\" name=\"txtmasp\" value=\"" + orderimg[0].MaSP + "\"/></td>";
                        chuoi += "</tr>";
                        chuoi+="<tr>";
                    chuoi+="<td>Name: </td>";
                    chuoi += "<td><input type=\"text\" id=\"txtname\" name=\"txtname\" /></td>";
                chuoi+="</tr>";
                chuoi+="<tr>";
                    chuoi+="<td>Phone Number: </td>";
                    chuoi += "<td><input type=\"text\" id=\"txtphone\" name=\"txtphone\" /></td>";
                chuoi+="</tr>";
                chuoi+="<tr>";
                    chuoi+="<td>Email: </td>";
                    chuoi += "<td><input type=\"text\" id=\"txtemail\" name=\"txtemail\" /></td>";
                chuoi+="</tr>";
                chuoi+="<tr>";
                    chuoi+="<td>Size Order: </td>";
                    chuoi+="<td><select id=\"txtsize\" name=\"txtsize\">";
                            chuoi+="<option id=\"A\">39</option>";
                            chuoi+="<option id=\"B\">40</option>";
                            chuoi+="<option id=\"C\">41</option>";
                            chuoi+="<option id=\"D\">42</option>";
                            chuoi+="<option id=\"E\">43</option>";
                        chuoi+="</select>";
                    chuoi+="</td>";
                    chuoi+="<td>We just left size: "+soluong+"</td>";
                chuoi+="</tr>";
            chuoi+="</table>";
            chuoi += "</div>";
            ViewBag.View = chuoi;
            return View();
        }

        [HttpPost]
        public ActionResult Order(khachhang khach, dathang dh, FormCollection collection)
        {   
            var khachhang = (from k in db.khachhangs select k).ToList();
            var dathang = (from d in db.dathangs select d).ToList();
            String ten = collection["txtname"];
            String sdt = collection["txtphone"];
            String diachi = collection["txtaddress"];
            String mail = collection["txtemail"];
            String masp = collection["txtmasp"];
            String size = collection["txtsize"].ToString();
            dh.MaDH = (dathang.Count() + 1).ToString();
            dh.MaKH = (dathang.Count() + 1).ToString();
            khach.MaKH = (khachhang.Count() + 1).ToString();
            khach.TenKH = ten;
            khach.SoDT = sdt;
            khach.DiaChi = diachi;
            khach.Email = mail;
            dh.SDT = sdt;
            dh.DiaChiDH = diachi;
            dh.Email = mail;
            dh.MaSP = masp;
            dh.Size = size;
            dh.SoLuong = 1;

            db.khachhangs.Add(khach);
            db.dathangs.Add(dh);
            db.SaveChanges();
            return RedirectToAction("ViewDetails", new { id = masp.ToString() });
        }

	}
}