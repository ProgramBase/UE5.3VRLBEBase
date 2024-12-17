using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementLocalTransformColumn")]
	public partial class FTypedElementLocalTransformColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementLocalTransformColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementLocalTransformColumn()
		{
		}

		public static bool operator ==(FTypedElementLocalTransformColumn A, FTypedElementLocalTransformColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementLocalTransformColumn A, FTypedElementLocalTransformColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementLocalTransformColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		private static uint __Transform = 0;

	}
}