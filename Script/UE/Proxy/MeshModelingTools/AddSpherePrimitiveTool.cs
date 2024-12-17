using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddSpherePrimitiveTool")]
	public partial class UAddSpherePrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddSpherePrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}