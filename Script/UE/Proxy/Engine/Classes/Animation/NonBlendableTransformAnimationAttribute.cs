using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NonBlendableTransformAnimationAttribute")]
	public partial class FNonBlendableTransformAnimationAttribute : FTransformAnimationAttribute, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NonBlendableTransformAnimationAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNonBlendableTransformAnimationAttribute()
		{
		}

		public static bool operator ==(FNonBlendableTransformAnimationAttribute A, FNonBlendableTransformAnimationAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNonBlendableTransformAnimationAttribute A, FNonBlendableTransformAnimationAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNonBlendableTransformAnimationAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}