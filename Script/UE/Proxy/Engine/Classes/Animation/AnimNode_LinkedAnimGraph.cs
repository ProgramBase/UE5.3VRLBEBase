using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_LinkedAnimGraph")]
	public partial class FAnimNode_LinkedAnimGraph : FAnimNode_CustomProperty, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_LinkedAnimGraph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_LinkedAnimGraph()
		{
		}

		public static bool operator ==(FAnimNode_LinkedAnimGraph A, FAnimNode_LinkedAnimGraph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_LinkedAnimGraph A, FAnimNode_LinkedAnimGraph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_LinkedAnimGraph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPoseLink> InputPoses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputPoses, __ReturnBuffer);

					return *(TArray<FPoseLink>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputPoses, __InBuffer);
				}
			}
		}

		public TArray<FName> InputPoseNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputPoseNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputPoseNames, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimInstance> InstanceClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstanceClass, __ReturnBuffer);

					return *(TSubclassOf<UAnimInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstanceClass, __InBuffer);
				}
			}
		}

		public UBlendProfile PendingBlendOutProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PendingBlendOutProfile, __ReturnBuffer);

					return *(UBlendProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PendingBlendOutProfile, __InBuffer);
				}
			}
		}

		public UBlendProfile PendingBlendInProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PendingBlendInProfile, __ReturnBuffer);

					return *(UBlendProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PendingBlendInProfile, __InBuffer);
				}
			}
		}

		public bool bReceiveNotifiesFromLinkedInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bReceiveNotifiesFromLinkedInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bReceiveNotifiesFromLinkedInstances, __InBuffer);
				}
			}
		}

		public bool bPropagateNotifiesToLinkedInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPropagateNotifiesToLinkedInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPropagateNotifiesToLinkedInstances, __InBuffer);
				}
			}
		}

		private static uint __InputPoses = 0;

		private static uint __InputPoseNames = 0;

		private static uint __InstanceClass = 0;

		private static uint __PendingBlendOutProfile = 0;

		private static uint __PendingBlendInProfile = 0;

		private static uint __bReceiveNotifiesFromLinkedInstances = 0;

		private static uint __bPropagateNotifiesToLinkedInstances = 0;

	}
}