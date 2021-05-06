using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HeartHome.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Data.Mapping
{
    public class BankAccountMap : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure (EntityTypeBuilder<BankAccount> builder)
        {
            builder.ToTable("bank_account")
                .HasKey(c => c.BankAccountID);
            builder.Property(c => c.BankAccountID)
                .HasColumnName("account_id");
            builder.Property(c => c.BankID)
                .HasColumnName("bank_id");
            builder.Property(c => c.AccountNumber)
                .HasColumnName("account_number")
                .HasColumnType("int");
            builder.Property(c => c.DateCreation)
                .HasColumnName("date_creation")
                .HasColumnType("date");
            builder.Property(c => c.CVC)
                .HasColumnName("cvc")
                .HasColumnType("int");

            //FK

            builder.HasOne(c => c.Bank)
                .WithMany(c => c.BankAccounts)
                .HasForeignKey(c => c.BankID)
                .HasConstraintName("fk_bankaccount_bank")
                .IsRequired(true);
        }
    }
}
