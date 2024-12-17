using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BakedIntegerCustomAttribute")]
	public partial class FBakedIntegerCustomAttribute : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BakedIntegerCustomAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBakedIntegerCustomAttribute() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBakedIntegerCustomAttribute() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBakedIntegerCustomAttribute A, FBakedIntegerCustomAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBakedIntegerCustomAttribute A, FBakedIntegerCustomAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBakedIntegerCustomAttribute;

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

		public FIntegralCurve IntCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntCurve, __ReturnBuffer);

					return *(FIntegralCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntCurve, __InBuffer);
				}
			}
		}

		private static uint __AttributeName = 0;

		private static uint __IntCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}