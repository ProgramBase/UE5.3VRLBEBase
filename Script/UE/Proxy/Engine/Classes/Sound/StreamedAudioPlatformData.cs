using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StreamedAudioPlatformData")]
	public partial class FStreamedAudioPlatformData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StreamedAudioPlatformData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStreamedAudioPlatformData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStreamedAudioPlatformData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStreamedAudioPlatformData A, FStreamedAudioPlatformData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStreamedAudioPlatformData A, FStreamedAudioPlatformData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStreamedAudioPlatformData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}