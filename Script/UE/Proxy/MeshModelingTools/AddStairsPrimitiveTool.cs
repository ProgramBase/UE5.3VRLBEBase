using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddStairsPrimitiveTool")]
	public partial class UAddStairsPrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddStairsPrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}