using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.ScriptTypedElementHandle")]
	public partial class FScriptTypedElementHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.ScriptTypedElementHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScriptTypedElementHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FScriptTypedElementHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FScriptTypedElementHandle A, FScriptTypedElementHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScriptTypedElementHandle A, FScriptTypedElementHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScriptTypedElementHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}