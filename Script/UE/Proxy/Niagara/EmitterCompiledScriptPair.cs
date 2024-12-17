using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.EmitterCompiledScriptPair")]
	public partial class FEmitterCompiledScriptPair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.EmitterCompiledScriptPair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEmitterCompiledScriptPair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEmitterCompiledScriptPair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEmitterCompiledScriptPair A, FEmitterCompiledScriptPair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEmitterCompiledScriptPair A, FEmitterCompiledScriptPair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEmitterCompiledScriptPair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}