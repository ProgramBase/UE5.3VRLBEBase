using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.TransformNoScale")]
	public partial class FTransformNoScale : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.TransformNoScale");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformNoScale() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTransformNoScale() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTransformNoScale A, FTransformNoScale B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformNoScale A, FTransformNoScale B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformNoScale;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Location
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Location, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Location, __InBuffer);
				}
			}
		}

		public FQuat Rotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __InBuffer);
				}
			}
		}

		private static uint __Location = 0;

		private static uint __Rotation = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}