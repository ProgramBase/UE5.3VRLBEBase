using Script.CoreUObject;
using Script.Library;
using Script.PropertyPath;

namespace Script.UMG
{
	[PathName("/Script/UMG.DynamicPropertyPath")]
	public partial class FDynamicPropertyPath : FCachedPropertyPath, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.DynamicPropertyPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDynamicPropertyPath()
		{
		}

		public static bool operator ==(FDynamicPropertyPath A, FDynamicPropertyPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDynamicPropertyPath A, FDynamicPropertyPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDynamicPropertyPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}