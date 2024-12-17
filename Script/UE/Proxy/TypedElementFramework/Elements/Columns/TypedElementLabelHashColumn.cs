using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementLabelHashColumn")]
	public partial class FTypedElementLabelHashColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementLabelHashColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementLabelHashColumn()
		{
		}

		public static bool operator ==(FTypedElementLabelHashColumn A, FTypedElementLabelHashColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementLabelHashColumn A, FTypedElementLabelHashColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementLabelHashColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ulong LabelHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LabelHash, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LabelHash, __InBuffer);
				}
			}
		}

		private static uint __LabelHash = 0;

	}
}