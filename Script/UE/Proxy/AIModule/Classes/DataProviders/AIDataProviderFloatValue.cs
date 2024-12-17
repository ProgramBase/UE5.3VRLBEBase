using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIDataProviderFloatValue")]
	public partial class FAIDataProviderFloatValue : FAIDataProviderTypedValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIDataProviderFloatValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIDataProviderFloatValue()
		{
		}

		public static bool operator ==(FAIDataProviderFloatValue A, FAIDataProviderFloatValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIDataProviderFloatValue A, FAIDataProviderFloatValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIDataProviderFloatValue;

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