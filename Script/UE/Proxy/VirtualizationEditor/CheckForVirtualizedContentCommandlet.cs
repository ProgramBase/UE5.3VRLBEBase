using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VirtualizationEditor
{
	[PathName("/Script/VirtualizationEditor.CheckForVirtualizedContentCommandlet")]
	public partial class UCheckForVirtualizedContentCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualizationEditor.CheckForVirtualizedContentCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}