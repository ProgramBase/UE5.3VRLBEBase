using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkeletonEditingToolBuilder")]
	public partial class USkeletonEditingToolBuilder : UInteractiveToolWithToolTargetsBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkeletonEditingToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}