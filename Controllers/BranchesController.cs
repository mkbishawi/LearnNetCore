﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MSIS.Models;
using MSIS.ViewModels;

namespace MSIS.Controllers
{
    public class BranchesController : Controller
    {
        private readonly SQLBranchRepository brachRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public BranchesController(SQLBranchRepository BrachRepository, IHostingEnvironment hostingEnvironment)
        {
            brachRepository = BrachRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult ListBranches()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            MSIS.ViewModels.UserPermissionsViewModel permission = brachRepository.GetUserParentMenuPermission(userId, "Branches");

            ListBranchesViewModel model = brachRepository.ListBranches();
            model.userPermission = permission.UserPermissions[0];

            return View(model);
        }


        [HttpPost]
        public IActionResult Delete(int Id)
        {
            string errorMessage = "";
            errorMessage = brachRepository.ValidateDeletBranch(Id);
            //PurchaseOrderDetails purchaseOrder = purchaseOrderRepository.DeletePurchaseOrderItem(Id);
            if (errorMessage == "")
            {
                Branch branch = brachRepository.Delete(Id);
                if (branch == null)
                {
                    return Redirect("NotFound");
                }
                else
                {
                    //return new JsonResult("{Deleted:true,ErrorText:''}");
                    List<Branch> model = brachRepository.GetAllBranches().ToList();
                    return new JsonResult(model);

                    //return PartialView("_PurchaseOrderItems", model);

                }

            }
            else
            {
                return new JsonResult(errorMessage);
            }
        }

        [HttpPost]
        public IActionResult ValidateDelete(int Id)
        {
            string errorMessage = "";
            errorMessage = brachRepository.ValidateDeletBranch(Id);
            //PurchaseOrderDetails purchaseOrder = purchaseOrderRepository.DeletePurchaseOrderItem(Id);
            return new JsonResult(errorMessage);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Branch branch)
        {
            if (ModelState.IsValid)
            {
                brachRepository.Add(branch);
                return RedirectToAction("ListBranches", "Branches");
            }
            return View(branch);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            BranchDetailsViewModel model = new BranchDetailsViewModel();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            MSIS.ViewModels.UserPermissionsViewModel permission = brachRepository.GetUserParentMenuPermission(userId, "Branches");

            if (permission.UserPermissions.Count > 0)
            {
                model.Permission = permission.UserPermissions[0];
            }

            Branch branch=brachRepository.GetBranch(Id);
            if (branch == null)
            {
                return Redirect("NotFound");
            }
            else
            {
                model.Branch = branch;
                return View(model);
            }            
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Branch branch = brachRepository.GetBranch(Id);
            if (branch == null)
            {
                return Redirect("NotFound");
            }
            else
            {
                return View(branch);
            }

        }
        [HttpPost]
        public IActionResult Edit(Branch BranchChanges)
        {
            if (ModelState.IsValid)
            {
                Branch branch = brachRepository.GetBranch(BranchChanges.Id);
                if (branch == null)
                {
                    return Redirect("NotFound");
                }
                else
                {
                    branch.Code = BranchChanges.Code;
                    branch.Address = BranchChanges.Address;
                    branch.Mobile = BranchChanges.Mobile;
                    branch.Name = BranchChanges.Name;
                    branch.Phone = BranchChanges.Phone;
                    brachRepository.Update(branch);
                    return RedirectToAction("ListBranches", "Branches");
                }
            }
            return View(BranchChanges);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            var branch = brachRepository.GetBranch(id);
            if (branch == null)
            {
                ViewBag.ErrorMessage = $"branch with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = brachRepository.Delete(id);
                return RedirectToAction("ListBranches");
            }
        }

    }
}