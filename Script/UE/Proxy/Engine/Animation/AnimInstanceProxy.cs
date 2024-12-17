using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimInstanceProxy")]
	public partial class FAnimInstanceProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimInstanceProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimInstanceProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimInstanceProxy A, FAnimInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimInstanceProxy A, FAnimInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}