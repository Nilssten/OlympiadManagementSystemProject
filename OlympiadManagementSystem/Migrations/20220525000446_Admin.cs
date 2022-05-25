using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympiadManagementSystem.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluator_Olympiads_OlympiadID",
                table: "Evaluator");

            migrationBuilder.DropForeignKey(
                name: "FK_Participant_Olympiads_OlympiadID",
                table: "Participant");

            migrationBuilder.DropIndex(
                name: "IX_Participant_OlympiadID",
                table: "Participant");

            migrationBuilder.DropIndex(
                name: "IX_Evaluator_OlympiadID",
                table: "Evaluator");

            migrationBuilder.DropColumn(
                name: "OlympiadID",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "OlympiadID",
                table: "Evaluator");

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
                        name: "FK_EvaluatorOlympiad_Evaluator_EvaluatorsEvaluatorID",
                        column: x => x.EvaluatorsEvaluatorID,
                        principalTable: "Evaluator",
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
                        name: "FK_OlympiadParticipant_Participant_ParticipantsParticipantID",
                        column: x => x.ParticipantsParticipantID,
                        principalTable: "Participant",
                        principalColumn: "ParticipantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ProfileUserProfileID",
                table: "Admins",
                column: "ProfileUserProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatorOlympiad_OlympiadsOlympiadID",
                table: "EvaluatorOlympiad",
                column: "OlympiadsOlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadParticipant_ParticipantsParticipantID",
                table: "OlympiadParticipant",
                column: "ParticipantsParticipantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "EvaluatorOlympiad");

            migrationBuilder.DropTable(
                name: "OlympiadParticipant");

            migrationBuilder.AddColumn<Guid>(
                name: "OlympiadID",
                table: "Participant",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OlympiadID",
                table: "Evaluator",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participant_OlympiadID",
                table: "Participant",
                column: "OlympiadID");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluator_OlympiadID",
                table: "Evaluator",
                column: "OlympiadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluator_Olympiads_OlympiadID",
                table: "Evaluator",
                column: "OlympiadID",
                principalTable: "Olympiads",
                principalColumn: "OlympiadID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_Olympiads_OlympiadID",
                table: "Participant",
                column: "OlympiadID",
                principalTable: "Olympiads",
                principalColumn: "OlympiadID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
