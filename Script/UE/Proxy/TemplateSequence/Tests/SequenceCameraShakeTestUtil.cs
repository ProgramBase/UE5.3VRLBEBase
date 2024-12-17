using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.SequenceCameraShakeTestUtil")]
	public partial class USequenceCameraShakeTestUtil : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.SequenceCameraShakeTestUtil");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool GetPostProcessBlendCache(APlayerController PlayerController, int PPIndex, ref FPostProcessSettings OutPPSettings, ref float OutPPBlendWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PPIndex;

				*(nint*)(__InBuffer + 12) = OutPPSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 20) = OutPPBlendWeight;

				var __OutBuffer = stackalloc byte[12];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPostProcessBlendCache, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPPSettings = *(FPostProcessSettings*)(__OutBuffer);

				OutPPBlendWeight = *(float*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FMinimalViewInfo GetLastFrameCameraCachePOV(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLastFrameCameraCachePOV, __InBuffer, __ReturnBuffer);

				return *(FMinimalViewInfo*)__ReturnBuffer;
			}
		}

		public static FMinimalViewInfo GetCameraCachePOV(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCameraCachePOV, __InBuffer, __ReturnBuffer);

				return *(FMinimalViewInfo*)__ReturnBuffer;
			}
		}

		private static uint __GetPostProcessBlendCache = 0;

		private static uint __GetLastFrameCameraCachePOV = 0;

		private static uint __GetCameraCachePOV = 0;
	}
}