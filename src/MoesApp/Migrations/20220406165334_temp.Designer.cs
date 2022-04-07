﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoesApp.Data.Base;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MoesApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220406165334_temp")]
    partial class temp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MoesApp.Models.FileReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("FireconsId")
                        .HasColumnType("integer")
                        .HasColumnName("firecons_id");

                    b.Property<int>("FiredaeId")
                        .HasColumnType("integer")
                        .HasColumnName("firedae_id");

                    b.Property<int>("FireforcId")
                        .HasColumnType("integer")
                        .HasColumnName("fireforc_id");

                    b.Property<int>("FireobjId")
                        .HasColumnType("integer")
                        .HasColumnName("fireobj_id");

                    b.Property<int>("FirerescuedId")
                        .HasColumnType("integer")
                        .HasColumnName("firerescued_id");

                    b.Property<int>("GeninfoId")
                        .HasColumnType("integer")
                        .HasColumnName("geninfo_id");

                    b.Property<int>("InfodaiId")
                        .HasColumnType("integer")
                        .HasColumnName("infodai_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("FireconsId");

                    b.HasIndex("FiredaeId");

                    b.HasIndex("FireforcId");

                    b.HasIndex("FireobjId");

                    b.HasIndex("FirerescuedId");

                    b.HasIndex("GeninfoId");

                    b.HasIndex("InfodaiId");

                    b.ToTable("file_reports", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.FireConsequence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartDam")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("apart_dam");

                    b.Property<string>("ApartDest")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("apart_dest");

                    b.Property<string>("BuildDam")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("build_dam");

                    b.Property<string>("BuildDest")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("build_dest");

                    b.Property<decimal>("MFireDamage")
                        .HasPrecision(12)
                        .HasColumnType("numeric(12)")
                        .HasColumnName("m_fire_damage");

                    b.Property<string>("PeopleDiedAll")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("people_died_all");

                    b.Property<string>("PeopleDiedKids")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("people_died_kids");

                    b.Property<string>("PeopleDiedWork")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("people_died_work");

                    b.Property<string>("PeopleInjuredAll")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("people_injured_all");

                    b.Property<string>("PeopleInjuredKids")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("people_injured_kids");

                    b.Property<string>("PeopleInjuredWork")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("people_injured_work");

                    b.HasKey("Id");

                    b.ToTable("fire_consequences", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.FireDevExt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("LiquidationDate")
                        .HasColumnType("date")
                        .HasColumnName("liquidation_date");

                    b.HasKey("Id");

                    b.ToTable("fire_dev_ext", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.FireForcesMean", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string[]>("FireExtAgents")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("fire_ext_agents");

                    b.Property<string[]>("FireExtManager")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("fire_ext_manager");

                    b.Property<string[]>("FireFightingHead")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("fire_fighting_head");

                    b.Property<string[]>("Firefighters")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("firefighters");

                    b.Property<string[]>("IndividProtect")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("individ_protect");

                    b.Property<string>("InvestigativeTeam")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("investigative_team");

                    b.Property<string[]>("NumTechnique")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("num_technique");

                    b.Property<string[]>("PrimaryFireEquip")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("primary_fire_equip");

                    b.Property<string[]>("Technique")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("technique");

                    b.Property<string[]>("WaterOnFire")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("water_on_fire");

                    b.HasKey("Id");

                    b.ToTable("fire_forces_means", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.FireObj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("AttitudePerson")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("attitude_person");

                    b.Property<string>("CauseFire")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("cause_fire");

                    b.Property<string>("FloorWhereFire")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("floor_where_fire");

                    b.Property<string>("FloorsObj")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("floors_obj");

                    b.Property<string>("GuiltyPerson")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("guilty_person");

                    b.Property<string>("KindFireObj")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("kind_fire_obj");

                    b.Property<string>("LocationFire")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("location_fire");

                    b.Property<string>("NameFireObj")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name_fire_obj");

                    b.Property<string>("ObjRisk")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("obj_risk");

                    b.Property<string>("StatePerson")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("state_person");

                    b.Property<string>("SubTypeOwner")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("sub_type_owner");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("subject");

                    b.HasKey("Id");

                    b.ToTable("fire_obj", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.FireRescued", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("CattleLarge")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("cattle_large");

                    b.Property<string>("CattleSmall")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("cattle_small");

                    b.Property<decimal>("MatValues")
                        .HasPrecision(12)
                        .HasColumnType("numeric(12)")
                        .HasColumnName("mat_values");

                    b.Property<string>("PeopleEvacuated")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("people_evacuated");

                    b.Property<string>("PeopleSaved")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("people_saved");

                    b.Property<string>("Technique")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("technique");

                    b.HasKey("Id");

                    b.ToTable("fire_rescued", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.GenInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Datefire")
                        .HasColumnType("date")
                        .HasColumnName("datefire");

                    b.Property<string>("OrgCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("org_code");

                    b.Property<string>("TypefiresettCode")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("typefiresett_code");

                    b.Property<string>("TypesettCode")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("typesett_code");

                    b.HasKey("Id");

                    b.ToTable("gen_info", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.InfoDeadAInjured", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string[]>("AgeDead")
                        .IsRequired()
                        .HasColumnType("character varying(3)[]")
                        .HasColumnName("age_dead");

                    b.Property<string[]>("CauseDead")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("cause_dead");

                    b.Property<string[]>("EducationDead")
                        .IsRequired()
                        .HasColumnType("character varying(1)[]")
                        .HasColumnName("education_dead");

                    b.Property<string[]>("GenderDead")
                        .IsRequired()
                        .HasColumnType("character varying(1)[]")
                        .HasColumnName("gender_dead");

                    b.Property<string[]>("HarmHealth")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("harm_health");

                    b.Property<string[]>("MomentDead")
                        .IsRequired()
                        .HasColumnType("character varying(1)[]")
                        .HasColumnName("moment_dead");

                    b.Property<string[]>("SocStatus")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("soc_status");

                    b.Property<string[]>("TermsDead")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("terms_dead");

                    b.Property<string[]>("TermsInjury")
                        .IsRequired()
                        .HasColumnType("character varying(2)[]")
                        .HasColumnName("terms_injury");

                    b.HasKey("Id");

                    b.ToTable("info_dead_a_injured", (string)null);
                });

            modelBuilder.Entity("MoesApp.Models.FileReport", b =>
                {
                    b.HasOne("MoesApp.Models.FireConsequence", "Firecons")
                        .WithMany("FileReports")
                        .HasForeignKey("FireconsId")
                        .IsRequired()
                        .HasConstraintName("file_reports_firecons_id_fkey");

                    b.HasOne("MoesApp.Models.FireDevExt", "Firedae")
                        .WithMany("FileReports")
                        .HasForeignKey("FiredaeId")
                        .IsRequired()
                        .HasConstraintName("file_reports_firedae_id_fkey");

                    b.HasOne("MoesApp.Models.FireForcesMean", "Fireforc")
                        .WithMany("FileReports")
                        .HasForeignKey("FireforcId")
                        .IsRequired()
                        .HasConstraintName("file_reports_fireforc_id_fkey");

                    b.HasOne("MoesApp.Models.FireObj", "Fireobj")
                        .WithMany("FileReports")
                        .HasForeignKey("FireobjId")
                        .IsRequired()
                        .HasConstraintName("file_reports_fireobj_id_fkey");

                    b.HasOne("MoesApp.Models.FireRescued", "Firerescued")
                        .WithMany("FileReports")
                        .HasForeignKey("FirerescuedId")
                        .IsRequired()
                        .HasConstraintName("file_reports_firerescued_id_fkey");

                    b.HasOne("MoesApp.Models.GenInfo", "Geninfo")
                        .WithMany("FileReports")
                        .HasForeignKey("GeninfoId")
                        .IsRequired()
                        .HasConstraintName("file_reports_geninfo_id_fkey");

                    b.HasOne("MoesApp.Models.InfoDeadAInjured", "Infodai")
                        .WithMany("FileReports")
                        .HasForeignKey("InfodaiId")
                        .IsRequired()
                        .HasConstraintName("file_reports_infodai_id_fkey");

                    b.Navigation("Firecons");

                    b.Navigation("Firedae");

                    b.Navigation("Fireforc");

                    b.Navigation("Fireobj");

                    b.Navigation("Firerescued");

                    b.Navigation("Geninfo");

                    b.Navigation("Infodai");
                });

            modelBuilder.Entity("MoesApp.Models.FireConsequence", b =>
                {
                    b.Navigation("FileReports");
                });

            modelBuilder.Entity("MoesApp.Models.FireDevExt", b =>
                {
                    b.Navigation("FileReports");
                });

            modelBuilder.Entity("MoesApp.Models.FireForcesMean", b =>
                {
                    b.Navigation("FileReports");
                });

            modelBuilder.Entity("MoesApp.Models.FireObj", b =>
                {
                    b.Navigation("FileReports");
                });

            modelBuilder.Entity("MoesApp.Models.FireRescued", b =>
                {
                    b.Navigation("FileReports");
                });

            modelBuilder.Entity("MoesApp.Models.GenInfo", b =>
                {
                    b.Navigation("FileReports");
                });

            modelBuilder.Entity("MoesApp.Models.InfoDeadAInjured", b =>
                {
                    b.Navigation("FileReports");
                });
#pragma warning restore 612, 618
        }
    }
}
