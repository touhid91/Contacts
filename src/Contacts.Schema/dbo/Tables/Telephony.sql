CREATE TABLE [dbo].[Telephony] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [CountryCode]      INT              NOT NULL,
    [CarrierCode]      INT              NOT NULL,
    [SubscriberNumber] INT              NOT NULL,
    [PersonId]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Telephony] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Telephony_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

