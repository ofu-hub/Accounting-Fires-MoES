using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WpfApp1.Models;

namespace WpfApp1.Data.Base
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FileReport> FileReports { get; set; } = null!;
        public virtual DbSet<FireConsequence> FireConsequences { get; set; } = null!;
        public virtual DbSet<FireDevExt> FireDevExts { get; set; } = null!;
        public virtual DbSet<FireForcesMean> FireForcesMeans { get; set; } = null!;
        public virtual DbSet<FireObj> FireObjs { get; set; } = null!;
        public virtual DbSet<FireRescued> FireRescueds { get; set; } = null!;
        public virtual DbSet<GenInfo> GenInfos { get; set; } = null!;
        public virtual DbSet<InfoDeadAInjured> InfoDeadAInjureds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=moes_db;Username=postgres;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileReport>(entity =>
            {
                entity.ToTable("file_reports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.FireconsId).HasColumnName("firecons_id");

                entity.Property(e => e.FiredaeId).HasColumnName("firedae_id");

                entity.Property(e => e.FireforcId).HasColumnName("fireforc_id");

                entity.Property(e => e.FireobjId).HasColumnName("fireobj_id");

                entity.Property(e => e.FirerescuedId).HasColumnName("firerescued_id");

                entity.Property(e => e.GeninfoId).HasColumnName("geninfo_id");

                entity.Property(e => e.InfodaiId).HasColumnName("infodai_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.HasOne(d => d.Firecons)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.FireconsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_firecons_id_fkey");

                entity.HasOne(d => d.Firedae)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.FiredaeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_firedae_id_fkey");

                entity.HasOne(d => d.Fireforc)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.FireforcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_fireforc_id_fkey");

                entity.HasOne(d => d.Fireobj)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.FireobjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_fireobj_id_fkey");

                entity.HasOne(d => d.Firerescued)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.FirerescuedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_firerescued_id_fkey");

                entity.HasOne(d => d.Geninfo)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.GeninfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_geninfo_id_fkey");

                entity.HasOne(d => d.Infodai)
                    .WithMany(p => p.FileReports)
                    .HasForeignKey(d => d.InfodaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_reports_infodai_id_fkey");
            });

            modelBuilder.Entity<FireConsequence>(entity =>
            {
                entity.ToTable("fire_consequences");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ApartDam)
                    .HasMaxLength(3)
                    .HasColumnName("apart_dam");

                entity.Property(e => e.ApartDest)
                    .HasMaxLength(3)
                    .HasColumnName("apart_dest");

                entity.Property(e => e.BuildDam)
                    .HasMaxLength(3)
                    .HasColumnName("build_dam");

                entity.Property(e => e.BuildDest)
                    .HasMaxLength(3)
                    .HasColumnName("build_dest");

                entity.Property(e => e.MFireDamage)
                    .HasPrecision(12)
                    .HasColumnName("m_fire_damage");

                entity.Property(e => e.PeopleDiedAll)
                    .HasMaxLength(3)
                    .HasColumnName("people_died_all");

                entity.Property(e => e.PeopleDiedKids)
                    .HasMaxLength(2)
                    .HasColumnName("people_died_kids");

                entity.Property(e => e.PeopleDiedWork)
                    .HasMaxLength(2)
                    .HasColumnName("people_died_work");

                entity.Property(e => e.PeopleInjuredAll)
                    .HasMaxLength(3)
                    .HasColumnName("people_injured_all");

                entity.Property(e => e.PeopleInjuredKids)
                    .HasMaxLength(2)
                    .HasColumnName("people_injured_kids");

                entity.Property(e => e.PeopleInjuredWork)
                    .HasMaxLength(2)
                    .HasColumnName("people_injured_work");
            });

            modelBuilder.Entity<FireDevExt>(entity =>
            {
                entity.ToTable("fire_dev_ext");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ArrivalTime1st)
                    .HasMaxLength(4)
                    .HasColumnName("arrival_time_1st");

                entity.Property(e => e.DetectionTime)
                    .HasMaxLength(4)
                    .HasColumnName("detection_time");

                entity.Property(e => e.EliFireTime)
                    .HasMaxLength(4)
                    .HasColumnName("eli_fire_time");

                entity.Property(e => e.LiquidationDate).HasColumnName("liquidation_date");

                entity.Property(e => e.LocalTime)
                    .HasMaxLength(4)
                    .HasColumnName("local_time");

                entity.Property(e => e.MessageTime)
                    .HasMaxLength(4)
                    .HasColumnName("message_time");

                entity.Property(e => e.OpenFireEliTime)
                    .HasMaxLength(4)
                    .HasColumnName("open_fire_eli_time");
            });

            modelBuilder.Entity<FireForcesMean>(entity =>
            {
                entity.ToTable("fire_forces_means");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.FireExtAgents)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("fire_ext_agents");

                entity.Property(e => e.FireExtManager)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("fire_ext_manager");

                entity.Property(e => e.FireFightingHead)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("fire_fighting_head");

                entity.Property(e => e.Firefighters)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("firefighters");

                entity.Property(e => e.IndividProtect)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("individ_protect");

                entity.Property(e => e.InvestigativeTeam)
                    .HasMaxLength(1)
                    .HasColumnName("investigative_team");

                entity.Property(e => e.NumTechnique)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("num_technique");

                entity.Property(e => e.PrimaryFireEquip)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("primary_fire_equip");

                entity.Property(e => e.Technique)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("technique");

                entity.Property(e => e.WaterOnFire)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("water_on_fire");
            });

            modelBuilder.Entity<FireObj>(entity =>
            {
                entity.ToTable("fire_obj");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AttitudePerson)
                    .HasMaxLength(2)
                    .HasColumnName("attitude_person");

                entity.Property(e => e.CauseFire)
                    .HasMaxLength(2)
                    .HasColumnName("cause_fire");

                entity.Property(e => e.FloorWhereFire)
                    .HasMaxLength(3)
                    .HasColumnName("floor_where_fire");

                entity.Property(e => e.FloorsObj)
                    .HasMaxLength(3)
                    .HasColumnName("floors_obj");

                entity.Property(e => e.GuiltyPerson)
                    .HasMaxLength(2)
                    .HasColumnName("guilty_person");

                entity.Property(e => e.KindFireObj)
                    .HasMaxLength(3)
                    .HasColumnName("kind_fire_obj");

                entity.Property(e => e.LocationFire)
                    .HasMaxLength(3)
                    .HasColumnName("location_fire");

                entity.Property(e => e.NameFireObj)
                    .HasMaxLength(100)
                    .HasColumnName("name_fire_obj");

                entity.Property(e => e.ObjRisk)
                    .HasMaxLength(2)
                    .HasColumnName("obj_risk");

                entity.Property(e => e.StatePerson)
                    .HasMaxLength(1)
                    .HasColumnName("state_person");

                entity.Property(e => e.SubTypeOwner)
                    .HasMaxLength(2)
                    .HasColumnName("sub_type_owner");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<FireRescued>(entity =>
            {
                entity.ToTable("fire_rescued");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CattleLarge)
                    .HasMaxLength(4)
                    .HasColumnName("cattle_large");

                entity.Property(e => e.CattleSmall)
                    .HasMaxLength(4)
                    .HasColumnName("cattle_small");

                entity.Property(e => e.MatValues)
                    .HasPrecision(12)
                    .HasColumnName("mat_values");

                entity.Property(e => e.PeopleEvacuated)
                    .HasMaxLength(4)
                    .HasColumnName("people_evacuated");

                entity.Property(e => e.PeopleSaved)
                    .HasMaxLength(4)
                    .HasColumnName("people_saved");

                entity.Property(e => e.Technique)
                    .HasMaxLength(4)
                    .HasColumnName("technique");
            });

            modelBuilder.Entity<GenInfo>(entity =>
            {
                entity.ToTable("gen_info");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Datefire).HasColumnName("datefire");

                entity.Property(e => e.OrgCode)
                    .HasMaxLength(4)
                    .HasColumnName("org_code");

                entity.Property(e => e.TypefiresettCode)
                    .HasMaxLength(1)
                    .HasColumnName("typefiresett_code");

                entity.Property(e => e.TypesettCode)
                    .HasMaxLength(1)
                    .HasColumnName("typesett_code");
            });

            modelBuilder.Entity<InfoDeadAInjured>(entity =>
            {
                entity.ToTable("info_dead_a_injured");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AgeDead)
                    .HasColumnType("character varying(3)[]")
                    .HasColumnName("age_dead");

                entity.Property(e => e.CauseDead)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("cause_dead");

                entity.Property(e => e.EducationDead)
                    .HasColumnType("character varying(1)[]")
                    .HasColumnName("education_dead");

                entity.Property(e => e.GenderDead)
                    .HasColumnType("character varying(1)[]")
                    .HasColumnName("gender_dead");

                entity.Property(e => e.HarmHealth)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("harm_health");

                entity.Property(e => e.MomentDead)
                    .HasColumnType("character varying(1)[]")
                    .HasColumnName("moment_dead");

                entity.Property(e => e.SocStatus)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("soc_status");

                entity.Property(e => e.TermsDead)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("terms_dead");

                entity.Property(e => e.TermsInjury)
                    .HasColumnType("character varying(2)[]")
                    .HasColumnName("terms_injury");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
