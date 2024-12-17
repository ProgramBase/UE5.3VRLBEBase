using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimatedBoneAttribute")]
	public partial class FAnimatedBoneAttribute : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimatedBoneAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimatedBoneAttribute() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimatedBoneAttribute() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimatedBoneAttribute A, FAnimatedBoneAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimatedBoneAttribute A, FAnimatedBoneAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimatedBoneAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAnimationAttributeIdentifier Identifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __ReturnBuffer);

					return *(FAnimationAttributeIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __InBuffer);
				}
			}
		}

		public FAttributeCurve Curve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __ReturnBuffer);

					return *(FAttributeCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __InBuffer);
				}
			}
		}

		private static uint __Identifier = 0;

		private static uint __Curve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}