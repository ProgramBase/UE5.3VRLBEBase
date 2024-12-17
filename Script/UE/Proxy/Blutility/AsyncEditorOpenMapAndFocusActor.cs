using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AsyncEditorOpenMapAndFocusActor")]
	public partial class UAsyncEditorOpenMapAndFocusActor : UEditorUtilityBlueprintAsyncActionBase, IStaticClass
	{
		public FAsyncDelayComplete Complete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __ReturnBuffer);

					return *(FAsyncDelayComplete*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AsyncEditorOpenMapAndFocusActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncEditorOpenMapAndFocusActor AsyncEditorOpenMapAndFocusActor(FSoftObjectPath Map, FString FocusActorName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Map?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FocusActorName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncEditorOpenMapAndFocusActor, __InBuffer, __ReturnBuffer);

				return *(UAsyncEditorOpenMapAndFocusActor*)__ReturnBuffer;
			}
		}

		private static uint __Complete = 0;

		private static uint __AsyncEditorOpenMapAndFocusActor = 0;
	}
}