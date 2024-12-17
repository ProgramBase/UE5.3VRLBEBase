using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddRectanglePrimitiveTool")]
	public partial class UAddRectanglePrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddRectanglePrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}