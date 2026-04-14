using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTwoMonthsToAuctionEnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            UPDATE ""Auctions""
            SET ""AuctionEnd"" = ""AuctionEnd"" + INTERVAL '2 months'
            ");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            UPDATE ""Auctions""
            SET ""AuctionEnd"" = ""AuctionEnd"" - INTERVAL '2 months'
            ");
        }
    }
}
