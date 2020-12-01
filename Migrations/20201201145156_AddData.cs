using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentsAPI.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Document",
                columns: new[] { "DocumentId", "CreationDate", "DocumentImage", "DocumentText", "DocumentTitle", "DocumentType" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 1, 15, 51, 56, 93, DateTimeKind.Local).AddTicks(2401), null, null, "Lim Doc", 0 },
                    { 2, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(5621), null, null, "Simple Doc", 0 },
                    { 3, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(5692), null, null, "More Simple Doc", 0 },
                    { 4, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(5701), "https://images.unsplash.com/photo-1606694582797-0324662ab736?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=726&q=80", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", "Fake Doc", 2 },
                    { 5, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(7773), "https://images.unsplash.com/photo-1457694587812-e8bf29a43845?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=751&q=80", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", "Foko Doc", 2 },
                    { 6, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(7834), "https://images.unsplash.com/photo-1603796846097-bee99e4a601f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=667&q=80", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", "Foka Doc", 2 },
                    { 7, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(7841), null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", "New Custom Doc", 1 },
                    { 8, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(7846), null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", "Better Custom Doc", 1 },
                    { 9, new DateTime(2020, 12, 1, 15, 51, 56, 97, DateTimeKind.Local).AddTicks(7851), null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", "The best Custom Doc", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 9);
        }
    }
}
