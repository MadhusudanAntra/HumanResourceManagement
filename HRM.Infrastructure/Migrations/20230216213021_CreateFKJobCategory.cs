using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateFKJobCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_JobRequirement_JobCategoryId",
                table: "JobRequirement",
                column: "JobCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequirement_JobCategory_JobCategoryId",
                table: "JobRequirement",
                column: "JobCategoryId",
                principalTable: "JobCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobRequirement_JobCategory_JobCategoryId",
                table: "JobRequirement");

            migrationBuilder.DropIndex(
                name: "IX_JobRequirement_JobCategoryId",
                table: "JobRequirement");
        }
    }
}
