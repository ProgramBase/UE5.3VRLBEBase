using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VirtualizationEditor
{
	[PathName("/Script/VirtualizationEditor.RehydrateProjectCommandlet")]
	public partial class URehydrateProjectCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualizationEditor.RehydrateProjectCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}