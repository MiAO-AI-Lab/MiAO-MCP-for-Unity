#if !UNITY_5_3_OR_NEWER
using com.IvanMurzak.ReflectorNet.Model.Unity;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Threading.Tasks;

namespace com.MiAO.MCP.Server.API
{
    public partial class Tool_GameObject
    {
        [McpServerTool
        (
            Name = "GameObject_Destroy",
            Title = "Destroy GameObject in opened Prefab or in a Scene"
        )]
        [Description(@"Destroy a GameObject and all nested GameObjects recursively.
Use 'instanceID' whenever possible, because it finds the exact GameObject, when 'path' may find a wrong one.")]
        public ValueTask<CallToolResponse> Destroy
        (
            GameObjectRef gameObjectRef
        )
        {
            return ToolRouter.Call("GameObject_Destroy", arguments =>
            {
                arguments[nameof(gameObjectRef)] = gameObjectRef;
            });
        }
    }
}
#endif