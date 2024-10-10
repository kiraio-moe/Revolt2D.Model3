namespace Revolt2D.Model3Json
{
    [Serializable]
    public class HitArea
    {
        public required string Id;
        public required string Name;

        public override string ToString()
        {
            return $"\n    Id: {Id}\n    Name: {Name}";
        }
    }
}
