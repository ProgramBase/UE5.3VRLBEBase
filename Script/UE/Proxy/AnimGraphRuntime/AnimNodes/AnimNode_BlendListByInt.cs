using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendListByInt")]
	public partial class FAnimNode_BlendListByInt : FAnimNode_BlendListBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendListByInt");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendListByInt()
		{
		}

		public static bool operator ==(FAnimNode_BlendListByInt A, FAnimNode_BlendListByInt B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendListByInt A, FAnimNode_BlendListByInt B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendListByInt;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ActiveChildIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveChildIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveChildIndex, __InBuffer);
				}
			}
		}

		private static uint __ActiveChildIndex = 0;

	}
}