using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_HandIKRetargeting")]
	public partial class FAnimNode_HandIKRetargeting : FAnimNode_SkeletalControlBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_HandIKRetargeting");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_HandIKRetargeting()
		{
		}

		public static bool operator ==(FAnimNode_HandIKRetargeting A, FAnimNode_HandIKRetargeting B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_HandIKRetargeting A, FAnimNode_HandIKRetargeting B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_HandIKRetargeting;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference RightHandFK
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RightHandFK, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RightHandFK, __InBuffer);
				}
			}
		}

		public FBoneReference LeftHandFK
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeftHandFK, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeftHandFK, __InBuffer);
				}
			}
		}

		public FBoneReference RightHandIK
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RightHandIK, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RightHandIK, __InBuffer);
				}
			}
		}

		public FBoneReference LeftHandIK
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeftHandIK, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeftHandIK, __InBuffer);
				}
			}
		}

		public TArray<FBoneReference> IKBonesToMove
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IKBonesToMove, __ReturnBuffer);

					return *(TArray<FBoneReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IKBonesToMove, __InBuffer);
				}
			}
		}

		public float HandFKWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HandFKWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HandFKWeight, __InBuffer);
				}
			}
		}

		private static uint __RightHandFK = 0;

		private static uint __LeftHandFK = 0;

		private static uint __RightHandIK = 0;

		private static uint __LeftHandIK = 0;

		private static uint __IKBonesToMove = 0;

		private static uint __HandFKWeight = 0;

	}
}