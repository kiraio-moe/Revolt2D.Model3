namespace Revolt2D.Model.Groups.Json
{
    public class Group
    {
        public required string Target;
        public required string Name;
        public required List<string> Ids;

        public override string ToString()
        {
            string IdsString = string.Join(
                "\n",
                Ids.Select((id, index) => $"      Id[{index}]: {id}")
            );
            return $"\n    Target: {Target}\n    Name: {Name}\n    Ids:\n{IdsString}";
        }
    }
}
