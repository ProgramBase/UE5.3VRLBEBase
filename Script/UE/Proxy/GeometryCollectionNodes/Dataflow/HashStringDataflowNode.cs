using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.HashStringDataflowNode")]
	public partial class FHashStringDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.HashStringDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHashStringDataflowNode()
		{
		}

		public static bool operator ==(FHashStringDataflowNode A, FHashStringDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHashStringDataflowNode A, FHashStringDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHashStringDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString String
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __String, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __String, __InBuffer);
				}
			}
		}

		public int Hash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hash, __InBuffer);
				}
			}
		}

		private static uint __String = 0;

		private static uint __Hash = 0;

	}
}