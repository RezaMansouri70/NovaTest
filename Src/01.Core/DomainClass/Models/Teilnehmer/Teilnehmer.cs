﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using DomainClass.Common;
using System;
using System.Collections.Generic;

namespace DomainClass.Models;

public partial class Teilnehmer : BaseEntity
{
    public int Nr { get; set; }

    public string Verband { get; set; }

    public string Name { get; set; }

    public int? VereinsNr { get; set; }

    public int AklassenId { get; set; }

    public int? Gewicht { get; set; }

    public string Pool { get; set; }

    public byte? LosNr { get; set; }

    public byte? Platz { get; set; }

    public string PoolPlatz { get; set; }

    public float? FinalPunkte { get; set; }

    public float? IstGewicht { get; set; }
}