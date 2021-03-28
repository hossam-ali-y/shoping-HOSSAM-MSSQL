IF EXISTS (SELECT * FROM sysobjects WHERE name = 'NewSelectCommand' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].NewSelectCommand
GO

CREATE PROCEDURE [dbo].NewSelectCommand
AS
	SET NOCOUNT ON;
SELECT        deliveries.delivery_id, customer.custom_name, deliveries.last_account, deliveries.delivered_money, deliveries.after_delivering, deliveries.notices, deliveries.deliver_date, employee.emp_name
FROM            customer INNER JOIN
                         deliveries ON customer.custom_id = deliveries.custom_id INNER JOIN
                         employee ON deliveries.emp_id = employee.emp_id
GO

