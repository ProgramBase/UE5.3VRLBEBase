using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.KeyConsumptionOptions")]
	public partial class FKeyConsumptionOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.KeyConsumptionOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FKeyConsumptionOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FKeyConsumptionOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FKeyConsumptionOptions A, FKeyConsumptionOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FKeyConsumptionOptions A, FKeyConsumptionOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FKeyConsumptionOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}