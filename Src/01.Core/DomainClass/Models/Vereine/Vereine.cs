﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using DomainClass.Common;
using System;
using System.Collections.Generic;

namespace DomainClass.Models;

public class Vereine : BaseEntity
{
    public int VereinsNr { get; set; }

    public string Landesverband { get; set; }

    public string Bezirk { get; set; }

    public string VereinBez { get; set; }
}