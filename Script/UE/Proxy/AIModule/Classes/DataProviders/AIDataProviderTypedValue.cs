using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIDataProviderTypedValue")]
	public partial class FAIDataProviderTypedValue : FAIDataProviderValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIDataProviderTypedValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIDataProviderTypedValue()
		{
		}

		public static bool operator ==(FAIDataProviderTypedValue A, FAIDataProviderTypedValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIDataProviderTypedValue A, FAIDataProviderTypedValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIDataProviderTypedValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}