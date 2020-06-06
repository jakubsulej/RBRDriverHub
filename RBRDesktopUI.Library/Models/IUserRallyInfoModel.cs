namespace RBRDesktopUI.Library.Models
{
    public interface IUserRallyInfoModel
    {
        int EnteredTournaments { get; set; }
        int FinnishedTournaments { get; set; }
        int TotalNumberOfKm { get; set; }
        string UserId { get; set; }
        string UserLicence { get; set; }
        int WonTournaments { get; set; }
    }
}