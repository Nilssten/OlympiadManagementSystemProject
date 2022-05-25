using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympiadManagementSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Olympiads",
                columns: table => new
                {
                    OlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rules_MaxParticipant = table.Column<int>(type: "int", nullable: true),
                    Rules_MinParticipant = table.Column<int>(type: "int", nullable: true),
                    Rules_MaxParticipantFromApplicant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olympiads", x => x.OlympiadID);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInfo_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInfo_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInfo_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInfo_Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInfo_DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BasicInfo_Gender = table.Column<int>(type: "int", nullable: true),
                    BasicInfo_PersonalCode = table.Column<int>(type: "int", nullable: true),
                    BasicInfo_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInfo_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserProfileID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OlympiadResults",
                columns: table => new
                {
                    OlympiadResultID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EvaluatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Place = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympiadResults", x => x.OlympiadResultID);
                    table.ForeignKey(
                        name: "FK_OlympiadResults_Olympiads_OlympiadID",
                        column: x => x.OlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    ApplicantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchoolID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.ApplicantID);
                    table.ForeignKey(
                        name: "FK_Applicants_School_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "School",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_UserProfiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluator",
                columns: table => new
                {
                    EvaluatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluator", x => x.EvaluatorID);
                    table.ForeignKey(
                        name: "FK_Evaluator_Olympiads_OlympiadID",
                        column: x => x.OlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluator_UserProfiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    ParticipantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchoolID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.ParticipantID);
                    table.ForeignKey(
                        name: "FK_Participant_Applicants_ApplicantID",
                        column: x => x.ApplicantID,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participant_Olympiads_OlympiadID",
                        column: x => x.OlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participant_School_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "School",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participant_UserProfiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OlympiadResultParticipant",
                columns: table => new
                {
                    OlympiadResultsOlympiadResultID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympiadResultParticipant", x => new { x.OlympiadResultsOlympiadResultID, x.ParticipantID });
                    table.ForeignKey(
                        name: "FK_OlympiadResultParticipant_OlympiadResults_OlympiadResultsOlympiadResultID",
                        column: x => x.OlympiadResultsOlympiadResultID,
                        principalTable: "OlympiadResults",
                        principalColumn: "OlympiadResultID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OlympiadResultParticipant_Participant_ParticipantID",
                        column: x => x.ParticipantID,
                        principalTable: "Participant",
                        principalColumn: "ParticipantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ProfileID",
                table: "Applicants",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_SchoolID",
                table: "Applicants",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluator_OlympiadID",
                table: "Evaluator",
                column: "OlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluator_ProfileID",
                table: "Evaluator",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadResultParticipant_ParticipantID",
                table: "OlympiadResultParticipant",
                column: "ParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadResults_OlympiadID",
                table: "OlympiadResults",
                column: "OlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_ApplicantID",
                table: "Participant",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_OlympiadID",
                table: "Participant",
                column: "OlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_ProfileID",
                table: "Participant",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_SchoolID",
                table: "Participant",
                column: "SchoolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluator");

            migrationBuilder.DropTable(
                name: "OlympiadResultParticipant");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "OlympiadResults");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Olympiads");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
