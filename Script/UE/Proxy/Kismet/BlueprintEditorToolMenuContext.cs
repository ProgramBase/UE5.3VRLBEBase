using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BlueprintEditorToolMenuContext")]
	public partial class UBlueprintEditorToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Kismet.BlueprintEditorToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UBlueprint GetBlueprintObj()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBlueprintObj, __ReturnBuffer);

				return *(UBlueprint*)__ReturnBuffer;
			}
		}

		private static uint __GetBlueprintObj = 0;
	}
}