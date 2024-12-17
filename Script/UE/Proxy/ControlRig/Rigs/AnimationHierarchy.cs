using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.AnimationHierarchy")]
	public partial class FAnimationHierarchy : FNodeHierarchyWithUserData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.AnimationHierarchy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationHierarchy()
		{
		}

		public static bool operator ==(FAnimationHierarchy A, FAnimationHierarchy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationHierarchy A, FAnimationHierarchy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationHierarchy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FConstraintNodeData> UserData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserData, __ReturnBuffer);

					return *(TArray<FConstraintNodeData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserData, __InBuffer);
				}
			}
		}

		private static uint __UserData = 0;

	}
}