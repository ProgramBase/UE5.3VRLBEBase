using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.LayeredBoneBlendLibrary")]
	public partial class ULayeredBoneBlendLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.LayeredBoneBlendLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="UpdateContext">
		/// The update context to use. This is used to extract the current skeleton to derive the blend mask from
		/// </param>
		/// <param name="LayeredBoneBlend">
		/// A reference to the node
		/// </param>
		/// <param name="PoseIndex">
		/// The pose index to set the blend mask for
		/// </param>
		/// <param name="BlendMaskName">
		/// The name of the blend mask to use 
		/// </param>
		public static FLayeredBoneBlendReference SetBlendMask(FAnimUpdateContext UpdateContext, FLayeredBoneBlendReference LayeredBoneBlend, int PoseIndex, FName BlendMaskName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayeredBoneBlend?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = PoseIndex;

				*(nint*)(__InBuffer + 20) = BlendMaskName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetBlendMask, __InBuffer, __ReturnBuffer);

				return *(FLayeredBoneBlendReference*)__ReturnBuffer;
			}
		}

		public static int GetNumPoses(FLayeredBoneBlendReference LayeredBoneBlend)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayeredBoneBlend?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumPoses, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FLayeredBoneBlendReference ConvertToLayeredBoneBlend(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToLayeredBoneBlend, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FLayeredBoneBlendReference*)__ReturnBuffer;
			}
		}

		public static void ConvertToLayeredBlendPerBonePure(FAnimNodeReference Node, ref FLayeredBoneBlendReference LayeredBoneBlend, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayeredBoneBlend?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToLayeredBlendPerBonePure, __InBuffer, __OutBuffer);

				LayeredBoneBlend = *(FLayeredBoneBlendReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		private static uint __SetBlendMask = 0;

		private static uint __GetNumPoses = 0;

		private static uint __ConvertToLayeredBoneBlend = 0;

		private static uint __ConvertToLayeredBlendPerBonePure = 0;
	}
}