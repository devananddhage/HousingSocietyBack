namespace WebApi.Models
{
    /// <summary>
    /// Database entry status - to archieve entries
    /// </summary>
    public enum DbStatusType
    {
        Active,
        Inactive
    }

    /// <summary>
    /// RESIDENT = 'Residential'
    /// CLUBHOUSE = 'Club house'
    /// ROWHOUSE = 'Row house'
    /// </summary>
    public enum HouseType
    {
        RESIDENT,
        CLUBHOUSE,
        ROWHOUSE
    }

    /// <summary>
    /// ONERK = "1 Room Kitchen",
    /// ONEBHK = "1 BHK",
    /// ONEHALFBHK = "1.5 BHK",
    /// TWOBHK = "2 BHK",
    /// TWOHALFBHK = "2.5 BHK",
    /// THREEBHK = "3 BHK",
    /// FOURBHK = "4 BHK",
    /// PENT = "Penthouse"
    /// </summary>
    public enum UnitType
    {
        ONERK,
        ONEBHK,
        ONEHALFBHK,
        TWOBHK,
        TWOHALFBHK,
        THREEBHK,
        FOURBHK,
        PENT
    }

    /// <summary>
    /// PROPOSED = 'Proposed'
    /// COMPLETE = 'Complete'
    /// UNDERCONSTRUCTION = 'Under Construction'
    /// DESTROYED = 'Destroyed'
    /// </summary>
    public enum ConstructionStatusType
    {
        PROPOSED,
        COMPLETE,
        UNDERCONSTRUCTION,
        DESTROYED
    }

    /// <summary>
    /// ISEMPTY = 'Empty'
    /// ISOWNER = 'Is Owner'
    /// ISTENANT = 'Is Tenant'
    /// </summary>
    public enum LivingStatusType
    {
        ISEMPTY,
        ISOWNER,
        ISTENANT
    }

    /// <summary>
    /// Maintenance type 
    /// variable - depends on maintenance area of flat
    /// fixed - not depends on anything
    /// </summary>
    public enum MaintenanceType
    {
        VAR,
        FIXED
    }

    /// <summary>
    /// Maintenance type 
    /// paid - on every new entry user can say paid
    /// approved - approved by approver
    /// reject - rejected by approver
    /// </summary>
    public enum MaintenancePaidStatusType
    {
        PAID,
        APPROVED,
        REJECTED
    }

    /// <summary>
    /// TWO = 'Two Wheeler'
    /// THREE = 'Three Wheeler'
    /// FOUR = 'Four Wheeler'
    /// </summary>
    public enum VehicleType
    {
        TWO,
        THREE,
        FOUR
    }

    /// <summary>
    /// (NEW, 'New'),  # by user for new entry.
    /// (APPROVED, 'Approved'),  # by approver once docs are correct.
    /// (ISSUED, 'Issued'),  # by approver once sticker issued. End
    /// (REJECTED, 'Rejected')  # approver will enter the reason also.
    /// </summary>
    public enum VehicleStickerType
    {
        NEW,
        APPROVED,
        ISSUED,
        REJECTED
    }
}
