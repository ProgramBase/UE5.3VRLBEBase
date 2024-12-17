using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.AnimationCompressionLibraryDatabase")]
	public partial class UAnimationCompressionLibraryDatabase : UObject, IStaticClass
	{
		public TArray<byte> CookedCompressedBytes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CookedCompressedBytes, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CookedCompressedBytes, __InBuffer);
				}
			}
		}

		public TArray<ulong> CookedAnimSequenceMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CookedAnimSequenceMappings, __ReturnBuffer);

					return *(TArray<ulong>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CookedAnimSequenceMappings, __InBuffer);
				}
			}
		}

		public float HighestImportanceProportion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HighestImportanceProportion, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HighestImportanceProportion, __InBuffer);
				}
			}
		}

		public float MediumImportanceProportion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediumImportanceProportion, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediumImportanceProportion, __InBuffer);
				}
			}
		}

		public float LowestImportanceProportion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LowestImportanceProportion, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LowestImportanceProportion, __InBuffer);
				}
			}
		}

		public FPerPlatformBool StripLowestImportanceTier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StripLowestImportanceTier, __ReturnBuffer);

					return *(FPerPlatformBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StripLowestImportanceTier, __InBuffer);
				}
			}
		}

		public uint MaxStreamRequestSizeKB
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxStreamRequestSizeKB, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxStreamRequestSizeKB, __InBuffer);
				}
			}
		}

		public ACLVisualFidelity PreviewVisualFidelity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewVisualFidelity, __ReturnBuffer);

					return *(ACLVisualFidelity*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewVisualFidelity, __InBuffer);
				}
			}
		}

		public TArray<UAnimSequence> AnimSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequences, __ReturnBuffer);

					return *(TArray<UAnimSequence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequences, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPlugin.AnimationCompressionLibraryDatabase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetVisualFidelity(UObject WorldContextObject, FLatentActionInfo LatentInfo, UAnimationCompressionLibraryDatabase DatabaseAsset, ref ACLVisualFidelityChangeResult Result, ACLVisualFidelity VisualFidelity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DatabaseAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Result;

				*(byte*)(__InBuffer + 25) = (byte)VisualFidelity;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetVisualFidelity, __InBuffer, __OutBuffer);

				Result = *(ACLVisualFidelityChangeResult*)(__OutBuffer);

			}
		}

		public static ACLVisualFidelity GetVisualFidelity(UAnimationCompressionLibraryDatabase DatabaseAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DatabaseAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetVisualFidelity, __InBuffer, __ReturnBuffer);

				return *(ACLVisualFidelity*)__ReturnBuffer;
			}
		}

		private static uint __CookedCompressedBytes = 0;

		private static uint __CookedAnimSequenceMappings = 0;

		private static uint __HighestImportanceProportion = 0;

		private static uint __MediumImportanceProportion = 0;

		private static uint __LowestImportanceProportion = 0;

		private static uint __StripLowestImportanceTier = 0;

		private static uint __MaxStreamRequestSizeKB = 0;

		private static uint __PreviewVisualFidelity = 0;

		private static uint __AnimSequences = 0;

		private static uint __SetVisualFidelity = 0;

		private static uint __GetVisualFidelity = 0;
	}
}