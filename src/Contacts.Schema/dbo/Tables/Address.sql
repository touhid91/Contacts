CREATE TABLE [dbo].[Address] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [House]    NVARCHAR (20)    NULL,
    [Road]     NVARCHAR (20)    NULL,
    [Area]     NVARCHAR (20)    NULL,
    [District] NVARCHAR (20)    NULL,
    [Country]  NVARCHAR (20)    NULL,
    CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

