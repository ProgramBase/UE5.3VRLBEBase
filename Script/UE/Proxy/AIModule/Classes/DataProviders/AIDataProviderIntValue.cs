using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIDataProviderIntValue")]
	public partial class FAIDataProviderIntValue : FAIDataProviderTypedValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIDataProviderIntValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIDataProviderIntValue()
		{
		}

		public static bool operator ==(FAIDataProviderIntValue A, FAIDataProviderIntValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIDataProviderIntValue A, FAIDataProviderIntValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIDataProviderIntValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		private static uint __DefaultValue = 0;

	}
}