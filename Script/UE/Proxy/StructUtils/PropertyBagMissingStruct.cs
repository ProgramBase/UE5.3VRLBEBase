using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.PropertyBagMissingStruct")]
	public partial class FPropertyBagMissingStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtils.PropertyBagMissingStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyBagMissingStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyBagMissingStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyBagMissingStruct A, FPropertyBagMissingStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyBagMissingStruct A, FPropertyBagMissingStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyBagMissingStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}