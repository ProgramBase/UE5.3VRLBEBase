using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.SpriteAssetInitParameters")]
	public partial class FSpriteAssetInitParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Paper2D.SpriteAssetInitParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpriteAssetInitParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpriteAssetInitParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpriteAssetInitParameters A, FSpriteAssetInitParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpriteAssetInitParameters A, FSpriteAssetInitParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpriteAssetInitParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}