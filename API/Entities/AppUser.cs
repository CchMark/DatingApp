namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        //型別帶"?"(問號)，表示變數可接受null值 dotnet code 6 須宣告
        public string UserName { get; set; }
    }
}
