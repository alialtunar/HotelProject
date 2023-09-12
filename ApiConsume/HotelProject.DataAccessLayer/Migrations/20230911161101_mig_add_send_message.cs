using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_send_message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendMessages",
                columns: table => new
                {
                    SendMessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecevierName = table.Column<string>(nullable: true),
                    RecevierMail = table.Column<string>(nullable: true),
                    SenderName = table.Column<string>(nullable: true),
                    SenderMail = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMessages", x => x.SendMessageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendMessages");
        }
    }
}
