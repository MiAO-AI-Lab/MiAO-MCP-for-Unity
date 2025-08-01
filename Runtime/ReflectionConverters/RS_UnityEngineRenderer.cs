#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

using System.Collections.Generic;
using System.Linq;

namespace com.MiAO.MCP.Reflection.Convertor
{
    public partial class RS_UnityEngineRenderer : RS_UnityEngineObject<UnityEngine.Renderer>
    {
        protected override IEnumerable<string> ignoredProperties => base.ignoredProperties
            .Concat(new[]
            {
                nameof(UnityEngine.Renderer.material),
                nameof(UnityEngine.Renderer.materials)
            });
    }
}