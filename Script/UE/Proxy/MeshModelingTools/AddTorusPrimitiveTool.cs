using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddTorusPrimitiveTool")]
	public partial class UAddTorusPrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddTorusPrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}