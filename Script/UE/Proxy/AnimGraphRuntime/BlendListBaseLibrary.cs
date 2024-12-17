using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.BlendListBaseLibrary")]
	public partial class UBlendListBaseLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.BlendListBaseLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ResetNode(FBlendListBaseReference BlendListBase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendListBase?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResetNode, __InBuffer);
			}
		}

		public static FBlendListBaseReference ConvertToBlendListBase(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToBlendListBase, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FBlendListBaseReference*)__ReturnBuffer;
			}
		}

		private static uint __ResetNode = 0;

		private static uint __ConvertToBlendListBase = 0;
	}
}