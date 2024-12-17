using Script.CoreUObject;
using Script.Library;

namespace Script.WorldPartitionEditor
{
	[PathName("/Script/WorldPartitionEditor.ContentBundleEditorSubsystemModule")]
	public partial class UContentBundleEditorSubsystemModule : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionEditor.ContentBundleEditorSubsystemModule");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}