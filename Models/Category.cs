﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<ExpenseIncome> ExpenseIncomes { get; set; }

    }
}
