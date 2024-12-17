using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.AnimNode_RetargetPoseFromMesh")]
	public partial class FAnimNode_RetargetPoseFromMesh : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.AnimNode_RetargetPoseFromMesh");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_RetargetPoseFromMesh()
		{
		}

		public static bool operator ==(FAnimNode_RetargetPoseFromMesh A, FAnimNode_RetargetPoseFromMesh B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_RetargetPoseFromMesh A, FAnimNode_RetargetPoseFromMesh B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_RetargetPoseFromMesh;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceMeshComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<USkeletalMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceMeshComponent, __InBuffer);
				}
			}
		}

		public bool bUseAttachedParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseAttachedParent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseAttachedParent, __InBuffer);
				}
			}
		}

		public UIKRetargeter IKRetargeterAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IKRetargeterAsset, __ReturnBuffer);

					return *(UIKRetargeter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IKRetargeterAsset, __InBuffer);
				}
			}
		}

		public FRetargetProfile CustomRetargetProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomRetargetProfile, __ReturnBuffer);

					return *(FRetargetProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomRetargetProfile, __InBuffer);
				}
			}
		}

		public bool bSuppressWarnings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSuppressWarnings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSuppressWarnings, __InBuffer);
				}
			}
		}

		public bool bCopyCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCopyCurves, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCopyCurves, __InBuffer);
				}
			}
		}

		public UIKRetargetProcessor Processor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Processor, __ReturnBuffer);

					return *(UIKRetargetProcessor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Processor, __InBuffer);
				}
			}
		}

		private static uint __SourceMeshComponent = 0;

		private static uint __bUseAttachedParent = 0;

		private static uint __IKRetargeterAsset = 0;

		private static uint __CustomRetargetProfile = 0;

		private static uint __bSuppressWarnings = 0;

		private static uint __bCopyCurves = 0;

		private static uint __Processor = 0;

	}
}