using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioReverbEffect")]
	public partial class FAudioReverbEffect : FAudioEffectParameters, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AudioReverbEffect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioReverbEffect()
		{
		}

		public static bool operator ==(FAudioReverbEffect A, FAudioReverbEffect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioReverbEffect A, FAudioReverbEffect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioReverbEffect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}