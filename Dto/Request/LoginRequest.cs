namespace WebAPI_Wa.Dto.Request
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }  //1-dr  2-patient
    }
}
