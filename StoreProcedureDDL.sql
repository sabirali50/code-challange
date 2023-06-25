CREATE PROCEDURE [dbo].[Shipper_Shipment_Details]
    @shipper_id INT
AS
BEGIN
    SELECT 
        S.shipment_id, 
        SH.shipper_name, 
        C.carrier_name, 
        S.shipment_description, 
        S.shipment_weight, 
        SR.shipment_rate_description
    FROM 
        [dbo].[SHIPMENT] S
    JOIN 
        [dbo].[SHIPPER] SH ON S.shipper_id = SH.shipper_id
    JOIN 
        [dbo].[CARRIER] C ON S.carrier_id = C.carrier_id
    JOIN 
        [dbo].[SHIPMENT_RATE] SR ON S.shipment_rate_id = SR.shipment_rate_id
    WHERE 
        S.shipper_id = @shipper_id
END
GO
