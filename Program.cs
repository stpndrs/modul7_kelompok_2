namespace modul7_kelompok_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa103082400012 dm = new DataMahasiswa103082400012();
            dm.ReadJSON();

            TeamMembers103082400012 tm = new TeamMembers103082400012();
            tm.ReadJSON();

            GlossaryItem103082400012 gi = new GlossaryItem103082400012();
            gi.ReadJSON();
        }
    }

}