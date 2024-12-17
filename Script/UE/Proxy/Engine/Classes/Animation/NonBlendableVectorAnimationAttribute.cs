using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NonBlendableVectorAnimationAttribute")]
	public partial class FNonBlendableVectorAnimationAttribute : FVectorAnimationAttribute, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NonBlendableVectorAnimationAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNonBlendableVectorAnimationAttribute()
		{
		}

		public static bool operator ==(FNonBlendableVectorAnimationAttribute A, FNonBlendableVectorAnimationAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNonBlendableVectorAnimationAttribute A, FNonBlendableVectorAnimationAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNonBlendableVectorAnimationAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}