﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Cliente
    {
        [Key]
        public int cd_codicli { get; set; }
        public string no_nomepes { get; set; }
        public DateTime dt_nascime { get; set; }
        public string ds_cpfcnpj { get; set; }
        public DateTime dt_cadastr { get; set; }
    }
}