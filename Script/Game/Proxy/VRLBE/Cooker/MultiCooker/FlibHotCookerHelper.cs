using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.FlibHotCookerHelper")]
	public partial class UFlibHotCookerHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.FlibHotCookerHelper");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}