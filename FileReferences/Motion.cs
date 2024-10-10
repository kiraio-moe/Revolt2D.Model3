namespace Revolt2D.Model3Json
{
    [Serializable]
    public class Motion
    {
        public required string File;

        public override string ToString()
        {
            return $"File: {File}";
        }
    }
}
