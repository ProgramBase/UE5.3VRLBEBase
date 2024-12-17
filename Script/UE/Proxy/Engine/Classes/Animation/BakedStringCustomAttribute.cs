using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BakedStringCustomAttribute")]
	public partial class FBakedStringCustomAttribute : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BakedStringCustomAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBakedStringCustomAttribute() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBakedStringCustomAttribute() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBakedStringCustomAttribute A, FBakedStringCustomAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBakedStringCustomAttribute A, FBakedStringCustomAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBakedStringCustomAttribute;

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

		public FStringCurve StringCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StringCurve, __ReturnBuffer);

					return *(FStringCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StringCurve, __InBuffer);
				}
			}
		}

		private static uint __AttributeName = 0;

		private static uint __StringCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}