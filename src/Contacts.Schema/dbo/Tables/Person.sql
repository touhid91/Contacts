CREATE TABLE [dbo].[Person] (
    [Id]                 UNIQUEIDENTIFIER NOT NULL,
    [FirstName]          NVARCHAR (50)    NOT NULL,
    [LastName]           NVARCHAR (50)    NOT NULL,
    [PresentAddressId]   UNIQUEIDENTIFIER NULL,
    [PermanentAddressId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_PERSON] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Person_PermanentAddress] FOREIGN KEY ([PermanentAddressId]) REFERENCES [dbo].[Address] ([Id]),
    CONSTRAINT [FK_Person_PresentAddress] FOREIGN KEY ([PresentAddressId]) REFERENCES [dbo].[Address] ([Id])
);

