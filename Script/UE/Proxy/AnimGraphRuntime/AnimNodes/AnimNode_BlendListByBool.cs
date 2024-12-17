using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendListByBool")]
	public partial class FAnimNode_BlendListByBool : FAnimNode_BlendListBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendListByBool");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendListByBool()
		{
		}

		public static bool operator ==(FAnimNode_BlendListByBool A, FAnimNode_BlendListByBool B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendListByBool A, FAnimNode_BlendListByBool B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendListByBool;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bActiveValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bActiveValue, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bActiveValue, __InBuffer);
				}
			}
		}

		private static uint __bActiveValue = 0;

	}
}