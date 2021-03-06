﻿CREATE TABLE [dbo].[PrivateFilesSharedWithUsers] (
    [FileSharedWithUserID]   INT      IDENTITY (1, 1) NOT NULL,
    [UserIDPersonSharedWith] INT      NULL,
    [FileID]                 INT      NOT NULL,
    [DateShared]             DATETIME NOT NULL,
    CONSTRAINT [PK_FileSharedWithUsers] PRIMARY KEY CLUSTERED ([FileSharedWithUserID] ASC),
    CONSTRAINT [FK_FileSharedWithUsers_AspNetUsers] FOREIGN KEY ([UserIDPersonSharedWith]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_FileSharedWithUsers_Files] FOREIGN KEY ([FileID]) REFERENCES [dbo].[Files] ([FileID])
);

