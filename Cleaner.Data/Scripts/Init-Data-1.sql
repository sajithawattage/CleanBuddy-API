INSERT INTO [dbo].[EquipmentCategory]([ID],[Name]) VALUES (1,'Blower')

INSERT INTO [dbo].[EquipmentCategory]([ID],[Name]) VALUES (2,'Vaccume Cleaner')

INSERT INTO [dbo].[EquipmentCategory]([ID],[Name]) VALUES (3,'Steam Cleaner')

INSERT INTO [dbo].[EquipmentCategory]([ID],[Name]) VALUES (4,'Wet & Dry Vaccume')

INSERT INTO [dbo].[EquipmentCategory]([ID],[Name]) VALUES (5,'Scrubber')

GO


INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('R2E220-AA4', 'EBM-PAPST', 'Fan Blower, R2E Series', 1, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('RLF35-8/14N','EBM-PAPST', 'Fan Blower, RLF 35 Series', 1, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('R2E190-RA26', 'EBM-PAPST', 'Fan Blower R2E 190 Series', 1, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('D2E133-AM26', 'EBM-PAPST', 'AC Centrifugel', 1, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('R2K150-AC26', 'EBM-PAPST', 'Fan Blower R2K Series', 1, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('231700', 'VERMASON', 'Vaccume Cleaner, ESD, 1.3 kW', 2, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('497ABF', 'VERMASON', '3M -Toner Vaccume', 2, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('SV-MPF2', 'SCS', 'Vaccume Filter', 2, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('TE-VC-1930SA', 'EINHELL', 'Vaccume Cleaner Wet/Dry, 19000 Pa, 1.5kW', 4, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('TE-VC-1820SA', 'EINHELL', 'Vaccume Cleaner, 1250W 20L Wet/Dry', 4, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

INSERT INTO [dbo].[Equipment] ([Code],[Brand],[Model],[CategoryID],[PurchasedFrom],[PurchaseDate],[WarrantyExpire]) VALUES ('497ABG', 'SCS', 'ELECTRONIC VACCUME 120v', 2, 'Element 14', GETDATE(), DATEADD(YEAR, 5, GETDATE()))

GO

 

INSERT INTO [dbo].[WorkType] ([WorkTypeName]) VALUES ('Full-Time')

INSERT INTO [dbo].[WorkType] ([WorkTypeName]) VALUES ('Part-Time')

GO

 

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (1,'ADAMS', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'ADAMS',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (2,'KEN', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'KEN',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (3,'DILAN', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'DILAN',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (4,'MIKE', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'MIKE',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (5,'ROB', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'ROB',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (6,'DAVID', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'DAVID',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (7,'JOHN', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'JOHN',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (8,'MARY', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'MARY',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (9,'KEVIN', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'KEVIN',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

INSERT INTO [dbo].[Employee]

([EmployeeID],[Name],[ContactNo],[NationalIDNumber],[LoginID],[OrganizationLevel],[JobTitle],[BirthDate],[MaritalStatus],[Gender],[HireDate],[SalariedFlag] ,[VacationHours],[SickLeaveHours],[CurrentFlag],[ParttimeFlag],[ModifiedDate])

VALUES (10,'TERRY', CAST(RAND() * 10000000 AS INT), CAST(CAST(RAND() * 10000000 AS INT) AS VARCHAR),'TERRY',2,'Cleaner', DATEADD(YEAR, -20, GETDATE()),'S','M', DATEADD(YEAR, -5, GETDATE()),1,20,20,1,0,GETDATE())

GO

 

INSERT INTO [dbo].[Address] ([Name],[StreetAddress],[City],[PostalCode],[State],[Country]) VALUES ('Broke L Loewe', '42 Quayside Vista' ,'Kingston' ,537670 ,'Australian Capital Territory' ,'Australia')

INSERT INTO [dbo].[Address] ([Name],[StreetAddress],[City],[PostalCode],[State],[Country]) VALUES ('Danial G lyttle', '4 Marlin Avenue' ,'Bigga' ,2583 ,'NSW' ,'Australia')

INSERT INTO [dbo].[Address] ([Name],[StreetAddress],[City],[PostalCode],[State],[Country]) VALUES ('Xavioer Broke', '3 Bailey Street' ,'Willatook' ,3287 ,'VIC' ,'Australia')

INSERT INTO [dbo].[Address] ([Name],[StreetAddress],[City],[PostalCode],[State],[Country]) VALUES ('David Simon', '42 Queen Avenue' ,'BiggaTook' ,3457 ,'VIC' ,'Australia')

GO

 

INSERT INTO [dbo].[Contractor] ([AddressID],[Name],[EmailID],[ContactPerson],[ContactNo],[ABN],[PaymentOption],[InvoiceDate],[Note])

VALUES (1,'Broke L Loewe','broke.loewe@gmial.com','Broke L Loewe',CAST(RAND() * 10000000 AS INT),CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR),1,GETDATE(),'')

GO

 

INSERT INTO [dbo].[SubContractor]([ContractorID],[Name],[AddressID],[ABN],[EmailAddress]) VALUES (1,'Danial G lyttle',2 ,CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR),'danial.lyttle@gmial.com')

INSERT INTO [dbo].[SubContractor]([ContractorID],[Name],[AddressID],[ABN],[EmailAddress]) VALUES (1,'Xavioer Broke',3 ,CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR),'xavioer.broke@gmial.com')

 

GO

 

 

