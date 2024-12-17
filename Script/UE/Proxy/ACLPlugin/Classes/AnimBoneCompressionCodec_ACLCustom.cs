using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLCustom")]
	public partial class UAnimBoneCompressionCodec_ACLCustom : UAnimBoneCompressionCodec_ACLBase, IStaticClass
	{
		public ACLRotationFormat RotationFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RotationFormat, __ReturnBuffer);

					return *(ACLRotationFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RotationFormat, __InBuffer);
				}
			}
		}

		public ACLVectorFormat TranslationFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslationFormat, __ReturnBuffer);

					return *(ACLVectorFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslationFormat, __InBuffer);
				}
			}
		}

		public ACLVectorFormat ScaleFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScaleFormat, __ReturnBuffer);

					return *(ACLVectorFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScaleFormat, __InBuffer);
				}
			}
		}

		public float ConstantRotationThresholdAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantRotationThresholdAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantRotationThresholdAngle, __InBuffer);
				}
			}
		}

		public float ConstantTranslationThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantTranslationThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantTranslationThreshold, __InBuffer);
				}
			}
		}

		public float ConstantScaleThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantScaleThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantScaleThreshold, __InBuffer);
				}
			}
		}

		public TArray<USkeletalMesh> OptimizationTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OptimizationTargets, __ReturnBuffer);

					return *(TArray<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OptimizationTargets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLCustom");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RotationFormat = 0;

		private static uint __TranslationFormat = 0;

		private static uint __ScaleFormat = 0;

		private static uint __ConstantRotationThresholdAngle = 0;

		private static uint __ConstantTranslationThreshold = 0;

		private static uint __ConstantScaleThreshold = 0;

		private static uint __OptimizationTargets = 0;
	}
}