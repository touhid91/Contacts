CREATE TABLE [dbo].[Email] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [Username] NVARCHAR (20)    NOT NULL,
    [Domain]   NVARCHAR (20)    NOT NULL,
    [Provider] NCHAR (10)       NOT NULL,
    [PersonId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Email_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

