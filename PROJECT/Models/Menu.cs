namespace PROJECT.Models
{
    public class Menu
    {


        public int MenuID { get; set; }
        public string? Menuname { get; set; }
        public Nullable<int> Menuprice { get; set; }
        public Nullable<int> EmpID { get; set; }
        public byte[]? Menuimg { get; set; }

    }
}
