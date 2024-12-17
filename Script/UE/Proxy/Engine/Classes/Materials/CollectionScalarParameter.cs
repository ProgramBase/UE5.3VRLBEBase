using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CollectionScalarParameter")]
	public partial class FCollectionScalarParameter : FCollectionParameterBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CollectionScalarParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionScalarParameter()
		{
		}

		public static bool operator ==(FCollectionScalarParameter A, FCollectionScalarParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionScalarParameter A, FCollectionScalarParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionScalarParameter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		private static uint __DefaultValue = 0;

	}
}