using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CollectionVectorParameter")]
	public partial class FCollectionVectorParameter : FCollectionParameterBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CollectionVectorParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionVectorParameter()
		{
		}

		public static bool operator ==(FCollectionVectorParameter A, FCollectionVectorParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionVectorParameter A, FCollectionVectorParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionVectorParameter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLinearColor DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		private static uint __DefaultValue = 0;

	}
}