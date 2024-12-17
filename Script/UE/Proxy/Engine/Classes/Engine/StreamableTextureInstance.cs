using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StreamableTextureInstance")]
	public partial class FStreamableTextureInstance : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StreamableTextureInstance");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStreamableTextureInstance() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStreamableTextureInstance() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStreamableTextureInstance A, FStreamableTextureInstance B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStreamableTextureInstance A, FStreamableTextureInstance B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStreamableTextureInstance;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}