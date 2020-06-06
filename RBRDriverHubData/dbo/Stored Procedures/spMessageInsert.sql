CREATE PROCEDURE [dbo].[spMessageInsert]
	@MessageId nvarchar (128),
	@MessageSubject nvarchar (50),
	@MessageContent nvarchar (Max),
	@MessageAttachment nvarchar (50),
	@MessageAdresseeId nvarchar (128),
	@MessageSenderId nvarchar (128),
	@MessageDate datetime,
	@UserId nvarchar (128)
AS
begin
	Insert into [dbo].[Messages](MessageId, MessageSubject, MessageContent, MessageAttachment, MessageAdresseeId,
	MessageSenderId, MessageDate, UserId)
	values (@MessageId, @MessageSubject, @MessageContent, @MessageAttachment, @MessageAdresseeId,
	@MessageSenderId, @MessageDate, @UserId) 
end