using System.Text.Json;

namespace Revolt2D.Model.Json
{
    public class Model3Loader
    {
        private Model3 _model;

        public Model3Loader(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
            _model = JsonSerializer.Deserialize<Model3>(jsonData, options);
        }

        public Model3 GetModel()
        {
            return _model;
        }
    }
}
