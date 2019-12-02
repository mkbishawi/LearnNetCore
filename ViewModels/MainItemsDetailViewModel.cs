﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MSIS.Models;
namespace MSIS.ViewModels
{
    public class MainItemsDetailViewModel
    {

        public MainItemViewModel MainItem { get; set; }
        [NotMapped]
        public UserPermissionDetailsViewModel Permission { get; set; }
    }
}
