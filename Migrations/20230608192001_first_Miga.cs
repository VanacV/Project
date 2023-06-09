using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    public partial class first_Miga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorization",
                columns: table => new
                {
                    Auth_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorization", x => x.Auth_Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Shop_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Shop_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Auth_Id = table.Column<int>(type: "int", nullable: false),
                    AuthorizationAuth_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Authorization_AuthorizationAuth_Id",
                        column: x => x.AuthorizationAuth_Id,
                        principalTable: "Authorization",
                        principalColumn: "Auth_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shop_Id = table.Column<int>(type: "int", nullable: false),
                    Shop_Id1 = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_Product_Shop_Shop_Id1",
                        column: x => x.Shop_Id1,
                        principalTable: "Shop",
                        principalColumn: "Shop_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shop_Rating",
                columns: table => new
                {
                    Shop_Id = table.Column<int>(type: "int", nullable: false),
                    Shop_Rat_Id = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_Rating", x => x.Shop_Id);
                    table.ForeignKey(
                        name: "FK_Shop_Rating_Shop_Shop_Id",
                        column: x => x.Shop_Id,
                        principalTable: "Shop",
                        principalColumn: "Shop_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Malling",
                columns: table => new
                {
                    email = table.Column<int>(type: "int", nullable: false),
                    Malling_Id = table.Column<int>(type: "int", nullable: false),
                    email_User = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malling", x => x.email);
                    table.ForeignKey(
                        name: "FK_Malling_Users_email",
                        column: x => x.email,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Composition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comp_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comp_Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Composition_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sum_Cost = table.Column<int>(type: "int", nullable: false),
                    With_Post_Card = table.Column<bool>(type: "bit", nullable: false),
                    Post_Card = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delivery_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_info = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Products_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_Payment_Product_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Rating",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Rat_Id = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Rating", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_Product_Rating_Product_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Composition_ProductId",
                table: "Composition",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Product_Id",
                table: "Payment",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_User_id",
                table: "Payment",
                column: "User_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Shop_Id1",
                table: "Product",
                column: "Shop_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuthorizationAuth_Id",
                table: "Users",
                column: "AuthorizationAuth_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Composition");

            migrationBuilder.DropTable(
                name: "Malling");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Product_Rating");

            migrationBuilder.DropTable(
                name: "Shop_Rating");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Authorization");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
