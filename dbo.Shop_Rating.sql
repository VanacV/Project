CREATE TABLE [dbo].[Shop_Rating] (
    [Shop_Id]     INT            NOT NULL,
    [Shop_Rat_Id] INT            NOT NULL,
    [Rate]        REAL           NOT NULL,
    [Comment]     NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Shop_Rating] PRIMARY KEY CLUSTERED ([Shop_Id] ASC),
    CONSTRAINT [FK_Shop_Rating_Shop_Shop_Id] FOREIGN KEY ([Shop_Id]) REFERENCES [dbo].[Shop] ([Shop_Id]) ON DELETE CASCADE
);

