using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.BlendSpaceLibrary")]
	public partial class UBlendSpaceLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.BlendSpaceLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SnapToPosition(FBlendSpaceReference BlendSpace, FVector NewPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlendSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SnapToPosition, __InBuffer);
			}
		}

		public static FVector GetPosition(FBlendSpaceReference BlendSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpace?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector GetFilteredPosition(FBlendSpaceReference BlendSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpace?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFilteredPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static void ConvertToBlendSpacePure(FAnimNodeReference Node, ref FBlendSpaceReference BlendSpace, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlendSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToBlendSpacePure, __InBuffer, __OutBuffer);

				BlendSpace = *(FBlendSpaceReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FBlendSpaceReference ConvertToBlendSpace(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToBlendSpace, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FBlendSpaceReference*)__ReturnBuffer;
			}
		}

		private static uint __SnapToPosition = 0;

		private static uint __GetPosition = 0;

		private static uint __GetFilteredPosition = 0;

		private static uint __ConvertToBlendSpacePure = 0;

		private static uint __ConvertToBlendSpace = 0;
	}
}