﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class Entities : DbContext
{
    public Entities()
        : base("name=Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<ImportedItem> ImportedItems { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<ExportedItem> ExportedItems { get; set; }

    public virtual DbSet<RuleList> RuleLists { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }


    public virtual ObjectResult<sp_GetInvalidInvoiceHeaderDetail_Result> sp_GetInvalidInvoiceHeaderDetail(Nullable<int> fileId)
    {

        var fileIdParameter = fileId.HasValue ?
            new ObjectParameter("fileId", fileId) :
            new ObjectParameter("fileId", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInvalidInvoiceHeaderDetail_Result>("sp_GetInvalidInvoiceHeaderDetail", fileIdParameter);
    }


    public virtual ObjectResult<sp_GetInvoiceRawData_Result> sp_GetInvoiceRawData(Nullable<int> fileId, string payingSite, string invoiceTemplate)
    {

        var fileIdParameter = fileId.HasValue ?
            new ObjectParameter("fileId", fileId) :
            new ObjectParameter("fileId", typeof(int));


        var payingSiteParameter = payingSite != null ?
            new ObjectParameter("payingSite", payingSite) :
            new ObjectParameter("payingSite", typeof(string));


        var invoiceTemplateParameter = invoiceTemplate != null ?
            new ObjectParameter("invoiceTemplate", invoiceTemplate) :
            new ObjectParameter("invoiceTemplate", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInvoiceRawData_Result>("sp_GetInvoiceRawData", fileIdParameter, payingSiteParameter, invoiceTemplateParameter);
    }


    public virtual ObjectResult<sp_GetInvHedDetWithAdditionTransaction_Result> sp_GetInvHedDetWithAdditionTransaction(Nullable<int> fileId)
    {

        var fileIdParameter = fileId.HasValue ?
            new ObjectParameter("fileId", fileId) :
            new ObjectParameter("fileId", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInvHedDetWithAdditionTransaction_Result>("sp_GetInvHedDetWithAdditionTransaction", fileIdParameter);
    }


    [DbFunction("Entities", "InvoiceHeaderDetail")]
    public virtual IQueryable<InvoiceHeaderDetail_Result1> InvoiceHeaderDetail(Nullable<int> fileId)
    {

        var fileIdParameter = fileId.HasValue ?
            new ObjectParameter("fileId", fileId) :
            new ObjectParameter("fileId", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<InvoiceHeaderDetail_Result1>("[Entities].[InvoiceHeaderDetail](@fileId)", fileIdParameter);
    }


    [DbFunction("Entities", "InvHedDetWithAdditionTransaction")]
    public virtual IQueryable<InvHedDetWithAdditionTransaction_Result2> InvHedDetWithAdditionTransaction(Nullable<int> fileId)
    {

        var fileIdParameter = fileId.HasValue ?
            new ObjectParameter("fileId", fileId) :
            new ObjectParameter("fileId", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<InvHedDetWithAdditionTransaction_Result2>("[Entities].[InvHedDetWithAdditionTransaction](@fileId)", fileIdParameter);
    }


    public virtual ObjectResult<sp_ReorderNumber_Result> sp_ReorderNumber(string currentGroupName, Nullable<int> currentRowNumber, Nullable<bool> incrementBit)
    {

        var currentGroupNameParameter = currentGroupName != null ?
            new ObjectParameter("currentGroupName", currentGroupName) :
            new ObjectParameter("currentGroupName", typeof(string));


        var currentRowNumberParameter = currentRowNumber.HasValue ?
            new ObjectParameter("currentRowNumber", currentRowNumber) :
            new ObjectParameter("currentRowNumber", typeof(int));


        var incrementBitParameter = incrementBit.HasValue ?
            new ObjectParameter("incrementBit", incrementBit) :
            new ObjectParameter("incrementBit", typeof(bool));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReorderNumber_Result>("sp_ReorderNumber", currentGroupNameParameter, currentRowNumberParameter, incrementBitParameter);
    }

}

}

