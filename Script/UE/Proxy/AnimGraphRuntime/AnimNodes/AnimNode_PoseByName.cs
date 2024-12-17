using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_PoseByName")]
	public partial class FAnimNode_PoseByName : FAnimNode_PoseHandler, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_PoseByName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_PoseByName()
		{
		}

		public static bool operator ==(FAnimNode_PoseByName A, FAnimNode_PoseByName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_PoseByName A, FAnimNode_PoseByName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_PoseByName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PoseName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PoseName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PoseName, __InBuffer);
				}
			}
		}

		public float PoseWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PoseWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PoseWeight, __InBuffer);
				}
			}
		}

		private static uint __PoseName = 0;

		private static uint __PoseWeight = 0;

	}
}