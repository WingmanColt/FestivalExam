namespace FestivalManager.Entities.Instruments
{
    public class Bass : Instrument
    {
        protected int RepairAmountConst = 80;
        protected override int RepairAmount => RepairAmountConst;
    }
}
