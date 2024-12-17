using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ListViewDesignerPreviewItem")]
	public partial class UListViewDesignerPreviewItem : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ListViewDesignerPreviewItem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}