using Script.CoreUObject;
using Script.Library;
using Script.AudioExtensions;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundOutput")]
	public partial class FMetaSoundOutput : FSoundGeneratorOutput, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundOutput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundOutput()
		{
		}

		public static bool operator ==(FMetaSoundOutput A, FMetaSoundOutput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundOutput A, FMetaSoundOutput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundOutput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}