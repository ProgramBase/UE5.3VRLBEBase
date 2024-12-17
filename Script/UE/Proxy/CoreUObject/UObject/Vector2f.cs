using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Vector2f")]
	public partial class FVector2f : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Vector2f");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector2f() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVector2f() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVector2f A, FVector2f B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector2f A, FVector2f B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector2f;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float X
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __X, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __X, __InBuffer);
				}
			}
		}

		public float Y
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Y, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Y, __InBuffer);
				}
			}
		}

		private static uint __X = 0;

		private static uint __Y = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}