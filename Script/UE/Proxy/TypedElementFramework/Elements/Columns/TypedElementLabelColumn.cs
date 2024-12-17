using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementLabelColumn")]
	public partial class FTypedElementLabelColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementLabelColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementLabelColumn()
		{
		}

		public static bool operator ==(FTypedElementLabelColumn A, FTypedElementLabelColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementLabelColumn A, FTypedElementLabelColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementLabelColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Label
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Label, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Label, __InBuffer);
				}
			}
		}

		private static uint __Label = 0;

	}
}