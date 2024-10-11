using Revolt2D.Model.FileReferences.Json;

namespace Revolt2D.Model.Json
{
    public class FileReferences
    {
        public required string Moc;
        public required List<string> Textures;
        public required string Physics;
        public required string Pose;
        public required string DisplayInfo;
        public required Dictionary<string, List<Motion>> Motions;

        public override string ToString()
        {
            string texturesString = string.Join(
                "\n",
                Textures.Select((texture, index) => $"    Texture[{index}]: {texture}")
            );

            string motionsString = string.Join(
                "\n",
                Motions.Select(motionGroup =>
                    $"    Motion[{motionGroup.Key}]:\n"
                    + string.Join(
                        "\n",
                        motionGroup.Value.Select(
                            (motion, index) => $"      File[{index}]: {motion.File}"
                        )
                    )
                )
            );

            return $"\n  Moc: {Moc}\n  Textures:\n{texturesString}\n  Physics: {Physics}\n  Pose: {Pose}\n  Display Info: {DisplayInfo}\n  Motions:\n{motionsString}";
        }
    }
}
