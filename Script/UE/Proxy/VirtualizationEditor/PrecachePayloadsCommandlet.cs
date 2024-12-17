using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VirtualizationEditor
{
	[PathName("/Script/VirtualizationEditor.PrecachePayloadsCommandlet")]
	public partial class UPrecachePayloadsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualizationEditor.PrecachePayloadsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}