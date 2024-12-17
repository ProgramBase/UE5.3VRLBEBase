using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddDiscPrimitiveTool")]
	public partial class UAddDiscPrimitiveTool : UAddPrimitiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddDiscPrimitiveTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}