namespace BusinessLayer.Service
{
    public class LoginRepository
    {
        public static LoginRepository Instance { get; } = new LoginRepository();

        public int? IdLogedUser { get; set; } = null;

        public int? IdSelectedContact { get; set; } = null;
    }
}
