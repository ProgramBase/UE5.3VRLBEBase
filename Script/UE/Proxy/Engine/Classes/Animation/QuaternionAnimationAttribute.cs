using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.QuaternionAnimationAttribute")]
	public partial class FQuaternionAnimationAttribute : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.QuaternionAnimationAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQuaternionAnimationAttribute() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQuaternionAnimationAttribute() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQuaternionAnimationAttribute A, FQuaternionAnimationAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQuaternionAnimationAttribute A, FQuaternionAnimationAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQuaternionAnimationAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FQuat Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}