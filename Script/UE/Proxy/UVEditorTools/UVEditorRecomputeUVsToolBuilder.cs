using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorRecomputeUVsToolBuilder")]
	public partial class UUVEditorRecomputeUVsToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorRecomputeUVsToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}