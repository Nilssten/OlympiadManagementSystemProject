using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympiadManagementSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
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
                    table.PrimaryKey("PK_Schools", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileUserProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admins_UserProfiles_ProfileUserProfileID",
                        column: x => x.ProfileUserProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Applicants_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
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
                name: "Evaluators",
                columns: table => new
                {
                    EvaluatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluators", x => x.EvaluatorID);
                    table.ForeignKey(
                        name: "FK_Evaluators_UserProfiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    OrganizerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.OrganizerID);
                    table.ForeignKey(
                        name: "FK_Organizers_UserProfiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchoolID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantID);
                    table.ForeignKey(
                        name: "FK_Participants_Applicants_ApplicantID",
                        column: x => x.ApplicantID,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participants_UserProfiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Rules_MaxParticipantFromApplicant = table.Column<int>(type: "int", nullable: true),
                    OrganizerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olympiads", x => x.OlympiadID);
                    table.ForeignKey(
                        name: "FK_Olympiads_Organizers_OrganizerID",
                        column: x => x.OrganizerID,
                        principalTable: "Organizers",
                        principalColumn: "OrganizerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Archives",
                columns: table => new
                {
                    ArchiveID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archives", x => x.ArchiveID);
                    table.ForeignKey(
                        name: "FK_Archives_Olympiads_OlympiadID",
                        column: x => x.OlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvaluatorOlympiad",
                columns: table => new
                {
                    EvaluatorsEvaluatorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OlympiadsOlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluatorOlympiad", x => new { x.EvaluatorsEvaluatorID, x.OlympiadsOlympiadID });
                    table.ForeignKey(
                        name: "FK_EvaluatorOlympiad_Evaluators_EvaluatorsEvaluatorID",
                        column: x => x.EvaluatorsEvaluatorID,
                        principalTable: "Evaluators",
                        principalColumn: "EvaluatorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluatorOlympiad_Olympiads_OlympiadsOlympiadID",
                        column: x => x.OlympiadsOlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OlympiadParticipant",
                columns: table => new
                {
                    OlympiadsOlympiadID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantsParticipantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympiadParticipant", x => new { x.OlympiadsOlympiadID, x.ParticipantsParticipantID });
                    table.ForeignKey(
                        name: "FK_OlympiadParticipant_Olympiads_OlympiadsOlympiadID",
                        column: x => x.OlympiadsOlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OlympiadParticipant_Participants_ParticipantsParticipantID",
                        column: x => x.ParticipantsParticipantID,
                        principalTable: "Participants",
                        principalColumn: "ParticipantID",
                        onDelete: ReferentialAction.Cascade);
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
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympiadResults", x => x.OlympiadResultID);
                    table.ForeignKey(
                        name: "FK_OlympiadResults_Archives_ArchiveID",
                        column: x => x.ArchiveID,
                        principalTable: "Archives",
                        principalColumn: "ArchiveID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OlympiadResults_Olympiads_OlympiadID",
                        column: x => x.OlympiadID,
                        principalTable: "Olympiads",
                        principalColumn: "OlympiadID",
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
                        name: "FK_OlympiadResultParticipant_Participants_ParticipantID",
                        column: x => x.ParticipantID,
                        principalTable: "Participants",
                        principalColumn: "ParticipantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ProfileUserProfileID",
                table: "Admins",
                column: "ProfileUserProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ProfileID",
                table: "Applicants",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_SchoolID",
                table: "Applicants",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Archives_OlympiadID",
                table: "Archives",
                column: "OlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatorOlympiad_OlympiadsOlympiadID",
                table: "EvaluatorOlympiad",
                column: "OlympiadsOlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluators_ProfileID",
                table: "Evaluators",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadParticipant_ParticipantsParticipantID",
                table: "OlympiadParticipant",
                column: "ParticipantsParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadResultParticipant_ParticipantID",
                table: "OlympiadResultParticipant",
                column: "ParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadResults_ArchiveID",
                table: "OlympiadResults",
                column: "ArchiveID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadResults_OlympiadID",
                table: "OlympiadResults",
                column: "OlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_Olympiads_OrganizerID",
                table: "Olympiads",
                column: "OrganizerID");

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_ProfileID",
                table: "Organizers",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ApplicantID",
                table: "Participants",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ProfileID",
                table: "Participants",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_SchoolID",
                table: "Participants",
                column: "SchoolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EvaluatorOlympiad");

            migrationBuilder.DropTable(
                name: "OlympiadParticipant");

            migrationBuilder.DropTable(
                name: "OlympiadResultParticipant");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Evaluators");

            migrationBuilder.DropTable(
                name: "OlympiadResults");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Archives");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Olympiads");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
