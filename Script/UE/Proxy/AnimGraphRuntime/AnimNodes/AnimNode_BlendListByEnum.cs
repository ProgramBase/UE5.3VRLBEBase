using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum")]
	public partial class FAnimNode_BlendListByEnum : FAnimNode_BlendListBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendListByEnum()
		{
		}

		public static bool operator ==(FAnimNode_BlendListByEnum A, FAnimNode_BlendListByEnum B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendListByEnum A, FAnimNode_BlendListByEnum B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendListByEnum;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> EnumToPoseIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnumToPoseIndex, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnumToPoseIndex, __InBuffer);
				}
			}
		}

		public byte ActiveEnumValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveEnumValue, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveEnumValue, __InBuffer);
				}
			}
		}

		private static uint __EnumToPoseIndex = 0;

		private static uint __ActiveEnumValue = 0;

	}
}