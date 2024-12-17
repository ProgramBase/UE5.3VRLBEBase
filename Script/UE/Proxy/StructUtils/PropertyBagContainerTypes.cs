using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.PropertyBagContainerTypes")]
	public partial class FPropertyBagContainerTypes : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtils.PropertyBagContainerTypes");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyBagContainerTypes() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyBagContainerTypes() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyBagContainerTypes A, FPropertyBagContainerTypes B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyBagContainerTypes A, FPropertyBagContainerTypes B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyBagContainerTypes;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}