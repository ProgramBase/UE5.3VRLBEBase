using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebuggingInfoForSingleFunction")]
	public partial class FDebuggingInfoForSingleFunction : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DebuggingInfoForSingleFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDebuggingInfoForSingleFunction() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDebuggingInfoForSingleFunction() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDebuggingInfoForSingleFunction A, FDebuggingInfoForSingleFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDebuggingInfoForSingleFunction A, FDebuggingInfoForSingleFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDebuggingInfoForSingleFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}