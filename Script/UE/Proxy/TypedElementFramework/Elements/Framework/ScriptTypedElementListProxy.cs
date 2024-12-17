using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.ScriptTypedElementListProxy")]
	public partial class FScriptTypedElementListProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.ScriptTypedElementListProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScriptTypedElementListProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FScriptTypedElementListProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FScriptTypedElementListProxy A, FScriptTypedElementListProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScriptTypedElementListProxy A, FScriptTypedElementListProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScriptTypedElementListProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}