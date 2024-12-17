using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.SequencerCore
{
	[PathName("/Script/SequencerCore.SequencerViewModelStructExtensions")]
	public partial class USequencerViewModelStructExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerCore.SequencerViewModelStructExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FString GetLabel(FSequencerViewModelScriptingStruct ViewModel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ViewModel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLabel, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __GetLabel = 0;
	}
}