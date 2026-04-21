using System.Text.Json;

public class Member
{
    public string nim { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
}

public class TeamMembers103082400014
{
    public List<Member> members { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_103082400014.json");

        var data = JsonSerializer.Deserialize<TeamMembers103082400014>(json);

        Console.WriteLine("Team member list:");

        if (data.members != null)
        {
            for (int i = 0; i < data.members.Count; i++)
            {
                Console.WriteLine(
                    data.members[i].nim + " " +
                    data.members[i].firstName + " " +
                    data.members[i].lastName +
                    " (" + data.members[i].age + " " + data.members[i].gender + ")"
                );
            }
        }
    }
}