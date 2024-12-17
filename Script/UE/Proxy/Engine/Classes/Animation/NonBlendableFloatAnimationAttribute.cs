using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NonBlendableFloatAnimationAttribute")]
	public partial class FNonBlendableFloatAnimationAttribute : FFloatAnimationAttribute, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NonBlendableFloatAnimationAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNonBlendableFloatAnimationAttribute()
		{
		}

		public static bool operator ==(FNonBlendableFloatAnimationAttribute A, FNonBlendableFloatAnimationAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNonBlendableFloatAnimationAttribute A, FNonBlendableFloatAnimationAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNonBlendableFloatAnimationAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}