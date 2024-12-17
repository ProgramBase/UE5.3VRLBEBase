using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VirtualizationEditor
{
	[PathName("/Script/VirtualizationEditor.VirtualizeProjectCommandlet")]
	public partial class UVirtualizeProjectCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualizationEditor.VirtualizeProjectCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}