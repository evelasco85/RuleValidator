
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RuleValidator_Proto.Domain.Entities
{

using System;
    using System.Collections.Generic;
    
public partial class Invoice
{

    public long Id { get; set; }

    public string Customer_Name { get; set; }

    public string Paying_Site { get; set; }

    public string Invoice_Template { get; set; }

    public string Responsible_Site { get; set; }

    public string Category { get; set; }

    public string Currency_Code { get; set; }

    public string Article_Number { get; set; }

    public string Article_Description { get; set; }

    public decimal Total_Number_Of_Packages { get; set; }

    public Nullable<int> No_Of_Transactions { get; set; }

    public Nullable<decimal> Price { get; set; }

    public Nullable<decimal> VAT { get; set; }

    public Nullable<decimal> Net { get; set; }

    public string Consignment_Number { get; set; }

    public string Fortnox_Invoice_Id { get; set; }

    public int File_Id { get; set; }

    public long ExportedItem_Id { get; set; }

    public string Transaction_Type { get; set; }

    public Nullable<decimal> Currency_BuyRate { get; set; }

}

}
