using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BakedFloatCustomAttribute")]
	public partial class FBakedFloatCustomAttribute : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BakedFloatCustomAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBakedFloatCustomAttribute() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBakedFloatCustomAttribute() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBakedFloatCustomAttribute A, FBakedFloatCustomAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBakedFloatCustomAttribute A, FBakedFloatCustomAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBakedFloatCustomAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName AttributeName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttributeName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttributeName, __InBuffer);
				}
			}
		}

		public FSimpleCurve FloatCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __ReturnBuffer);

					return *(FSimpleCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __InBuffer);
				}
			}
		}

		private static uint __AttributeName = 0;

		private static uint __FloatCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}