using modul7_kelompok_2;

class Program
{
    public static void Main(String[] args)
    {
        DataMahasiswa103082430002 dm = new DataMahasiswa103082430002();
        dm.ReadJSON();
        Console.WriteLine();
        TeamMembers103082430002 tm = new TeamMembers103082430002();
        tm.ReadJSON();
        Console.WriteLine();
        GlossaryItem103082430002 gi = new GlossaryItem103082430002();
        gi.ReadJSON();
    }
}