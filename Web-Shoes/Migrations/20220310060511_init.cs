using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Shoes.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cu_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    couponPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    deviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_NameImg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_MenuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size7 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size7_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size8 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size8_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size9 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size9_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size10 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size10_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size11 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size11_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size12 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size12_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size13 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size13_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size14 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size14_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Technologies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInRoleModel",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoleModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bill_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartsDevice",
                columns: table => new
                {
                    cartd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cartd_DeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDevice", x => x.cartd_Id);
                    table.ForeignKey(
                        name: "FK_CartsDevice_Device_cartd_DeviceId",
                        column: x => x.cartd_DeviceId,
                        principalTable: "Device",
                        principalColumn: "deviceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInCategories",
                columns: table => new
                {
                    pic_CategoriesId = table.Column<int>(type: "int", nullable: false),
                    pic_productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCategories", x => new { x.pic_productId, x.pic_CategoriesId });
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Categories_pic_CategoriesId",
                        column: x => x.pic_CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Products_pic_productId",
                        column: x => x.pic_productId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductColorlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitPickup = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivering = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivered = table.Column<bool>(type: "bit", nullable: false),
                    bill_Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    review_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    review_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    review_ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_review_UserId",
                        column: x => x.review_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubReview",
                columns: table => new
                {
                    subReview_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subReview_Commnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    subReview_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    subreview_SubReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_DateCommnet = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReview", x => x.subReview_Id);
                    table.ForeignKey(
                        name: "FK_SubReview_Users_subReview_UserId",
                        column: x => x.subReview_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    wl_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wl_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.wl_Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Users_wl_UserId",
                        column: x => x.wl_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCartDevices",
                columns: table => new
                {
                    picd_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_ProductId = table.Column<int>(type: "int", nullable: false),
                    picd_amount = table.Column<int>(type: "int", nullable: false),
                    picd_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picd_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCartDevices", x => new { x.picd_CartId, x.picd_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_CartsDevice_picd_CartId",
                        column: x => x.picd_CartId,
                        principalTable: "CartsDevice",
                        principalColumn: "cartd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_Products_picd_ProductId",
                        column: x => x.picd_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_ProductId = table.Column<int>(type: "int", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false),
                    pic_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pic_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewInproduct",
                columns: table => new
                {
                    rip_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rip_ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInproduct", x => new { x.rip_ProductId, x.rip_ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Products_rip_ProductId",
                        column: x => x.rip_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Reviews_rip_ReviewId",
                        column: x => x.rip_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubReviewInReview",
                columns: table => new
                {
                    SRiR_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SRiR_SubReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReviewInReview", x => new { x.SRiR_ReviewId, x.SRiR_SubReviewId });
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_Reviews_SRiR_ReviewId",
                        column: x => x.SRiR_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_SubReview_SRiR_SubReviewId",
                        column: x => x.SRiR_SubReviewId,
                        principalTable: "SubReview",
                        principalColumn: "subReview_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInWishlist",
                columns: table => new
                {
                    piw_WishlistId = table.Column<int>(type: "int", nullable: false),
                    piw_ProductId = table.Column<int>(type: "int", nullable: false),
                    piw_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInWishlist", x => new { x.piw_WishlistId, x.piw_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Products_piw_ProductId",
                        column: x => x.piw_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Wishlists_piw_WishlistId",
                        column: x => x.piw_WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "wl_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { 1, "women", "", "" },
                    { 2, "Man", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Email", "Contact_Phone", "Contact_Website" },
                values: new object[] { 1, " 123, An Lac A Ward, Binh Tan District, HCM", "admin@gmail.com", "0123456789", "https://shoes.com" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { 1, "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "3376e115-5452-4324-9255-048d99e70ff7", "code10", 10 },
                    { "d1d9cc7c-9507-41bd-bbdc-e4e23bba30c5", "code50", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Brand", "pd_Color", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Material", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size", "pd_Size10", "pd_Size10_5", "pd_Size11", "pd_Size11_5", "pd_Size12", "pd_Size12_5", "pd_Size13", "pd_Size13_5", "pd_Size14", "pd_Size14_5", "pd_Size7", "pd_Size7_5", "pd_Size8", "pd_Size8_5", "pd_Size9", "pd_Size9_5", "pd_Style", "pd_Technologies", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { 15, "Nike", "Pollen/Pink Blast/Black", "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.", "https://drive.google.com/uc?id=170Vm7Py5XUTDhFLn2tLt0CCBftOKbdFd", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", "1", "2", "3", "4", 10000, 4, 500, "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "CU9224-700", "3", false },
                    { 14, "Nike", "Beach/Topaz Gold/Bright Crimson/Black", "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "https://drive.google.com/uc?id=1sKbuA1SGLb7l947dvLYBnV2Nzj9thvFB", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", "1", "2", "3", "4", 10000, 4, 500, "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "BV2078-200", "3", false },
                    { 13, "Nike", "Beach/Topaz Gold/Bright Crimson/Black", "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "https://drive.google.com/uc?id=1dzvmQMDzkUdh79Sw2Z0itgm1I12xwkA2", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", "1", "2", "3", "4", 10000, 4, 500, "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "BV2078-200", "3", false },
                    { 12, "Nike", "Ghost/Ashen Slate/Obsidian Mist/Obsidian", "We could use a lot of superlatives to describe the Nike Air Max 2021.We could tell you that we've incorporated recycled materials to design a sneaker with at least 20% recycled content.Or that the new Air cushioning unit underfoot is our most revolutionary.Perhaps we'd call it the the pinnacle of comfort waxing poetic about the cored-out foam midsole that gives you the lightest, softest feel.But maybe we just say it's modern meets technical with a splash of heritage DNA.What fun is there in giving away the surprises?", "https://drive.google.com/uc?id=1UZX6cca2sF8sj5pO70ub8Gf23i1Zp6jO", "https://drive.google.com/uc?export=download&id=184n1JhhW9eVPiPU01g2LsrQaga75xZoT", "https://drive.google.com/uc?export=download&id=1vQa7rOZejxU29875pv8ne4fyrxt8WEdH", "https://drive.google.com/uc?export=download&id=1shZnWARtq5SwsibFewT6Km0duAMAkpoZ", "3", "3", "Nike Air Max 2021", "1", "2", "3", "4", 10000, 4, 500, "We could use a lot of superlatives to describe the Nike Air Max 2021.We could tell you that we've incorporated recycled materials to design a sneaker with at least 20% recycled content.Or that the new Air cushioning unit underfoot is our most revolutionary.Perhaps we'd call it the the pinnacle of comfort; waxing poetic about the cored-out foam midsole that gives you the lightest, softest feel.But maybe we just say it's modern meets technical with a splash of heritage DNA.What fun is there in giving away the surprises?", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DA1925-002", "3", false },
                    { 11, "Nike", "Black/Wolf Grey/Cool Grey/White", "Inspired by the community art spaces of Barcelona, the Nike SB Zoom Blazer Mid Premium is made from a collage of materials like suede, leather and canvas.The design is elevated with a multi-coloured Nike embroidery on the heel and a mismatched Swoosh, capped off by a contrasting herringbone sole.", "https://drive.google.com/uc?id=1vSAQa_8Evmm1tkOzODtMz4GgWTHH5jq-", "https://drive.google.com/uc?export=download&id=1EERkVDnTn-m3dfv2eUCxIGIKZuENwZIu", "https://drive.google.com/uc?export=download&id=1B6Ae6KBW8vwsPz9K1btBZuSC9OZPn5Hu", "https://drive.google.com/uc?export=download&id=1WS6keGw5BUnYs04Ji-yuVf8_CFdh-mRz", "3", "3", "Nike SB Zoom Blazer Mid Premium", "1", "2", "3", "4", 10000, 4, 500, "Inspired by the community art spaces of Barcelona, the Nike SB Zoom Blazer Mid Premium is made from a collage of materials like suede, leather and canvas.The design is elevated with a multi-coloured Nike embroidery on the heel and a mismatched Swoosh, capped off by a contrasting herringbone sole.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DA8854-001", "3", false },
                    { 10, "Nike", "Light Mulberry/Flash Crimson", "Fast, rugged and just as at home in the city as it is in deserts, canyons and mountains, the Nike ACG Mountain Fly Low is ready for whatever you throw at it.The lightweight Ripstop and synthetic upper is durable and airy, while the easy-to-cinch lacing system adds on-the-go personalisation.The sticky rubber outsole brings crag-inspired traction as the soft Nike React foam sole delivers undisputed comfort whether you're pounding the pavement in the city wilds or leaping rock to rock in Joshua Tree.", "https://drive.google.com/uc?id=1Dc-PtwoLK8v4YbJ6YWfuhKJ8KgqTs8tI", "https://drive.google.com/uc?export=download&id=1nm4RlNHYo8JP3KtJvT_bvFqOQ5vEGY2m", "https://drive.google.com/uc?export=download&id=1DcJqtgAnjTxw_zZyvTEsktIcR5pljTk6", "https://drive.google.com/uc?export=download&id=1bjUxZvzpqdlFxn5GrukZilFWpwx5UyvX", "3", "3", "Nike ACG Mountain Fly Low", "1", "2", "3", "4", 10000, 4, 500, "Fast, rugged and just as at home in the city as it is in deserts, canyons and mountains, the Nike ACG Mountain Fly Low is ready for whatever you throw at it.The lightweight Ripstop and synthetic upper is durable and airy, while the easy-to-cinch lacing system adds on-the-go personalisation.The sticky rubber outsole brings crag-inspired traction as the soft Nike React foam sole delivers undisputed comfort whether you're pounding the pavement in the city wilds or leaping rock to rock in Joshua Tree.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DC9045-500", "3", false },
                    { 9, "Nike", "Grey Fog/Melon Tint/Metallic Silver", "Take on the tough terrain of the outdoors.The Nike ACG Air Nasu 2 steps up the durability with Ripstop on the upper and reinforced details to stand up to the rigours of the trail.It has mesh elements up top and a lining within to help keep you on your path with a breathable, supportive feel.A sticky rubber outsole is highlighted with lugs that are designed to help give you traction when navigating wet and rocky surfaces.", "https://drive.google.com/uc?id=1lbsJAVJkbf-_V6pKzm1CZcAJfIsjjv0o", "https://drive.google.com/uc?export=download&id=1kRRsPNYRT0V5f7LKVRmJp82QMWJVYxeQ", "https://drive.google.com/uc?export=download&id=15wsxpi791SMVlR2Cn7k6FAbCOgUt3I2U", "https://drive.google.com/uc?export=download&id=1XdL62dPC4dpqNdc-BhHnrkm2Hl6morgo", "3", "3", "Nike ACG Air Nasu 2", "1", "2", "3", "4", 10000, 4, 500, "Take on the tough terrain of the outdoors.The Nike ACG Air Nasu 2 steps up the durability with Ripstop on the upper and reinforced details to stand up to the rigours of the trail.It has mesh elements up top and a lining within to help keep you on your path with a breathable, supportive feel.A sticky rubber outsole is highlighted with lugs that are designed to help give you traction when navigating wet and rocky surfaces.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DC8296-001", "3", false },
                    { 8, "Nike", "Metallic Silver/Black/White/Persian Violet", "Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original silver bullet colours, it lets you ride in first-class comfort.", "https://drive.google.com/uc?id=1TOlxRiO2y8v05O7ZPDBaPO2OnFPrjIY7", "https://drive.google.com/uc?export=download&id=1-zJ4GbHm0iys-PO3XwWHTOB1LLlMQhaR", "https://drive.google.com/uc?export=download&id=1UUI3tV4jyTpPvv8akrL0jcJXDuIWzjM1", "https://drive.google.com/uc?export=download&id=1AXIRrKM96HazbtzcSxhKY59wFjEm1zVe", "3", "3", "Nike Air Max 97", "1", "2", "3", "4", 10000, 4, 500, "Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original silver bullet colours, it lets you ride in first-class comfort.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DJ0717-001", "3", false },
                    { 7, "Nike", "Hasta/Thunder Blue/Bucktan/Obsidian", "Made from at least 20% recycled content by weight, the Nike Air Max 97 SE takes a fresh step towards the future of footwear.The upper features 100% recycled canvas and accents of cork.The embroidered cork graphic on the tongue nods to the plant used in the shoe.", "https://drive.google.com/uc?id=1BYoyjK2a0qyq6zPdr1enQBluAkifs_4d", "https://drive.google.com/uc?export=download&id=1cITDpeROBtZfWCsBYRj-obyMYR4SZQYX", "https://drive.google.com/uc?export=download&id=1Suli5ByGxovAPGmd_kM6GIenMTy32JPe", "https://drive.google.com/uc?export=download&id=1SkQjussYGb4HIrIIk0URRFY-L0rZjEpI", "3", "3", "Nike Air Max 97 SE", "1", "2", "3", "4", 10000, 4, 500, "Made from at least 20% recycled content by weight, the Nike Air Max 97 SE takes a fresh step towards the future of footwear.The upper features 100% recycled canvas and accents of cork.The embroidered cork graphic on the tongue nods to the plant used in the shoe.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DC3986-300", "3", false },
                    { 3, "Nike", "Cream II/Orange/Black/White", "Bringing the classic BRS athletics style into a modern realm with at least 20% recycled materials by weight, the Nike Waffle One Crater is eye-candy for your feet.The playful speckled look on the midsole is created from Crater Foam, a cushiony material made from Nike Grind rubber and Nike foam materials.And for added depth, the sport-inspired upper includes transparent mesh made from recycled polyester.", "https://drive.google.com/uc?id=1raFVtP42IkQ1t-lPPRFi_E5X4iJ0NW4-", "https://drive.google.com/uc?export=download&id=1kFLigFwBNPiqYhIOs2QRL39nRo0IJYWS", "https://drive.google.com/uc?export=download&id=1KZJQR5jt9rzVOBxfUZRx-tjKoO3dKNDJ", "https://drive.google.com/uc?export=download&id=10oXph87Rn43M13WNaxJWpL0XS_Mf_JFt", "3", "3", "Nike Waffle One Crater", "1", "2", "3", "4", 10000, 4, 500, "Bringing the classic BRS athletics style into a modern realm with at least 20% recycled materials by weight, the Nike Waffle One Crater is eye-candy for your feet.The playful speckled look on the midsole is created from Crater Foam, a cushiony material made from Nike Grind rubber and Nike foam materials.And for added depth, the sport-inspired upper includes transparent mesh made from recycled polyester.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DC2650-200", "3", false },
                    { 5, "Nike", "Dark Driftwood/Sail/Light Chocolate/Black", "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 stays true to its roots with the iconic Waffle sole, stitched overlays and classic TPU accents on the heel and eyestays.A variety of materials on the upper gives a modern look, while Max Air cushioning adds comfort to your journey.", "https://drive.google.com/uc?id=1ov844eV9xL19atvdLqYtsG6oLz1XPT0g", "https://drive.google.com/uc?export=download&id=1kxFSmfxV3eYg_2ikz2fF0G4UoXPedRJG", "https://drive.google.com/uc?export=download&id=1DxgC1AAKFgDxKSOtBnp_kytP3TlZ-kqr", "https://drive.google.com/uc?export=download&id=1dmp8HCRjPGXUyT3TkkHLZNiP9utabt_S", "3", "3", "Nike Air Max 90", "1", "2", "3", "4", 10000, 4, 500, "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 stays true to its roots with the iconic Waffle sole, stitched overlays and classic TPU accents on the heel and eyestays.A variety of materials on the upper gives a modern look, while Max Air cushioning adds comfort to your journey.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DB0625-200", "3", false },
                    { 4, "Nike", "Hemp/Sand Drift/Light Orewood Brown/Summit White", "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 Premium stays true to its roots, with the iconic Waffle outsole, stitched overlays and classic TPU accents. Fresh colours give a modern look while Max Air cushioning adds comfort to your journey.", "https://drive.google.com/uc?id=1M0_A-sZfffj7gncHmbj88dHvvqXM1eEa", "https://drive.google.com/uc?export=download&id=1K85ItvCTycDSRX9p1Jbzm7Egg5l6OdRa", "https://drive.google.com/uc?export=download&id=1b5FDJjrsLKAlj7zBVGLoxdp_gaVTFkVE", "https://drive.google.com/uc?export=download&id=1LSQUzknGNiwOIVtHFNmPhGSh8ZE0CFJx", "3", "3", "Nike Air Max 90 Premium", "1", "2", "3", "4", 10000, 4, 500, "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 Premium stays true to its roots, with the iconic Waffle outsole, stitched overlays and classic TPU accents. Fresh colours give a modern look while Max Air cushioning adds comfort to your journey.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DA1641-201", "3", false },
                    { 16, "Nike", "Pollen/Pink Blast/Black", "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.", "https://drive.google.com/uc?id=1WlG6_0L1Hz6pXP50zUsaz2IPxZg6kjEi", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", "1", "2", "3", "4", 10000, 4, 500, "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "CU9224-700", "3", false },
                    { 2, "Nike", "Medium Olive/Carbon Green/Sail/Black", "The radiance lives on in the Nike Air Force 1 GORE-TEX, the b-ball OG that puts a fresh spin on what you know best: crisp leather, bold colours and the perfect amount of flash to make you shine.This time it's clad in GORE-TEX technology.", "https://drive.google.com/uc?id=1aaIG6S0bGnm5uhxHVBXy_BkEDb867O0-", "https://drive.google.com/uc?export=download&id=1Y4gS9zvfZdshJc4YySjz13ZGlMIft4kv", "https://drive.google.com/uc?export=download&id=1AyILI7QsTzqBPE6OvDMZpY7OAtxjkuH8", "https://drive.google.com/uc?export=download&id=1WT_vD4nC_szHPH9LVbl_UztqvXlmqs2e", "2", "2", "Nike Air Force 1", "1", "2", "3", "4", 10000, 5, 500, "The radiance lives on in the Nike Air Force 1 GORE-TEX, the b-ball OG that puts a fresh spin on what you know best: crisp leather, bold colours and the perfect amount of flash to make you shine.This time it's clad in GORE-TEX technology.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DM6435-222", "2", false },
                    { 1, "Nike", "White/White", "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.", "https://drive.google.com/open?id=1y-bME8oi9DccN-zG_Eo-aChLBs8pwVEI", "https://drive.google.com/uc?export=download&id=1YBpU6fwcCzV18ho__mhCCO0yD8ES-ef7", "https://drive.google.com/uc?export=download&id=1sBANC4Og5eumFJBTVLYGIp2qTBKfwSzh", "https://drive.google.com/uc?export=download&id=1A74yTUs0Lmya24nL5UPG8N6cV7GFhn5a", "1", "1", "Nike Air Force 1 07", "1", "2", "3", "4", 10000, 5, 500, "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "CW2288-111", "1", false },
                    { 6, "Nike", "Moon Fossil/Black", "From city hikes to canyon trails and long walks on the beach, the Nike ACG Air Deschutz + is built to feel comfortable.It's got a classic '90s look and rugged outdoor-inspired design, with plush padding around the ankle for support.A heavy-duty webbing strap and adjustable hook-and-loop closure keep you focused on the journey ahead.", "https://drive.google.com/uc?id=1q5roIlNeK4nQtTmqAqz4wWAC6kI0aGQq", "https://drive.google.com/uc?export=download&id=1ezOB26pX2VmYZC1uVja89pZ4QJty7hXe", "https://drive.google.com/uc?export=download&id=1IiK2AM0M9bKRhSBofRlNSR8ZhseQsUmG", "https://drive.google.com/uc?export=download&id=1rctQk2u8mHcN41-GdWdCfHSeSRvDr1dr", "3", "3", "Nike ACG Air Deschutz +", "1", "2", "3", "4", 10000, 4, 500, "From city hikes to canyon trails and long walks on the beach, the Nike ACG Air Deschutz + is built to feel comfortable.It's got a classic '90s look and rugged outdoor-inspired design, with plush padding around the ankle for support.A heavy-duty webbing strap and adjustable hook-and-loop closure keep you focused on the journey ahead.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "DC9092-001", "3", false }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "89dc395d-cea9-4ee3-b809-088941664113", "admin", "AppRole", "admin", null },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "1a196b85-29f7-42bd-a43a-14072f1ed498", "Staff", "AppRole", "staff", null }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "957eba1f-5ffe-4ce3-91d0-d73efba552dd", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAENErAMeuQvhLB5kyWozM8oWLYGYtIqC9jcpgCeZDckM95Y47VLoCcckTmxmW+lkS1g==", null, false, "ca85b63f-3ada-4c27-81b3-30f6a19572ce", false, "Staff", null, null, null, null, null, null, null, null },
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "6be47472-cdfb-4037-ab19-593fb4dc1b88", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJE0usj8Jv+hMj9aO5zSox11LLBmGY8X43HcWixN3hj28WTHJIAmynh7rLqIfBlSJg==", null, false, "65761e46-bf8e-4078-bd05-b235c56acd19", false, "Admin", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancelled", "bill_Confirmation", "bill_DatetimeOrder", "bill_Delivered", "bill_Delivering", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductColorlist", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_Quantity", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation", "bill_WaitPickup" },
                values: new object[,]
                {
                    { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2022, 3, 10, 13, 5, 10, 671, DateTimeKind.Local).AddTicks(610), false, false, 0, false, "", 2000, "Check Payment", "Blue|Red|Black|Green", "1|2|3|4", "product 1|product 2| product 3| product 4", "550|450|350|640", "7|8|9|14", "1|1|2|1", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false },
                    { "AFD66490-12F5-4EA7-BFF6-425624290D6D", false, true, new DateTime(2022, 3, 10, 13, 5, 10, 682, DateTimeKind.Local).AddTicks(7170), false, false, 0, false, "", 2100, "Check Payment", "Blue|Red|Black|Green", "5|6|7|8", "product 5|product 6| product 7| product 8", "550|450|350|640", "7|8|9|14", "1|1|2|2", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_UserID" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "72309286-ECBB-4D20-AD95-2819D31E3400", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "review_id", "review_Comment", "review_HideStatus", "review_ReviewType", "review_UploadTime", "review_UserId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "Good1", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "C2A543C2-B1E2-4DC5-A131-9137E4673FA6", "Good3", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "Good2", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "27d3eb61-3871-43ba-b465-f7d43fdd15c3", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "e2426809-f085-4013-bb02-df03b6dcb229", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "453f5945-4bf0-4b25-962c-2207db578c28", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "wl_Id", "wl_UserId" },
                values: new object[] { 1, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", 1, 2, "blue", "7" },
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", 2, 3, "blue", "7.5" },
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", 3, 1, "blue", "8" }
                });

            migrationBuilder.InsertData(
                table: "ProductInWishlist",
                columns: new[] { "piw_ProductId", "piw_WishlistId", "piw_amount" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { 1, "EEBA6608-AB75-4E83-909F-604B1A06F16C" },
                    { 1, "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { 1, "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "27d3eb61-3871-43ba-b465-f7d43fdd15c3" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "e2426809-f085-4013-bb02-df03b6dcb229" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "453f5945-4bf0-4b25-962c-2207db578c28" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDevice_cartd_DeviceId",
                table: "CartsDevice",
                column: "cartd_DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCartDevices_picd_ProductId",
                table: "ProductInCartDevices",
                column: "picd_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInWishlist_piw_ProductId",
                table: "ProductInWishlist",
                column: "piw_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCategories_pic_CategoriesId",
                table: "ProductsInCategories",
                column: "pic_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewInproduct_rip_ReviewId",
                table: "ReviewInproduct",
                column: "rip_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_review_UserId",
                table: "Reviews",
                column: "review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubReview_subReview_UserId",
                table: "SubReview",
                column: "subReview_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReviewInReview_SRiR_SubReviewId",
                table: "SubReviewInReview",
                column: "SRiR_SubReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_wl_UserId",
                table: "Wishlists",
                column: "wl_UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInCartDevices");

            migrationBuilder.DropTable(
                name: "ProductInWishlist");

            migrationBuilder.DropTable(
                name: "ProductsInCategories");

            migrationBuilder.DropTable(
                name: "ReviewInproduct");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SubReviewInReview");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInRoleModel");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CartsDevice");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubReview");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
