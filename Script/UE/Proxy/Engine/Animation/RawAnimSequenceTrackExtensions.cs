using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RawAnimSequenceTrackExtensions")]
	public partial class URawAnimSequenceTrackExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RawAnimSequenceTrackExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static TArray<FVector> GetScaleKeys(FRawAnimSequenceTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetScaleKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		public static TArray<FQuat> GetRotationalKeys(FRawAnimSequenceTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRotationalKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FQuat>*)__ReturnBuffer;
			}
		}

		public static TArray<FVector> GetPositionalKeys(FRawAnimSequenceTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPositionalKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		private static uint __GetScaleKeys = 0;

		private static uint __GetRotationalKeys = 0;

		private static uint __GetPositionalKeys = 0;
	}
}