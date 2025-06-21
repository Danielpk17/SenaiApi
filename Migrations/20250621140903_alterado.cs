using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenaiApi.Migrations
{
    /// <inheritdoc />
    public partial class alterado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ////migrationBuilder.AlterColumn<int>(
            //    name: "Cidade",
            //    table: "Endereco",
            //    type: "integer",
            //    maxLength: 50,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "character varying(50)",
            //    oldMaxLength: 50);
            migrationBuilder.Sql(@"
            ALTER TABLE ""Endereco""
            ALTER COLUMN ""Cidade"" TYPE interger
            USING ""Cidade""::integer;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 50);
        }
    }
}
