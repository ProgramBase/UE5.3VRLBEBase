using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SkeletalControlLibrary")]
	public partial class USkeletalControlLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.SkeletalControlLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FSkeletalControlReference SetAlpha(FSkeletalControlReference SkeletalControl, float Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SkeletalControl?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetAlpha, __InBuffer, __ReturnBuffer);

				return *(FSkeletalControlReference*)__ReturnBuffer;
			}
		}

		public static float GetAlpha(FSkeletalControlReference SkeletalControl)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SkeletalControl?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAlpha, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void ConvertToSkeletalControlPure(FAnimNodeReference Node, ref FSkeletalControlReference SkeletalControl, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SkeletalControl?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSkeletalControlPure, __InBuffer, __OutBuffer);

				SkeletalControl = *(FSkeletalControlReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FSkeletalControlReference ConvertToSkeletalControl(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToSkeletalControl, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FSkeletalControlReference*)__ReturnBuffer;
			}
		}

		private static uint __SetAlpha = 0;

		private static uint __GetAlpha = 0;

		private static uint __ConvertToSkeletalControlPure = 0;

		private static uint __ConvertToSkeletalControl = 0;
	}
}