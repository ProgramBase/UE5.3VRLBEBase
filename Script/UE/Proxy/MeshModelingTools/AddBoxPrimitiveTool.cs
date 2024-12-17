using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddBoxPrimitiveTool")]
	public partial class UAddBoxPrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddBoxPrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}