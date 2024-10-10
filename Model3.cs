namespace Revolt2D.Model3Json
{
    [Serializable]
    public class Model3
    {
        public required int Version;
        public required FileReferences FileReferences;
        public required List<Group> Groups;
        public required List<HitArea> HitAreas;

        public override string ToString()
        {
            string groupsString =
                Groups != null
                    ? string.Join("\n", Groups.Select((g, index) => $"  Group[{index}]:\n{g}"))
                    : "No Groups";

            string hitAreasString =
                HitAreas != null
                    ? string.Join("\n", HitAreas.Select((h, index) => $"  HitArea[{index}]:{h}"))
                    : "No HitAreas";

            return $"Version: {Version}\nFile References: {FileReferences}\nGroups:\n{groupsString}\nHitAreas:\n{hitAreasString}";
        }
    }
}
