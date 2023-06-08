using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Application.Common.HATEOS
{
    public class ShapedEntity : LinkBaseEntity
    {
        public Guid Id { get; set; }
        public ExpandoObject Entity { get; set; }
        
        
        public ShapedEntity()
        {
            Entity = new ExpandoObject();
        }

        public override string ToString()
        {
            return JsonSerializer // for visual display of values
                .Serialize(this, new JsonSerializerOptions
                {
                    WriteIndented = true, // spaces are included in json (relatively speaking, for beauty)
                    ReferenceHandler = ReferenceHandler.Preserve // "Preserve" to avoid circular references
                });
        }
    }
}