using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorsTaskithImprovements.Migrations
{
    /// <inheritdoc />
    public partial class IsertDataInSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Specializations (Name) VALUES('Cardiology'),    ('Dermatology') ,    ('Neurology'),\r\n    ('Pediatrics'),\r\n    ('Orthopedics'),\r\n    ('General Surgery'),\r\n    ('Ophthalmology'),\r\n    ('Psychiatry'),\r\n    ('Oncology'),\r\n    ('Endocrinology'),\r\n    ('Gastroenterology'),\r\n    ('Pulmonology'),\r\n    ('Urology'),\r\n    ('Rheumatology'),\r\n    ('Nephrology');\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
