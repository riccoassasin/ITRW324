﻿CREATE TABLE [dbo].[LookupTable_NotificationTypes] (
    [NotificationTypeID]          INT           IDENTITY (1, 1) NOT NULL,
    [NotificationType]            VARCHAR (50)  CONSTRAINT [DF_LookupTableNotificationTypes_NotificationType] DEFAULT ('Unknown') NOT NULL,
    [NotificationMessageTemplate] VARCHAR (MAX) CONSTRAINT [DF_LookupTable_NotificationTypes_NotificationMessageTemplate] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_LookupTableNotificationTypes] PRIMARY KEY CLUSTERED ([NotificationTypeID] ASC)
);



