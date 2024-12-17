using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIDataProviderBoolValue")]
	public partial class FAIDataProviderBoolValue : FAIDataProviderTypedValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIDataProviderBoolValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIDataProviderBoolValue()
		{
		}

		public static bool operator ==(FAIDataProviderBoolValue A, FAIDataProviderBoolValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIDataProviderBoolValue A, FAIDataProviderBoolValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIDataProviderBoolValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		private static uint __DefaultValue = 0;

	}
}