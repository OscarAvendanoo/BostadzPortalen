SET QUOTED_IDENTIFIER ON;
SET NOCOUNT ON;
ALTER TABLE "Municipalities" NOCHECK CONSTRAINT ALL;
ALTER TABLE "RealEstateAgencies" NOCHECK CONSTRAINT ALL;
ALTER TABLE "PropertiesForSale" NOCHECK CONSTRAINT ALL;
--ALTER TABLE "AspNetUsers" NOCHECK CONSTRAINT ALL;

DELETE FROM "Municipalities";
DELETE FROM "RealEstateAgencies";
DELETE FROM "PropertiesForSale";
--DELETE FROM "AspNetUsers";

	--MUNICIPALITIES
BEGIN
  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"Municipalities"')) BEGIN
    SET IDENTITY_INSERT "Municipalities" ON
  END
BEGIN TRY
INSERT INTO "Municipalities" ("Id", "Name") VALUES
	('1', 'Umeå'),
	('2', 'Stockholm');
END TRY
BEGIN CATCH
PRINT 'Error inserting into "Municipalities": ' + ERROR_MESSAGE();
END CATCH
  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"Municipalities"')) BEGIN
    SET IDENTITY_INSERT "Municipalities" OFF
  END
END

	--REAL ESTATE AGENCIES
BEGIN
  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"RealEstateAgencies"')) BEGIN
    SET IDENTITY_INSERT "RealEstateAgencies" ON
  END
BEGIN TRY
INSERT INTO "RealEstateAgencies" ("RealEstateAgencyId", "AgencyName", "AgencyDescription", "AgencyLogoUrl") VALUES
	('1', 'Gottfridsson', 'Sveriges näst bästa mäklarbyrå', 'BilderKommerSen'),
	('2', 'Skanebo', 'Skåne är den bästa platsen på Gotland', 'BilderKommerSen');
END TRY
BEGIN CATCH
PRINT 'Error inserting into "RealEstateAgencies": ' + ERROR_MESSAGE();
END CATCH
  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"RealEstateAgencies"')) BEGIN
    SET IDENTITY_INSERT "RealEstateAgencies" OFF
  END
END

	--ASP NET USERS
--BEGIN
--  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"AspNetUsers"')) BEGIN
--    SET IDENTITY_INSERT "AspNetUsers" ON
--  END
--BEGIN TRY
--INSERT INTO "AspNetUsers" ("Id", "Email", "EmailConfirmed", "AgencyId", 
--							"UserName", "FirstName", "LastName", "PasswordHash", 
--							"PhoneNumber", "NormalizedEmail", "NormalizedUserName",
--							"AccessFailedCount", "Discriminator", "PhoneNumberConfirmed", "TwoFactorEnabled",
--							"LockoutEnabled") VALUES
--	('92d637e6-6a8d-421e-a118-7a29d0edc1e7', 'admin@demoapi.com', 'true', '1', 
--	'admin@demoapi.com', 'System', 'Admin', 'AQAAAAIAAYagAAAAEPRrA+z2V4XVE47d6ErGOt4tAuqkN1MIZgNzUM1mFnM8Jw+Mnyi4ddRRngz2mBpIWA==',
--	'0722661920', 'ADMIN@DEMOAPI.COM', 'ADMIN@DEMOAPI.COM',
--	'1', '1', 'false', 'false',
--	'false'),

--	('92b88e50-795f-4df6-90e0-8a7d9a179cb0', 'user@demoapi.com', 'true', '2', 
--	'user@demoapi.com', 'System', 'User', 'AQAAAAIAAYagAAAAEFijB/Z0QU8mRE5kfpjArHQDGsgjLMx0GXCljNd3Sg+F/tznlHrQ3+Li6EWmRApXGw==',
--	'0722661920', 'USER@DEMOAPI.COM', 'USER@DEMOAPI.COM',
--	'1', '1', 'false', 'false',
--	'false');
--END TRY
--BEGIN CATCH
--PRINT 'Error inserting into "AspNetUsers": ' + ERROR_MESSAGE();
--END CATCH
--  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"AspNetUsers"')) BEGIN
--    SET IDENTITY_INSERT "AspNetUsers" OFF
--  END
--END


	--PROPERTIES FOR SALE
BEGIN
  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"PropertiesForSale"')) BEGIN
    SET IDENTITY_INSERT "PropertiesForSale" ON
  END
BEGIN TRY
INSERT INTO "PropertiesForSale" ("PropertyForSaleId", "Address", "AskingPrice", "Description", 
								"LivingArea", "MonthlyFee", "MunicipalityId", "NumberOfRooms",
								"PlotArea", "RealtorId", "SupplementaryArea", "TypeOfProperty",
								"YearBuilt", "YearlyOperatingCost") VALUES
	('1', 'streetname', '1000000', 'house', 
	'24', '10000', '1', '3', 
	'24', '1', '24', '1', 
	'1999', '10000'),

	('2', 'streetname', '2000000', 'house', 
	'24', '10000', '2', '3', 
	'24', '1', '24', '2', 
	'1999', '10000');
END TRY
BEGIN CATCH
PRINT 'Error inserting into "PropertiesForSale": ' + ERROR_MESSAGE();
END CATCH
  IF EXISTS (SELECT 1  FROM sys.identity_columns WHERE object_id = OBJECT_ID('"Municipalities"')) BEGIN
    SET IDENTITY_INSERT "PropertiesForSale" OFF
  END
END