using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.FixupNeedsLoadForEditorGameCommandlet")]
	public partial class UFixupNeedsLoadForEditorGameCommandlet : UResavePackagesCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.FixupNeedsLoadForEditorGameCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}