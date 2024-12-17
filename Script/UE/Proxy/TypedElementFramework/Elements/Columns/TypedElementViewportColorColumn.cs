using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementViewportColorColumn")]
	public partial class FTypedElementViewportColorColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementViewportColorColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementViewportColorColumn()
		{
		}

		public static bool operator ==(FTypedElementViewportColorColumn A, FTypedElementViewportColorColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementViewportColorColumn A, FTypedElementViewportColorColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementViewportColorColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte SelectionOutlineColorIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SelectionOutlineColorIndex, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SelectionOutlineColorIndex, __InBuffer);
				}
			}
		}

		private static uint __SelectionOutlineColorIndex = 0;

	}
}