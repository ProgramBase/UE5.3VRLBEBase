using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VirtualizationEditor
{
	[PathName("/Script/VirtualizationEditor.ValidateVirtualizedContentCommandlet")]
	public partial class UValidateVirtualizedContentCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualizationEditor.ValidateVirtualizedContentCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}