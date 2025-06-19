using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorsTaskithImprovements.Migrations
{
    /// <inheritdoc />
    public partial class IsertDataInDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Doctors (Name, Img, SpecializationId)\r\nVALUES\r\n    ('Dr. John Smith', 'doctor1.jpg', 1),\r\n    ('Dr. Emily Davis', 'doctor2.jpg', 2),\r\n    ('Dr. Michael Lee', 'doctor3.jpg', 3),\r\n    ('Dr. Sarah Johnson', 'doctor4.jpg', 4),\r\n    ('Dr. David Kim', 'doctor5.jpg', 5),\r\n    ('Dr. Laura Martinez', 'doctor6.jpg', 6),\r\n    ('Dr. Robert Brown', 'doctor1.jpg', 7),\r\n    ('Dr. Angela Wilson', 'doctor2.jpg', 8),\r\n    ('Dr. Steven Clark', 'doctor3.jpg', 9),\r\n    ('Dr. Lisa Adams', 'doctor4.jpg', 10);\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Truncate table Doctors");
        }
    }
}
